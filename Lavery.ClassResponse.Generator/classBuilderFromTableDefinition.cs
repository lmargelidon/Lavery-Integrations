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
using Lavery.Tools;

namespace Lavery.ClassResponse.Generator
{
    public class fieldDef : Composant
    {

        int iLen;
        
        public fieldDef(String sName, String sExtendedTypeType = default(String)) : base(sName, sExtendedTypeType)
        {            
            
        }

        public int ILen { get => iLen; set => iLen = value; }

        public void setTypeFromSqlType(String sWithSqlType)
        {
            if (SExtendedTypeType == default(String))
            {
                if (sWithSqlType.Equals("varchar", StringComparison.CurrentCultureIgnoreCase) ||
                    sWithSqlType.Equals("nvarchar", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(String);
                else if (sWithSqlType.Equals("uniqueidentifier", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(Guid);
                else if (sWithSqlType.Equals("int", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(int);
                else if (sWithSqlType.Equals("tinyint", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(Boolean);
                else if (sWithSqlType.Equals("Boolean", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(Boolean);
                else if (sWithSqlType.Equals("dateTime", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(DateTime);
                else if (sWithSqlType.Equals("date", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(DateTime);
                else if (sWithSqlType.Equals("void", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(void);
                else if (sWithSqlType.Equals("decimal", StringComparison.CurrentCultureIgnoreCase))
                    OType = typeof(Decimal);
                else
                    throw (new Exception(String.Format("Type Sql<{0}> not supported", sWithSqlType)));
            }
        }
    }
    /*
   
    public class tableDS : Object 
    {
        
        String sSchema;
        String sTableName;
        composansite oComposansite;
        public tableDS(String sSchema, String sTableName)
        {
            this.sSchema = sSchema;
            this.sTableName = sTableName;                        
        }

        public string SSchema { get => sSchema;  }
        public string STableName { get => sTableName;  }
        public composansite OComposansite { get => oComposansite; }

        public void addField(String sFieldName)
        {
            oComposansite.add(new fieldDef(sFieldName));
        }
        public composansite addComposite(String sComposansite, String sCompisteParent)
        {
            composansite oRet = default(composansite);
            if (sCompisteParent == default(String))
            {
                oComposansite = new composansite(sComposansite);
                oRet = oComposansite;
            }
            else
                if (oComposansite.SName.Equals(sCompisteParent))
                {
                    oRet = new composansite(sComposansite);
                    oComposansite.add(oRet);
                }
                else
                    foreach (composantBase oBase in oComposansite.LComposants)
                    if(oBase.GetType() = kindoff
                        
        }        
    }
    */
    public class classBuilderFromTableDefinition : Object
    {
        connectionFactory oConnectionFactory;
        String sConnectionStringName;

        public classBuilderFromTableDefinition(connectionFactory oConnectionFactory, String sConnectionStringName)
        {
            this.oConnectionFactory = oConnectionFactory;
            this.sConnectionStringName = sConnectionStringName;
        }

        public void genereAllClasses(Composite oComposite, String sNameSpace, String sPath, String sFinalClassName, String sBaseTableName)
        {
            SqlConnection oConnection = default(SqlConnection);           

            using (oConnection = new SqlConnection(oConnectionFactory.ConnectionString(sConnectionStringName)))
            {
                oConnection.Open();
                genereAllClasses(oConnection, oComposite, sNameSpace, sPath, sFinalClassName, sBaseTableName);
               /*
                Dictionary<String, fieldDef> oDicField = new Dictionary<String, fieldDef>();
                fieldDef oDef = new fieldDef("L" + sFinalClassName + "s", String.Format("List<{0}>", sFinalClassName));
                oDicField.Add(sFinalClassName, oDef);
                genereClass(oConnection, oDicField, sNameSpace, sPath, sFinalClassName + "s", sBaseTableName);
               */
            }
            if (oConnection != default(SqlConnection))
                oConnection.Close();

        }
        public void genereAllClasses(SqlConnection oConnection, Composite oComposite, String sNameSpace, String sPath, String sFinalClassName, String sBaseTableName)
        {   
            Dictionary<String, fieldDef> oDicField = new Dictionary<String, fieldDef>();

            
            foreach (ComposantComposite oValue in oComposite.LComposants)
            {
                if (oValue.GetType() == typeof(Composite))
                {
                    genereAllClasses(oConnection, (Composite)oValue, sNameSpace, sPath, oValue.SName, oValue.SName);
                    try
                    {
                        fieldDef oDef = new fieldDef("L" + oValue.SName, String.Format("List<{0}>", oValue.SName));
                        oDicField.Add(oValue.SName, oDef);
                    }
                    catch (Exception ex)
                    { 
                    }
                }
                else
                    oDicField.Add(oValue.SName,  (fieldDef)oValue);
                // genereClass(oConnection, oValue, sNameSpace, sPath, sFinalClassName);
            }
            genereClass(oConnection, oDicField, sNameSpace, sPath, sFinalClassName, sBaseTableName);

           
        }

        private void genereClass(SqlConnection oConnection, Dictionary<String, fieldDef> oDicField , String sNameSpace, String sPath, String sClasseName, String sBaseTableName)
        {
                
                using (var command = new SqlCommand(String.Format("select * from information_schema.columns where table_schema = '{0}' and table_name = '{1}'", "dbo", sBaseTableName), oConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {     
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
                    sAttributes += String.Format(LaveryTemplates.sAttributesTemplate, oPair.Value.SExtendedTypeType!= default(String)? oPair.Value.SExtendedTypeType : oPair.Value.OType.ToString(), oPair.Value.SName.Replace(".", "_"));
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
                sType = "Boolean";
            else if (sColName.Substring(0, 3).Equals("has", StringComparison.CurrentCultureIgnoreCase))
                sType = "tinyint";

            oField.setTypeFromSqlType(sType);
          
        }
        
        

    }
}
