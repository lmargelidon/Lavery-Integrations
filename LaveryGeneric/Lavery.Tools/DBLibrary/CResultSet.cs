using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
using Lavery.Tools.Interfaces;
using System.Configuration;

namespace Lavery.Tools.DBLibrary
{   public enum eJoinType { DEFAULT, LOJ, ROJ, INJ };
    public enum resultSetStatus { None, Executed, Error, DataFound, NoDataFound, moreDataExist  };

    public class CTableEntry
    {
        string      sName;
        string      sWhereClause;
        eJoinType   eType;

        public string SWhereClause
        {
          get { return sWhereClause; }
          set { sWhereClause = value; }
        }
    
        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }
        string sAlias;

        public string SAlias
        {
            get { return sAlias; }
            set { sAlias = value; }
        }
        string sSchema;

        public string SSchema
        {
            get { return sSchema; }
            set { sSchema = value; }
        }
        public CTableEntry(string sWithSchema, String sWithName, String sWithAlias)
            : this(sWithSchema, sWithName, sWithAlias, "", eJoinType.DEFAULT)
        {   
        }
        public CTableEntry(string sWithSchema, String sWithName, String sWithAlias, String sWithWhereClause)
            : this(sWithSchema, sWithName, sWithAlias, sWithWhereClause, eJoinType.DEFAULT)
        {   
        }
        
        public CTableEntry(string sWithSchema, String sWithName, String sWithAlias, String sWithWhereClause, eJoinType eWithType)
        {
            sName   = sWithName;
            sAlias  = sWithAlias;
            sSchema = sWithSchema;
            sWhereClause = sWithWhereClause;
            eType   = eWithType;
        }
        
    }
    public class CResultSet : CDBObject, IDisposable
    {

        const String sSqlProvider = "System.data.SqlClient";
        const String sOracleProvider = "System.Data.OracleClient";       
        
        
        private string sSelectClause;
        private string sWhereClause;
        private string sOrderByClause;
        private string sGroupByClause;
        private string sHavingClause;
        
        protected DataSet ds = null;
        
        protected DataTableReader dr = null;

        public  DataTableReader DataReader
        {
            get { return dr; }
          
        }


        public DataSet DataSetObject
        {
            get { return ds; }
            
        }
        protected String sConnString = "";

        protected String sCurrentDatasetName = "";

        
        private List<CTableEntry> elements = new List<CTableEntry>();
        // protected List<DataColumn> dataColumnElement = new List<DataColumn>();

        protected const int ConstNoMaxDSValue = -1;
        protected int iStartRowDataSet = 0;
        protected int iLastRowDataSet = 0;    // default value we don't know the size of the dataset except when fullfilled the dataset
        protected int iMaxDataSetRead = ConstNoMaxDSValue;
        protected Boolean bCursorPositionChanged = false;

        protected IGenericConnection iConnection = default(IGenericConnection);

        
        protected resultSetStatus eResultSetStatus = resultSetStatus.None;
        public resultSetStatus EResultSetStatus
        {
            get { return eResultSetStatus; }
        }
        
        private bool disposed = false;


        public CResultSet(int iWithMaxDataSetRead = ConstNoMaxDSValue)
        {
            iMaxDataSetRead = iWithMaxDataSetRead;
        }

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    releaseConnection();
                }
                
                disposed = true;
            }
        }
       

       // Utliser le destructeur C# pour finaliser le code
        ~CResultSet()
        {
            // Simply call Dispose(false).
            Dispose (false);
        }

        protected void releaseConnection()
        {
            try 
            {
                if (iConnection != default(IGenericConnection))
                    CDBDataBase.releaseConnection(iConnection);
                iConnection = default(IGenericConnection);
            }
            catch { }
        }
        
        
    
        public static CResultSet classBuilder( String sWithKeyConnectionString, int iWithMaxDataSetRead = ConstNoMaxDSValue)
        {
            CResultSet oRet = default(CResultSet);
            try 
            {
                ConnType.eConnType eTypeConn = default(ConnType.eConnType);
                ConnectionStringSettings settings = System.Configuration.ConfigurationManager.ConnectionStrings[sWithKeyConnectionString];
                if (settings != null)
                {
                    String sConnectString = settings.ConnectionString;
                    if (settings.ProviderName.Equals(sOracleProvider, StringComparison.CurrentCultureIgnoreCase))
                        eTypeConn = ConnType.eConnType.ORACLE;
                    if (settings.ProviderName.Equals(sSqlProvider, StringComparison.CurrentCultureIgnoreCase))
                        eTypeConn = ConnType.eConnType.SQLSERVER;

                    oRet = classBuilder(eTypeConn, sConnectString, iWithMaxDataSetRead);
                }
                

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return oRet;
        }
        public static CResultSet classBuilder(ConnType.eConnType eWithType, String sWithConnectionString, int iWithMaxDataSetRead = ConstNoMaxDSValue)
        {
            CResultSet oRet = default(CResultSet);
            try 
            { 
                switch(eWithType)
                {
                    /*
                    case  ConnType.eConnType.ORACLE:
                        oRet = new CResultSetForOracle(sWithConnectionString, iWithMaxDataSetRead);
                        break;
                    */
                    case ConnType.eConnType.SQLSERVER:
                        oRet = new CResultSetForSqlServer(sWithConnectionString, iWithMaxDataSetRead);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return oRet;
        }

        public virtual Boolean isOpened() { return iConnection != default(IGenericConnection); }
        public virtual Boolean isClosed() { return iConnection == default(IGenericConnection); }
        public virtual Boolean isDataFound()  {  return rowCount() > 0;}

        public virtual Boolean isMoreData() { return EResultSetStatus == resultSetStatus.moreDataExist; }
        public virtual Boolean Close()
        {
            Boolean bRet = false;
            try
            {
                releaseConnection();
            }
            catch { }
            return bRet;
        }
        public virtual Boolean rewindTop()
        {
            Boolean bRet = false;
            try
            {
                iStartRowDataSet = 0;
                bCursorPositionChanged = true;
                bRet = selectMoreData();
            }
            catch { }
            return bRet;
        }
        public virtual Boolean goTo(int iWithNewPosition) 
        {
            Boolean bRet = false;
            try
            {
                iStartRowDataSet = iWithNewPosition;
                bCursorPositionChanged = true;
                bRet = selectMoreData();
            }
            catch { }
            return bRet;
        }

        public virtual int rowCount() 
        { 
            int iRet = 0;
            try
            {
                iRet = ds.Tables[0].Rows.Count;
            }
            catch(Exception ex)
            {
                throw(ex);
            }
            return iRet; 
        }

        public virtual void executeSelect(string sfreeSql, string sFillWith)
        {  
        }
        public virtual void executeSelect(string sFillWith)
        {
        }
        public virtual bool prepareStatement(string sfreeSql, int iNumberOfParameters = 0)
        {
            return false;
        }

        public virtual Boolean selectMoreData()
        {
            return false;
        }
        public virtual void closeStatement()
        {
            try 
            { 
            }
            catch (Exception ex)
            { }

        }
        public virtual bool prepareStatementParameters(int iNumberOfParameters)
        {
            return false;
        }
        public virtual bool bindParameters(String sWithName, string sVal)
        {
            return false;
        }
        public virtual bool bindParameters(String sWithName, byte[] byteVal)
        {
            return false;
        }  


        public void SetClauses  (   string sWithSelectClause    , 
                                    string sWithWhereClause     ,
                                    string sWithOrderByClause   ,
                                    string sWithGroupByClause   ,
                                    string sWithHavingClause )
        {
            sSelectClause   = sWithSelectClause;
            sWhereClause    = sWithWhereClause;
            sOrderByClause  = sWithOrderByClause;
            sGroupByClause  = sWithGroupByClause;
            sHavingClause   = sWithHavingClause;
        }
        public bool addTable(String sWithSchema, String sWithName, String sWithAlias)
        {
            return addTable(sWithSchema, sWithName, sWithAlias, "", eJoinType.DEFAULT);
        }

        public bool addTable(String sWithSchema, String sWithName, String sWithAlias, String sWithWhereClause)
        {
            return addTable(sWithSchema, sWithName, sWithAlias, sWithWhereClause, eJoinType.DEFAULT);
        }

        public bool addTable(String sWithSchema, String sWithName, String sWithAlias, String sWithWhereClause, eJoinType eWithType )
        {
            bool bRet = false;
            try
            {  elements.Add(new CTableEntry(sWithSchema, sWithName, sWithAlias,sWithWhereClause, eWithType));
                bRet = true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
            }
            return bRet;
        }
        
        public string buildSqlClause()
        {   string sSQLStament = "";
            try
            {       sSQLStament = "SELECT " + sSelectClause +
                                  " FROM  " + buildFromClause();
                    if (sWhereClause.Length > 0)
                        sSQLStament += " WHERE " + sWhereClause;
                    if (sOrderByClause.Length > 0)
                        sSQLStament += " ORDER BY " + sOrderByClause;
                    if (sGroupByClause.Length > 0)
                        sSQLStament += " GROUP BY " + sGroupByClause;
                    if (sHavingClause.Length > 0)
                        sSQLStament += " HAVING " + sHavingClause;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return sSQLStament;
        }
        private string buildFromClause()
        {
            string sRet = "";
            try{
            foreach (CTableEntry element in elements)
            {
                if (sRet.Length > 0)
                    sRet += ",";
                sRet += (element.SSchema + element.SName + " AS " + element.SAlias);
            }
            }
            catch(Exception ex)
            {   throw(ex);
            }
            return sRet;
        }

        public DataColumn getColumn(String sWithTableAlias, String sWithColumnField)
        {
            DataColumn dtCol = null;
            try
            {
                dtCol = ds.Tables[sWithTableAlias].Columns[sWithColumnField];

            }
            catch
            {
                dtCol = null;
            }
            return dtCol;
        }

        public DataColumn getColumn(String sWithTableAlias, int iWithCol)
        {
            DataColumn dtCol = null;
            try
            {
                dtCol = ds.Tables[sWithTableAlias].Columns[iWithCol];

            }
            catch
            {
                dtCol = null;
            }
            return dtCol;
        }
        public DataColumn getColumn(int iWithAlias, int iWithCol)
        {
            DataColumn dtCol = null;
            try
            {
                dtCol = ds.Tables[iWithAlias].Columns[iWithCol];

            }
            catch
            {
                dtCol = null;
            }
            return dtCol;
        }
        public int getColumnNumber(String sWithAlias)
        {
            int iRet = 0;
            try
            {
                iRet = ds.Tables[sWithAlias].Columns.Count;

            }
            catch
            {
                iRet = 0;
            }
            return iRet;
        }
        public int getColumnNumber(int iWithAlias)
        {
            int iRet = 0;
            try
            {
                iRet = ds.Tables[iWithAlias].Columns.Count;

            }
            catch
            {
                iRet = 0;
            }
            return iRet;
        }
        public Boolean readResultSet(ref DataRow oWithReturnRow)
        {
            Boolean bRet = true;
            try
            {
                bRet = dr.Read();
                if (bRet)
                    eResultSetStatus = resultSetStatus.DataFound;
                else
                    eResultSetStatus = resultSetStatus.NoDataFound;
            }
            catch
            {
                eResultSetStatus = resultSetStatus.Error;
            }
            return bRet;
        }
        public bool readResultSet()
        {  bool bRet = true;
            try
            {
                bRet = dr.Read();
                if (bRet)
                    eResultSetStatus = resultSetStatus.DataFound;
                else
                    eResultSetStatus = resultSetStatus.NoDataFound;
            }
            catch
            {
                eResultSetStatus = resultSetStatus.Error;
            }
            return bRet;
        }
        public object getBooleanData(String sWithVal)
        {
            Boolean bRet = false;
            try
            {
                bRet =  dr[sWithVal].ToString().Equals("Y")?true:
                        Int16.Parse(dr[sWithVal].ToString()) == 1 ? true : false;
            }
            catch
            {
                bRet = false;
            }
            return bRet;
        }
        public object getObjectData(String sWithVal)
        {
            object oRet = null;
            try
            {
                oRet = dr[sWithVal];
            }
            catch
            {
                oRet = null;
            }
            return oRet;
        }
        public byte [] getBytesData(String sWithVal)
        {
            byte [] bRet = null;
            try
            {
                bRet = (byte[])dr[sWithVal];
            }
            catch
            {
                bRet = null;
            }
            return bRet;
        }
        public String getStringData(String sWithVal)
        {  String sRet = "";
            try
            {
                sRet = dr[sWithVal].ToString();
            }
            catch
            {
                sRet = "";
            }
            return sRet;
        }
        public DateTime getDateTimeData(String sWithVal)
        {
            DateTime dRet = DateTime.MinValue;
            try
            {
                String sVal = dr[sWithVal].ToString();
                dRet = DateTime.Parse(sVal);
            }
            catch
            {
                dRet = DateTime.MinValue;
            }
            return dRet;
        }
        public double getDoubleData(String sWithVal)
        {
            double dRet = 0;
            try
            {
                string sVal = dr[sWithVal].ToString();
                dRet = double.Parse(sVal);

            }
            catch
            {
                dRet = 0;
            }
            return dRet;
        }
        public float getFloatData(String sWithVal)
        {
            float fRet = 0;
            try
            {
                string sVal = dr[sWithVal].ToString();
                fRet = float.Parse(sVal);

            }
            catch
            {
                fRet = 0;
            }
            return fRet;
        }
        public Int64 getLongData(String sWithVal)
        {
            Int64 iRet = 0;
            try
            {
                string sVal = dr[sWithVal].ToString();
                iRet = Int64.Parse(sVal);

            }
            catch
            {
                iRet = 0;
            }
            return iRet;
        }
        public int getIntData(String sWithVal)
        {
            int iRet = 0;
            try
            {
                string sVal = dr[sWithVal].ToString();
                iRet = Int32.Parse(sVal);

            }
            catch
            {
                iRet = 0;
            }
            return iRet;
        }
        public Int16 getIntTinyData(String sWithVal)
        {
            Int16 iRet = 0;
            try
            {
                string sVal = dr[sWithVal].ToString();
                iRet = Int16.Parse(sVal);

            }
            catch
            {
                iRet = 0;
            }
            return iRet;
        }

        public XmlDocument getXmlResultSet()
        {
            XmlDocument xmlRet = new XmlDocument();
            try
            {
                
                XmlElement root = xmlRet.CreateElement("root");
                xmlRet.AppendChild(root);

                XmlDocument n = new XmlDocument();
                n.LoadXml(ds.GetXml());
                xmlRet.AppendChild(n);
          
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            return xmlRet;
        }

        public object getBooleanData(int iLequel)
        {
            Boolean bRet = false;
            try
            {
                bRet = dr[iLequel].ToString().Equals("Y") ? true :
                        Int16.Parse(dr[iLequel].ToString()) == 1 ? true : false;
            }
            catch
            {
                bRet = false;
            }
            return bRet;
        }
        public object getObjectData(int iLequel)
        {
            object oRet = null;
            try
            {
                oRet = dr[iLequel];
            }
            catch
            {
                oRet = null;
            }
            return oRet;
        }
        public byte[] getBytesData(int iLequel)
        {
            byte[] bRet = null;
            try
            {
                bRet = (byte[])dr[iLequel];
            }
            catch
            {
                bRet = null;
            }
            return bRet;
        }
        public String getStringData(int iLequel)
        {
            String sRet = "";
            try
            {
                sRet = dr[iLequel].ToString();
            }
            catch
            {
                sRet = "";
            }
            return sRet;
        }
        public DateTime getDateTimeData(int iLequel)
        {
            DateTime dRet = DateTime.MinValue;
            try
            {
                String sVal = dr[iLequel].ToString();
                dRet = DateTime.Parse(sVal);
            }
            catch
            {
                dRet = DateTime.MinValue;
            }
            return dRet;
        }        
        public double getDoubleData(int iLequel)
        {
            double dRet = 0;
            try
            {
                string sVal = dr[iLequel].ToString();
                dRet = double.Parse(sVal);

            }
            catch
            {
                dRet = 0;
            }
            return dRet;
        }
        public float getFloatData(int iLequel)
        {
            float fRet = 0;
            try
            {
                string sVal = dr[iLequel].ToString();
                fRet = float.Parse(sVal);

            }
            catch
            {
                fRet = 0;
            }
            return fRet;
        }
        public Int64 getLongData(int iLequel)
        {
            Int64 iRet = 0;
            try
            {
                string sVal = dr[iLequel].ToString();
                iRet = Int64.Parse(sVal);

            }
            catch
            {
                iRet = 0;
            }
            return iRet;
        }
        public int getIntData(int iLequel)
        {
            int iRet = 0;
            try
            {
                string sVal = dr[iLequel].ToString();
                iRet = Int32.Parse(sVal);

            }
            catch
            {
                iRet = 0;
            }
            return iRet;
        }
        public Int16 getIntTinyData(int iLequel)
        {
            Int16 iRet = 0;
            try
            {
                string sVal = dr[iLequel].ToString();
                iRet = Int16.Parse(sVal);

            }
            catch
            {
                iRet = 0;
            }
            return iRet;
        }
    }
    
}
