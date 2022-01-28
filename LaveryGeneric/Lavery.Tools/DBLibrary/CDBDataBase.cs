using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Lavery.Tools.Interfaces;
using Lavery.Tools.ConnectionPool;
using Lavery.Tools.Connections;


namespace Lavery.Tools.DBLibrary
{/*
    public class DBUserTableFieldDefinition
    {
        public String   sFieldName = "";
        public String   sFieldType = "";
        public bool     bIdentity  = false;
         public bool     bForeignKey = false;
        public String   sTableTaget = "";

    }
    public class DBUserTableDefinition
    {
        public String sTableName = "";
        public List<DBUserTableFieldDefinition> lColDef = new List<DBUserTableFieldDefinition>();
     }
    */
    public enum eDBResourceType { Nothing, Table, View, StoreProcedure, DynamicSqlStatement };
    public class DBResourceFieldDefinition
    {
        public String sFieldName = ""; 
        public String sFieldType = "";
        public int iFieldMaxLength = -1;
        public int iPrecision = -1;
        public int iScale = -1;
        public Boolean bIdentity = false;
        public String sTargetTable = "";
        public Boolean bForeignKey = false;
    }
    public class DBResourceDefinition
    {
        public String sResourceName = "";
        public String sResourceSchema = "";
        public eDBResourceType eResourceType = eDBResourceType.Nothing;
        public String sStatement = "";
        public List<DBResourceFieldDefinition> lColDef = new List<DBResourceFieldDefinition>();
    }

    public class CDBDataBase : CDBObject
    {
        private ConnectionPoolDatabases<IGenericConnection> oPool = default(ConnectionPoolDatabases<IGenericConnection>);
        private String sConnectString = null;

        
        static private ConnectionPool<IGenericConnection, genericSqlConnection> oPoolSqlServer = new ConnectionPool<IGenericConnection, genericSqlConnection>();
        
        

        private String sName = null;
        public enum eClassOfField { ALPHANUMERIC, NUMERIC };

        public ConnectionPoolDatabases<IGenericConnection> OPool
        {
            get { return oPool; }
            set { oPool = value; }
        }

        static public IGenericConnection getConnection(String sWithKeyConnectionString)
        {
            IGenericConnection oRet = default(IGenericConnection);
            
            try
            {
                oRet = oPoolSqlServer.getConnection(sWithKeyConnectionString);
            }
            catch (Exception ex)
            {
                    throw (ex);
            
            }
        

            return oRet;
        }
        static public Boolean releaseConnection(IGenericConnection oWithConnection)
        {
            Boolean bRet = false;

           
            try
            {
                bRet = oPoolSqlServer.releaseGenericConnection(oWithConnection);
            }
           
            catch (Exception ex)
            {
                throw (ex);
            }
            
            return bRet;
            
        }
        
        public String SConnectString
        {
            get { return sConnectString; }
            set { sConnectString = value; }
        }
        public String SName
        {
            get { return sName; }
            set { sName = value; }
        }
       
        public CDBDataBase(
                   ConnType.eConnType eWithType,
                   String sWithName)
        {
            try
            {
                sName = sWithName;
                eType = eWithType;
            }
            catch (Exception ex)
            {
                throw (ex); 
                throw (ex);
            }
            finally
            {
                
            }
        }

        /*
        public int countAvailableConnection(eTypeOfConnection eWithToc, ConnType.eConnType eWithType)
        {
            int iRet = 0;
            try
            {
                iRet = pConnFactory.countAvailableConnection(eWithToc, eWithType);

            }
            catch (Exception ex)
            {
                throw (ex);

            }
            return iRet;
        }
         * */
        public int countAvailableConnection(eTypeOfConnection eWithToc, String sConnectionString)
        {
            int iRet = 0;
            try
            {
                iRet = oPool.Count(sConnectionString);

            }
            catch (Exception ex)
            {
                
                throw (ex);

            }
            return iRet;
        }
        public CTable createTable(ConnType.eConnType eWithType, String sWithSchema, String sWithName, String sWithAlias, ConnectionPoolDatabases<IGenericConnection> pWithConnFactory)
        {
            CTable pRet = null;
            try
            {
                if (eWithType == ConnType.eConnType.DB2UDB)
                {
#if DB2 
                    pRet = new CTableForDB2UDB(sWithSchema, sWithName, sWithAlias, pWithConnFactory);
#endif

                }
                if (eWithType == ConnType.eConnType.SQLSERVER)
                {
                    pRet = new CTableForSqlServer(sWithSchema, sWithName, sWithAlias, pWithConnFactory);

                }
                if (eWithType == ConnType.eConnType.ORACLE
)
                {
                    pRet = new CTableForSqlServer(sWithSchema, sWithName, sWithAlias, pWithConnFactory);

                }
            }
            catch (Exception ex)
            {
               
                throw (ex);
            }

            return pRet;
        }

        public CTable createAllTable(ConnType.eConnType eWithType, String sWithSchema, ConnectionPoolDatabases<IGenericConnection> pWithConnFactory)
        {
            CTable pRet = null;
            try
            {


            }
            catch (Exception ex)
            {
                
                throw (ex);
            }

            return pRet;
        }

        public bool DropTable(ConnType.eConnType eWithType, String sWithSchema, String sWithName, String sWithAlias, ConnectionPoolDatabases<IGenericConnection> pWithConnFactory)
        {
            bool bRet = true;

            try
            {
                CTable pTable = null;
                if (eWithType == ConnType.eConnType.DB2UDB)
                {
#if DB2 
                    pTable = new CTableForDB2UDB(sWithSchema, sWithName, sWithAlias, pWithConnFactory);
                     pTable.Drop();
#endif

                }
                if (eWithType == ConnType.eConnType.SQLSERVER)
                {
                    pTable = new CTableForSqlServer(sWithSchema, sWithName, sWithAlias, pWithConnFactory);
                    pTable.Drop();
                }


            }
            catch (Exception ex)
            {
                bRet = false;
               
                throw (ex);
            }

            return bRet;
        }
        public List<String> getListOfDatabases()
        {
            List<String> sDbList = new List<string>();
            try
            {

                CStatement pStatement = null;
                if (eType == ConnType.eConnType.SQLSERVER)
                {
                    pStatement = new CStatementForSqlServer(oPool, SConnectString);
                    pStatement.PrepareText("SELECT [name] FROM [master].[dbo].[sysdatabases];");
                }
                else
                {
                    /*
                    pStatement =    new CStatementForMySql(oPool, SConnectString);
                    pStatement.PrepareText("SHOW DATABASES;");
                    */
                }



                DataTable pTableResult = pStatement.ExecuteAndReturnResultSet();

                foreach (DataRow myRow in pTableResult.Rows)
                {
                    String sConnString = sConnectString;
                    String sDbName = "";
                    bool bAddDb = false;
                    if (eType == ConnType.eConnType.SQLSERVER)
                    {
                        sDbName = myRow[pTableResult.Columns["Name"]].ToString();

                        if (!sDbName.Equals("master", StringComparison.CurrentCultureIgnoreCase) &&
                            !sDbName.Equals("model", StringComparison.CurrentCultureIgnoreCase) &&
                             !sDbName.Equals("msdb", StringComparison.CurrentCultureIgnoreCase) &&
                            !sDbName.Equals("tempdb", StringComparison.CurrentCultureIgnoreCase))
                            bAddDb = true;
                        else
                            bAddDb = false;
                    }
                    else
                    {
                        sDbName = myRow[pTableResult.Columns[0]].ToString();
                        if (!sDbName.Equals("Information_Schema", StringComparison.CurrentCultureIgnoreCase) &&
                           !sDbName.Equals("Performance_Schema", StringComparison.CurrentCultureIgnoreCase) &&
                            !sDbName.Equals("MySql", StringComparison.CurrentCultureIgnoreCase) &&
                           !sDbName.Equals("test", StringComparison.CurrentCultureIgnoreCase))
                            bAddDb = true;
                        else
                            bAddDb = false;
                    }
                    if (bAddDb)
                        sDbList.Add(sDbName);

                }
            }
            catch (Exception ex)
            {
                
                throw (ex);
            }

            return sDbList;

        }
        public List<DBResourceDefinition> getListOfUserViews(String sWithDb)
        {
            List<DBResourceDefinition> lRet = new List<DBResourceDefinition>();
            try
            {
                lRet.AddRange(getListOfUserResources(sWithDb, eDBResourceType.View));
            }
            catch (Exception ex)
            { }
            return lRet;

        }
        public List<DBResourceDefinition> getListOfUserTables(String sWithDb)
        {
            List<DBResourceDefinition> lRet = new List<DBResourceDefinition>();
            try
            {
                lRet.AddRange(getListOfUserResources(sWithDb, eDBResourceType.Table));
            }
            catch (Exception ex)
            { }
            return lRet;

        }

        List<DBResourceDefinition> getListOfUserResources(String sWithDb, eDBResourceType eResource)
        {
            List<DBResourceDefinition> lRet = new List<DBResourceDefinition>();
            try
            {



                CResultSet sRes = null;
                //DataSet ds = null;
                String sSysResources = "";
                if( eResource == eDBResourceType.Table)
                    sSysResources = "sys.tables";
                if (eResource == eDBResourceType.View)
                    sSysResources = "sys.Views";
                if (eType == ConnType.eConnType.SQLSERVER)
                {
                    sRes = new CResultSetForSqlServer(sConnectString);
                    // ds = sRes.executeSelect("SELECT Name, TYPE_DESC, OBJECT_ID FROM sys.Tables  AS DBTable;", "DBTable");
                    sRes.executeSelect(String.Format(  @"  SELECT  sys.schemas.name + '.' + {0}.Name AS Name, {1}.TYPE_DESC as TYPE_DESC, {2}.OBJECT_ID AS OBJECT_ID 
                                                            FROM  {3} INNER JOIN 
                                                            sys.schemas ON {4}.schema_id = sys.schemas.schema_id 
                                                            ORDER BY {5}.name;", sSysResources, sSysResources, sSysResources, sSysResources, sSysResources, sSysResources), "DBTable");


                }
                else
                {
                    /*
                    sRes = new CResultSetForMySql(oPool, sConnectString);
                    //ds = sRes.executeSelect("SELECT A.TABLE_NAME as NAME,A.TABLE_TYPE as TYPE_DESC, B.COLUMN_NAME AS OBJECT_ID FROM Information_Schema.Tables  AS A, Information_Schema.COLUMNS AS B where B.COLUMN_KEY = 'PRI' AND A.TABLE_SCHEMA=A.TABLE_SCHEMA;", "DBTable");
                    sRes.executeSelect("SELECT TAB.TABLE_NAME as NAME, TAB.TABLE_TYPE as TYPE_DESC, COL.COLUMN_NAME AS FIELD_ID" +
                                           " FROM Information_Schema.Tables as TAB, Information_Schema.Columns as COL " +
                                            " WHERE TAB.TABLE_SCHEMA = '" + sWithDb + "' AND " +
                                           " COL.TABLE_SCHEMA = '" + sWithDb + "' AND " +
                                            " TAB.TABLE_NAME = COL.TABLE_NAME AND " +
                                           " COL.COLUMN_KEY = 'PRI';", "DBTable");
                    */
                }

                while (sRes.readResultSet())
                {
                    String sName = sRes.getStringData("NAME");
                    String sSchema = "dbo";
                    char[] sSep = new char[1];
                    sSep[0] = '.';
                    String[] sVal1 = sName.Split(sSep);
                    if (sVal1.Length == 2 && !sWithDb.Equals("JIRA-4.2", StringComparison.CurrentCultureIgnoreCase))
                    {
                        sSchema = sVal1[0];
                        sName   = sVal1[1];

                    }
                    String sType = sRes.getStringData("TYPE_DESC");

                    String sObjectID = "";
                    if (eType == ConnType.eConnType.SQLSERVER)
                        sObjectID = sRes.getIntData("OBJECT_ID").ToString();


                    if (eResource == eDBResourceType.Table && sType.Equals("USER_TABLE", StringComparison.CurrentCultureIgnoreCase) && eType == ConnType.eConnType.SQLSERVER ||
                        eResource == eDBResourceType.View && sType.Equals("VIEW", StringComparison.CurrentCultureIgnoreCase) && eType == ConnType.eConnType.SQLSERVER )
                    {
                        CResultSet sResColumns = null;
                        //DataSet ds1 = null;
                        DBResourceDefinition oUTD = new DBResourceDefinition();
                        oUTD.sResourceName = sName;
                        oUTD.sResourceSchema = sSchema;
                        oUTD.eResourceType = eResource;

                        lRet.Add(oUTD);

                        if (eType == ConnType.eConnType.SQLSERVER)
                        {
                            sResColumns = new CResultSetForSqlServer(sConnectString);
                            // ds1 = sResColumns.executeSelect("SELECT A.NAME as NameCol, A.Is_IDENTITY AS ID, B.NAME AS TypeCol FROM sys.Columns AS A, sys.Types AS B Where A.system_type_id = B.system_type_id and A.User_type_id = B.user_type_id and A.Object_ID = " + sObjectID + ";", "DBTableCol");
                            /*
                             CASE A.is_identity 
                                WHEN 1 THEN
                                    cast(1 as bit)
                                else		
                                CASE c.name 
                                    WHEN OBJECT_NAME(f.referenced_object_id) THEN
                                        cast(1 as bit)
                                    ELSE
                                        cast(0 as bit)
                                END
                            END AS ID
                             */

                            String sStatement = String.Format(@"    SELECT Distinct A.name as NameCol, A.max_length as MaxLen, A.Precision as Precision, A.Scale as Scale,                                                                    
                                                                     A.is_identity AS ID, B.NAME AS TypeCol, c.name as Table_Name,OBJECT_NAME(f.referenced_object_id) TagetTableName
                                                                    FROM sys.Columns AS A
                                                                    INNER JOIN sys.Types AS B ON A.system_type_id = B.system_type_id and A.User_type_id = B.user_type_id  
                                                                     INNER JOIN {0} AS c ON C.object_id = A.object_id
                                                                     LEFT OUTER JOIN 
                                                                            sys.foreign_key_columns AS fc 
                                                                            ON a.object_id = fc.parent_object_id AND  A.NAME = COL_NAME(fc.parent_object_id,fc.parent_column_id) 
                                                                     LEFT OUTER JOIN 
                                                                            sys.foreign_keys AS f ON fc.constraint_object_id = f.OBJECT_ID                                                                        
                                                                    Where A.Object_ID = {1};", sSysResources, sObjectID);
                             sResColumns.executeSelect(sStatement, "DBTableCol");
                        }
                        else
                        {
                            /*
                            sResColumns = new CResultSetForMySql(oPool, sConnectString);
                            String sWithSelectClause = "SELECT A.COLUMN_NAME as NameCol, A.COLUMN_KEY AS ID, A.COLUMN_TYPE AS TypeCol FROM Information_Schema.COLUMNS AS A Where A.TABLE_NAME = '" + sName + "' AND A.TABLE_SCHEMA = '" + sWithDb + "';";
                            sResColumns.executeSelect(sWithSelectClause, "DBTableCol");
                            */
                        }

                        while (sResColumns.readResultSet())
                        {
                            
                            DBResourceFieldDefinition oUDBTF = new DBResourceFieldDefinition();
                            oUDBTF.sFieldName = sResColumns.getStringData("NameCol");
                            oUDBTF.sFieldType = sResColumns.getStringData("TypeCol");
                            oUDBTF.sTargetTable = sResColumns.getStringData("TagetTableName");
                            oUDBTF.bForeignKey = sResColumns.getStringData("TagetTableName").Length > 0 ? true : false;
                            oUDBTF.iFieldMaxLength = sResColumns.getIntData("MaxLen");
                            oUDBTF.iPrecision = sResColumns.getIntData("Precision");
                            oUDBTF.iScale = sResColumns.getIntData("Scale");
                            
                            if (oUDBTF.sFieldType.Equals("binary", StringComparison.CurrentCultureIgnoreCase) ||
                                oUDBTF.sFieldType.Equals("varbinary", StringComparison.CurrentCultureIgnoreCase) ||
                                oUDBTF.sFieldType.Equals("nvarchar", StringComparison.CurrentCultureIgnoreCase) ||
                                oUDBTF.sFieldType.Equals("nchar", StringComparison.CurrentCultureIgnoreCase))
                                oUDBTF.iFieldMaxLength /= 2;
                            if (eType == ConnType.eConnType.SQLSERVER)
                                oUDBTF.bIdentity = Convert.ToBoolean(sResColumns.getStringData("ID"));
                            else
                                oUDBTF.bIdentity = sResColumns.getStringData("ID").Equals("PRI", StringComparison.CurrentCultureIgnoreCase);
                            oUTD.lColDef.Add(oUDBTF);


                        }

                    }

                }
            }
            catch (Exception ex)
            {
               
                throw (ex);
            }
            return lRet;
        }
        
        
        public bool isTypeDefField(String sWithTypeToAnalyze, eClassOfField eClass)
        {

            bool bRet = false;
            try
            {
                List<String> lTypeOfField = new List<string>();


                CResultSet sResColumns = null;
               // DataSet ds1 = null;


                if (eType == ConnType.eConnType.SQLSERVER)
                {
                    sResColumns = new CResultSetForSqlServer(sConnectString);
                    sResColumns.executeSelect("SELECT distinct NAME AS TypeCol FROM sys.Types; ", "DBTableCol");

                }
                else
                {
                    /*
                    sResColumns = new CResultSetForMySql(oPool, sConnectString);

                    sResColumns.executeSelect("SELECT distinct DATA_TYPE AS TypeCol  FROM Information_Schema.COLUMNS; ", "DBTableCol");
                    */
                }
                while (sResColumns.readResultSet())
                {
                    String sTypeOfField = sResColumns.getStringData("TypeCol");
                    if (sTypeOfField.IndexOf("varchar", StringComparison.CurrentCultureIgnoreCase) >= 0 ||
                          sTypeOfField.IndexOf("Text", StringComparison.CurrentCultureIgnoreCase) >= 0 ||
                         sTypeOfField.IndexOf("char", StringComparison.CurrentCultureIgnoreCase) >= 0 ||
                          sTypeOfField.IndexOf("xml", StringComparison.CurrentCultureIgnoreCase) >= 0)
                        lTypeOfField.Add(sTypeOfField);
                }
                foreach (String sType in lTypeOfField)
                {
                    if (sWithTypeToAnalyze.Substring(0, Math.Min(sWithTypeToAnalyze.Length, sType.Length)).Equals(sType.Substring(0, Math.Min(sWithTypeToAnalyze.Length, sType.Length)), StringComparison.CurrentCultureIgnoreCase))
                        bRet = true;
                }
            }
            catch (Exception ex)
            {
                
                throw (ex);
            }
            return bRet;

        }
        public bool enableNotification(String sDatabase)
        {

            bool bRet = false;
            try
            {
                // DataSet ds1 = null;

                CStatement pStatement = null;
                if (eType == ConnType.eConnType.SQLSERVER)
                {
                    pStatement = new CStatementForSqlServer(oPool, SConnectString);

                    pStatement.PrepareText(String.Format("SELECT is_broker_enabled FROM sys.databases WHERE name = '{0}';", sDatabase));
                    Object oTest = pStatement.ExecuteAndReturnValue(typeof(int));
                    if (oTest != null && !(Boolean)oTest ) 
                    {
                        pStatement.PrepareText(String.Format("ALTER DATABASE {0} SET ENABLE_BROKER WITH ROLLBACK IMMEDIATE;", sDatabase));
                        pStatement.Execute();
                    }
                }
                else
                {
                    /*
                    pStatement =    new CStatementForMySql(oPool, SConnectString);
                    pStatement.PrepareText("SHOW DATABASES;");
                    */
                }

            }
            catch (Exception ex)
            {

                throw (ex);
            }
            return bRet;

        }
    }
}
