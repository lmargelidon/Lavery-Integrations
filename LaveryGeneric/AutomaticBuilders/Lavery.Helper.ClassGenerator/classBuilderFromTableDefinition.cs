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

namespace Lavery.Helper.ClassGenerator
{
    public class fieldDef : Composant
    {

        int iLen;
        Boolean isPK;
        Boolean isNullable;
        List<String> lAttributes = new List<String>();
        String sForeignTable;
        String sForeignColumn;
        Boolean bReorg = false;


        public fieldDef(String sName, Boolean IsPK, Boolean isNullable, String sExtendedTypeType = default(String), String sForeignTable = default(String), String sForeignColumn = default(String), List<String> lAttributes = default(List<String>), bool bReorg = false) : base(sName, sExtendedTypeType)
        {
            if (lAttributes != default(List<String>))
                this.LAttributes.AddRange(lAttributes);
            this.sForeignTable = sForeignTable;
            this.sForeignColumn = sForeignColumn;
            this.IsPK = IsPK;
            this.isNullable = isNullable;            
        }

        public int ILen { get => iLen; set => iLen = value; }
        public List<string> LAttributes { get => lAttributes; }
        public string SForeignTable { get => sForeignTable; }
        
        public bool IsNullable { get => isNullable; set => isNullable = value; }
        public string SForeignColumn { get => sForeignColumn; }
        public bool IsPK { get => isPK; set => isPK = value; }
        public bool BReorg { get => bReorg; set => bReorg = value; }

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
    
    public class classBuilderFromTableDefinition : Object
    {
        connectionFactory oConnectionFactory;
        String sConnectionStringName;
        String sSqlOutputStatement;
        Dictionary<String, fieldDef> oCompleteDicoField;

        public string SSqlOutputStatement { get => sSqlOutputStatement;  }
        public Dictionary<string, fieldDef> OCompleteDicoField { get => oCompleteDicoField; }

        public classBuilderFromTableDefinition(connectionFactory oConnectionFactory, String sConnectionStringName)
        {
            this.oConnectionFactory = oConnectionFactory;
            this.sConnectionStringName = sConnectionStringName;
        }
        public classBuilderFromTableDefinition(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;            
        }


        public void genereAllClasses(Composite oComposite, String sNameSpace, String sPath, String sFinalClassName, String sBaseTableName)
        {
            SqlConnection oConnection = default(SqlConnection);           

            using (oConnection = new SqlConnection(oConnectionFactory.ConnectionString(sConnectionStringName)))
            {
                oConnection.Open();
                genereAllClasses(oConnection, oComposite, sNameSpace, sPath, sFinalClassName, sBaseTableName);
               
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
                        fieldDef oDef = new fieldDef("L" + oValue.SName, false, false, String.Format("List<{0}>", oValue.SName));
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
                writeClasse(oDicField, sPath, sNameSpace, sClasseName, true, "responseBase");
        }
        public String genereSqlStatement(SqlConnection oConnection, String sSqlStatement, String sBaseTable,
                                            List<String> lAssociatedTable = default(List<String>),
                                            List<String> lTableDirectRelationToInclude = default(List<String>))
        {
            String sRet = "";
            /*
            sRet = "select * from {0} {3}";


            Dictionary<String, KeyValuePair<String, List<fieldDef>>> oDicoTemp = new Dictionary<String, KeyValuePair<String, List<fieldDef>>>();

            Dictionary<String, fieldDef> oDicField = getListOfFields(oConnection, sSqlStatement, lAssociatedTable, lTableDirectRelationToInclude);
            String sMemTableName = "";
            List<fieldDef> lFK = default(List<fieldDef>);
            String sKey = default(String);
            int iPrefix = 1;
            foreach (KeyValuePair<String, fieldDef> oEntry in oDicField.OrderBy(ch => ch.Key).ToList())
            {
                String sEntTableName = oEntry.Key.Split('|')[0];


                if (!sEntTableName.Equals(sMemTableName, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (sKey != default(String))
                        if (sMemTableName.Equals(sBaseTable))
                            oDicoTemp.Add(String.Format("A00|{1}", iPrefix++, sMemTableName), new KeyValuePair<String, List<fieldDef>>(sKey, lFK));
                        else
                            oDicoTemp.Add(String.Format("A{0:D2}|{1}", iPrefix++, sMemTableName), new KeyValuePair<String, List<fieldDef>>(sKey, lFK));

                    sMemTableName = sEntTableName;
                    lFK = new List<fieldDef>();
                    sKey = default(String);
                }

                if (oEntry.Value.LAttributes.AsEnumerable().Contains("Key"))
                    sKey = oEntry.Value.SName;
                if (oEntry.Value.SForeignTable.Length > 0)
                    lFK.Add(oEntry.Value);
            }
            if (sKey != default(String))
                oDicoTemp.Add(sMemTableName, new KeyValuePair<String, List<fieldDef>>(sKey, lFK));

            String sFrom = "";
            List<String> lPerformed = new List<String>();
            foreach (KeyValuePair<String, KeyValuePair<String, List<fieldDef>>> oTemp in oDicoTemp.OrderBy(ch => ch.Key).ToList())
            {
                String sEntTableName = oTemp.Key.Split('|')[1];
                String sPref = oTemp.Key.Split('|')[0];
                if (sPref.Equals("00"))
                {
                    sFrom = sEntTableName + " " + sPref;
                    lPerformed.Add(sEntTableName);
                }
                else
                {
                    foreach (fieldDef oFD in oTemp.Value.Value)
                    {
                        KeyValuePair<String, KeyValuePair<String, List<fieldDef>>> oTarget = oDicoTemp.First(o => o.Key.Split('|')[1].Equals(oFD.SForeignTable));
                        sFrom += (String.Format("left outer join {0} {1}  on {1}.{2} = {4}.{3}", sEntTableName, sPref, oTarget.Key.Split('|')[0], oFD.SForeignTable));
                        // voir la reccurssion des tables liee quand plusieurs...
                    }
                }
            }
            */
            return sRet;
        }
        
        public List<String> genereEntities(SqlConnection oConnection, String sNameSpace, String sPath, String sSqlStatement, 
                                            List<String> lAssociatedTable = default(List<String>),
                                            List<String> lTableDirectRelationToInclude = default(List<String>))
        {
            List<String> lRet = new List<String>();
            // TableName, ColumnName, TargetTableName,  ColumnType, ColumnMaxLength, ColumnPrecision, ColumnScale
            String sMemTableName = "";
            oCompleteDicoField = getListOfFields(oConnection, sSqlStatement, lAssociatedTable, lTableDirectRelationToInclude);

            Dictionary<String, fieldDef> oDicFieldFinal = default(Dictionary<String, fieldDef>);
            foreach (KeyValuePair<String, fieldDef> oEntry in oCompleteDicoField.OrderBy(ch => ch.Key).ToList())
            {
                String sEntTableName = oEntry.Key.Split('|')[0];
                if (!sEntTableName.Equals(sMemTableName, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (oDicFieldFinal != default(Dictionary<String, fieldDef>))
                        writeClasse(oDicFieldFinal, sPath, sNameSpace, sMemTableName, true, "Object",  "Models");
                    oDicFieldFinal = new Dictionary<String, fieldDef>();
                    sMemTableName = sEntTableName;
                    lRet.Add(sMemTableName);
                    
                }
                oDicFieldFinal.Add(oEntry.Key, oEntry.Value);
            }
            if(oDicFieldFinal != default(Dictionary<String, fieldDef>))
                writeClasse(oDicFieldFinal, sPath, sNameSpace, sMemTableName, true, "Object", "Models");

            return lRet;

        }
        private Dictionary<String, fieldDef> getListOfFields(    SqlConnection oConnection, String sSqlStatement,
                                                                List<String> lAssociatedTable = default(List<String>),
                                                                List<String> lTableDirectRelationToInclude = default(List<String>))
        {
            
            // TableName, ColumnName, TargetTableName,  ColumnType, ColumnMaxLength, ColumnPrecision, ColumnScale
           
            Dictionary<String, fieldDef> oDicField = new Dictionary<String, fieldDef>();
            Dictionary<String, fieldDef> oUpdatedField = new Dictionary<String, fieldDef>();

            using (var command = new SqlCommand(sSqlStatement, oConnection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            String sTableName = "";
                            String sColName = "";
                            String sTargetTableName = "";
                            String sTargetColumnName = "";
                            String sColumnType = "";
                            int iColumnMaxLength = -1;
                            Boolean isNullable = false;
                            Boolean isPk = false;
                            Byte iColumnPrecision = default(Byte);
                            Byte iColumnScale = default(Byte);

                            List<String> lAttr = new List<string>();
                            fieldDef oField = default(fieldDef);
                            if (reader["TableName"] != DBNull.Value)
                                sTableName = (String)reader["TableName"];
                            if (reader["ColumnName"] != DBNull.Value)
                                sColName = (String)reader["ColumnName"];
                            if (reader["TargetTableName"] != DBNull.Value)
                                sTargetTableName = (String)reader["TargetTableName"];
                            if (reader["TargetColumn"] != DBNull.Value)
                                sTargetColumnName = (String)reader["TargetColumn"];
                            if (reader["ColumnType"] != DBNull.Value)
                                sColumnType = (String)reader["ColumnType"];
                            if (reader["isNullable"] != DBNull.Value)
                                isNullable = ((String)reader["isNullable"]).Equals("Yes", StringComparison.InvariantCultureIgnoreCase);
                            if (reader["is_PK"] != DBNull.Value)
                                isPk = (Int32)reader["is_PK"] != 0;
                            if (reader["ColumnMaxLength"] != DBNull.Value)
                                iColumnMaxLength = (Int16)reader["ColumnMaxLength"];
                            if (reader["ColumnPrecision"] != DBNull.Value)
                                iColumnPrecision = (Byte)reader["ColumnPrecision"];
                            if (reader["ColumnScale"] != DBNull.Value)
                                iColumnScale = (Byte)reader["ColumnScale"];

                            String sPrefixe = "";
                            if (isPk)
                            {
                                lAttr.Add("Key");
                                sPrefixe = "AA-";
                            }

                            if (lTableDirectRelationToInclude == default(List<String>) ||
                                lTableDirectRelationToInclude.FirstOrDefault(item => item == sTableName) != default(String) ||
                                lAssociatedTable.FirstOrDefault(item => item == sTableName) != default(String)
                                )
                            {
                                Console.WriteLine(sTableName + "|" + sPrefixe + sColName);
                                if (sTargetTableName.Length > 0 && (lAssociatedTable == default(List<String>) || lAssociatedTable.AsEnumerable().Contains(sTableName)))
                                {
                                    lAttr = new List<string>();
                                    lAttr.Add(String.Format(LaveryTemplates.sODataDirectRelationAttribut, sTableName, sTargetTableName));
                                    oField = new fieldDef(sColName, isNullable, isNullable, sColumnType, sTargetTableName, sTargetColumnName, lAttr);                                    
                                    oDicField.Add(sTableName + "|BB1" + sPrefixe + sColName, oField);

                                    lAttr = new List<string>();
                                    String sName = String.Format(LaveryTemplates.sODataDirectRelationField, sTableName, sTargetTableName);
                                    oField = new fieldDef(sName, isPk, false, sTargetTableName, "", "", lAttr);
                                    oField.IsNullable = false;
                                    oDicField.Add(sTableName + "|BB2" + sPrefixe + sName, oField);

                                    sColName = sTableName + "s";
                                    lAttr = new List<string>();
                                    lAttr.Add(String.Format(LaveryTemplates.sODataInverseRelationAttribut, sTableName, sTargetTableName));
                                    oField = new fieldDef(sColName, isPk, isNullable, String.Format("ICollection<{0}>", sTableName), sTableName, "", lAttr);
                                    oDicField.Add(sTargetTableName + "|" + sPrefixe + sColName, oField);
                                    sTableName = sTargetTableName;
                                }
                                else
                                {
                                    oField = new fieldDef(sColName, isPk, isNullable, default(String), sTargetTableName, sTargetColumnName, lAttr);
                                    oDicField.Add(sTableName + "|" + sPrefixe + sColName, oField);
                                }


                                try
                                {
                                    oField.setTypeFromSqlType(sColumnType);
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

                
                foreach (KeyValuePair<String, fieldDef> oEntry in oDicField.OrderBy(ch => ch.Key).ToList())
                {
                    String sEntTableName = oEntry.Key.Split('|')[0];
                    fieldDef oField = oEntry.Value;
                    if (oField.SForeignTable.Length > 0 && oField.SForeignColumn.Length > 0 )
                    {
                        String sType = oEntry.Value.SExtendedTypeType != default(String) ? oEntry.Value.SExtendedTypeType : oEntry.Value.OType.ToString();
                        // ******************************************************
                        // Type genere automatiquement par foreign key inverse
                        // Pas de traitement de primary Key dans ce cas
                        // *****************************************************
                        if(!sType.StartsWith("ICollection < "))
                            setNewPrimaryKey(oDicField, oUpdatedField, oField.SForeignTable, oField.SForeignColumn);
                    }
                }
                foreach (KeyValuePair<String, fieldDef> oEntry in oDicField.OrderBy(ch => ch.Key).ToList())
                    if (!oEntry.Value.BReorg)
                        oUpdatedField.Add(oEntry.Key, oEntry.Value);

            }
            
            return oUpdatedField;
        }
        private void setNewPrimaryKey(Dictionary<String, fieldDef> oDicField, Dictionary<String, fieldDef> oUpdatedField, String sTargetTable, String sTargetColumn)
        {            
            try 
            {
                foreach (KeyValuePair<String, fieldDef> oEntry in oDicField.OrderBy(ch => ch.Key).ToList())
                {
                    String sEntTableName = oEntry.Key.Split('|')[0];
                    fieldDef oField = oEntry.Value;
                    String sNewField = oEntry.Key.Split('|')[1];
                    sNewField = sNewField.Replace("AA-", "").Replace("BB1", "").Replace("BB2", "");
                    int iCount = 0;
                    if (sEntTableName.Equals(sTargetTable) && !oField.BReorg)
                    {
                        if (oField.IsPK && !oField.SForeignColumn.Equals(sTargetColumn))
                        {
                            oField.IsPK = false;
                            oField.BReorg = true;
                            oField.LAttributes.RemoveAll(x => x == "Key");
                            sNewField = oField.SName;
                            oUpdatedField.Add(sEntTableName + "|" + sNewField, oField);
                        }
                       else
                            if (!oField.IsPK && oField.SName.Equals(sTargetColumn))                           
                                if (iCount++ == 0)
                                {
                                    oField.IsPK = true;
                                    oField.BReorg = true;
                                    oField.LAttributes.Add("Key");
                                    sNewField = "AA-" + oField.SName;
                                    oUpdatedField.Add(sEntTableName + "|" + sNewField, oField);
                                }
                                else {
                                    iCount++;
                                    oField.BReorg = true;
                                    oUpdatedField.Add(oEntry.Key, oField);

                                }
                           
                    }
                   
                }
            }
            catch (Exception ex)
            { 
            }
           
        }
        private void writeClasse(Dictionary<String, fieldDef> oDicField, String sPath, String sNameSpace, String sClasseName, Boolean isForEntityFramework, String sDerivedClass,
                                 String sSubFolder = default(String))
        {

            String sAttributes = "";
            String sInitialize = "";
            foreach(KeyValuePair<String, fieldDef> oPair in  oDicField)
            {
                if (oPair.Value.OType == default(Type))
                    adjustTypeApproximatively(oPair.Value);

                if (isForEntityFramework)
                {
                    String sAttr = "";
                    foreach (String s in oPair.Value.LAttributes)
                        sAttr += String.Format("\t\t\t[{0}]", s);

                    String sType = oPair.Value.SExtendedTypeType != default(String) ? oPair.Value.SExtendedTypeType : oPair.Value.OType.ToString();
                    if (sType.Equals("Boolean") || sType.Equals("System.Boolean"))
                        sType = "byte";
                    else
                        if (sType.StartsWith("ICollection<"))
                            sInitialize += ("\t\t\t\t" + String.Format(LaveryTemplates.sOSataAddIntializeTemplate, oPair.Value.SName, oPair.Value.SForeignTable)+ "\n");
                    if (oPair.Value.IsNullable && 
                        !sType.Equals("System.String") && !sType.Contains("ICollection") &&
                        !oPair.Value.SName.StartsWith("Link"))
                        sAttributes += String.Format(LaveryTemplates.sOdataAttributesNullabeTemplate, sType, oPair.Value.SName.Replace(".", "_").Replace("AA-", ""), sAttr);
                    else
                        sAttributes += String.Format(LaveryTemplates.sOdataAttributesTemplate, sType, oPair.Value.SName.Replace(".", "_").Replace("AA-", ""), sAttr);
                }
                else
                {
                    String sType = oPair.Value.SExtendedTypeType != default(String) ? oPair.Value.SExtendedTypeType : oPair.Value.OType.ToString();
                    if (sType.Equals("Boolean"))
                        sType = "byte";
                    if (oPair.Value.IsNullable && !sType.Equals("System.String"))
                        sAttributes += String.Format(LaveryTemplates.sAttributesNullabeTemplate, sType, oPair.Value.SName.Replace(".", "_"));
                    else
                        sAttributes += String.Format(LaveryTemplates.sAttributesTemplate, sType, oPair.Value.SName.Replace(".", "_"));
                }

            }
            String sOut = String.Format(LaveryTemplates.sClasseTemplate, sNameSpace, sClasseName, sAttributes, sDerivedClass);
            if (isForEntityFramework)
                sOut = String.Format(LaveryTemplates.sODataClasseTemplate, sNameSpace, sClasseName, sAttributes, sInitialize);
            else
            {                
                sOut = String.Format(LaveryTemplates.sClasseTemplate, sNameSpace, sClasseName, sAttributes, sDerivedClass);
            }
            if (sPath[sPath.Length - 1] != '\\')
                sPath += '\\';
            if (sSubFolder != default(String))
                sPath += (sSubFolder + '\\');
            using (var sw = new StreamWriter(string.Format("{0}{1}.cs", sPath, sClasseName)))
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
                sType = "byte";
            else if (sColName.Substring(0, 3).Equals("has", StringComparison.CurrentCultureIgnoreCase))
                sType = "byte";

            oField.setTypeFromSqlType(sType);
          
        }
        
        

    }
}
