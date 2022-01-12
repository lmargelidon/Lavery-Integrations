using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools.Configuration.Management;
using System.Data;
using System.Data.SqlClient;
using Lavery.Constants;

namespace Lavery.ClassResponse.Generator
{
    public class fieldDef
    {
        String sName;
        Type oType;
        int iLen;
        public fieldDef(String sName)
        {
            this.sName = sName;
        }

        public Type OType { get => oType; set => oType = value; }
        public int ILen { get => iLen; set => iLen = value; }
        public string SName { get => sName; }

        public void setTypeFromSqlType(String sWithSqlType)
        {
            if (sWithSqlType.Equals("varchar", StringComparison.CurrentCultureIgnoreCase) ||
                sWithSqlType.Equals("nvarchar", StringComparison.CurrentCultureIgnoreCase))
                oType = typeof(String);
            else if (sWithSqlType.Equals("uniqueidentifier", StringComparison.CurrentCultureIgnoreCase))
                oType = typeof(Guid);
            else if (sWithSqlType.Equals("int", StringComparison.CurrentCultureIgnoreCase))
                oType = typeof(int);
            else if (sWithSqlType.Equals("tinyint", StringComparison.CurrentCultureIgnoreCase))
                oType = typeof(Boolean);
            else if (sWithSqlType.Equals("dateTime", StringComparison.CurrentCultureIgnoreCase))
                oType = typeof(DateTime);
            else if (sWithSqlType.Equals("date", StringComparison.CurrentCultureIgnoreCase))
                oType = typeof(DateTime);
            else if (sWithSqlType.Equals("void", StringComparison.CurrentCultureIgnoreCase))
                oType = typeof(void);
            else if (sWithSqlType.Equals("decimal", StringComparison.CurrentCultureIgnoreCase))
                oType = typeof(Decimal);
            else
                throw (new Exception(String.Format("Type Sql<{0}> not supported", sWithSqlType)));
        }   
    }
    public class tableDS : Object 
    {
        
        String sSchema;
        String sTableName;
        List<fieldDef> lField;
        public tableDS(String sSchema, String sTableName)
        {
            this.sSchema = sSchema;
            this.sTableName = sTableName;
            lField = new List<fieldDef>();            
        }

        public string SSchema { get => sSchema;  }
        public string STableName { get => sTableName;  }
        public List<fieldDef> LField { get => lField; }

        public void addField(String sFieldName)
        {
            LField.Add(new fieldDef(sFieldName));
        }
    }
    public class classBuilderFromTableDefinition : Object
    {
        connectionFactory oConnectionFactory;
        String sConnectionStringName;

        public classBuilderFromTableDefinition(connectionFactory oConnectionFactory, String sConnectionStringName)
        {
            this.oConnectionFactory = oConnectionFactory;
            this.sConnectionStringName = sConnectionStringName;
        }

        public void genereAllClasses(Dictionary<String, tableDS> oDico, String sNameSpace, String sPath, String sFinalClassName)
        {
            SqlConnection oConnection = default(SqlConnection);
            using (oConnection = new SqlConnection(oConnectionFactory.ConnectionString(sConnectionStringName)))
            {
                oConnection.Open();
                foreach (KeyValuePair<String, tableDS> oPair in oDico)
                {
                    genereClass(oConnection, oPair.Value, sNameSpace, sPath, sFinalClassName);
                }
            }
            if(oConnection != default(SqlConnection))
                oConnection.Close();
            
        }
        
        private void genereClass(SqlConnection oConnection, tableDS oTableDs, String sNameSpace, String sPath, String sClasseName)
        {

                Dictionary<String, fieldDef> oDicField = new Dictionary<String, fieldDef>();
                using (var command = new SqlCommand(String.Format("select * from information_schema.columns where table_schema = '{0}' and table_name = '{1}'", oTableDs.SSchema, oTableDs.STableName), oConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        foreach (fieldDef oField in oTableDs.LField)
                            oDicField.Add(oField.SName, oField);
                        try
                        {
                            while (reader.Read())
                            {
                                String sColName = (String)reader["column_Name"];
                                if (oDicField.ContainsKey(sColName))
                                {
                                    fieldDef oField = oDicField[sColName];
                                    try
                                    {
                                        oField.setTypeFromSqlType((String)reader["Data_Type"]);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Exception catched : " + ex.Message);
                                        adjustTypeApproximatively(oField);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                 
                }
                String sAttributes = "";
                foreach( KeyValuePair<String, fieldDef> oPair in  oDicField)
                {
                    if (oPair.Value.OType == default(Type))
                        adjustTypeApproximatively(oPair.Value);                        
                    sAttributes += String.Format(LaveryTemplates.sAttributesTemplate, oPair.Value.OType.ToString(), oPair.Value.SName.Replace(".", "_"));
                }
                String sOut = String.Format(LaveryTemplates.sClasseTemplate, sNameSpace, sClasseName, sAttributes);
                if(sPath[sPath.Length - 1] != '\\')
                    sPath += '\\';
                using (var sw = new StreamWriter(string.Format("{0}{1}.cs", sPath,sClasseName)))
                    sw.WriteLine(sOut);

        }
        private void adjustTypeApproximatively(fieldDef oField)
        {
            String sType = "nvarchar";
            String[] aVal = oField.SName.Split('.');
            String sColName = aVal[aVal.Length - 1];

            if (sColName.Equals("ItemID", StringComparison.CurrentCultureIgnoreCase))
                sType = "uniqueidentifier";
            else if(sColName.Substring(0, 2).Equals("is", StringComparison.CurrentCultureIgnoreCase))
                sType = "tinyint";
            else if (sColName.Substring(0, 3).Equals("has", StringComparison.CurrentCultureIgnoreCase))
                sType = "tinyint";

            oField.setTypeFromSqlType(sType);
        }
    }
}
