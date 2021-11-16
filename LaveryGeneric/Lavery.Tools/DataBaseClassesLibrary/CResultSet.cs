using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Lavery.Tools.DataBaseClassLibrary
{   public enum eJoinType { DEFAULT, LOJ, ROJ, INJ };
        

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
    public class CResultSet : CDBObject
    {   private string sSelectClause;
        private string sWhereClause;
        private string sOrderByClause;
        private string sGroupByClause;
        private string sHavingClause;
        protected DataSet ds = null;
        protected DataTableReader dr = null;
        protected String sConnString = "";    

        private List<CTableEntry> elements = new List<CTableEntry>();
        // protected List<DataColumn> dataColumnElement = new List<DataColumn>();
        

        public CResultSet()
        { 
        }
        public virtual DataSet executeSelect(string sfreeSql, string sFillWith)
        {  
            return ds;
        }
        public virtual DataSet executeSelect(string sFillWith)
        {
            return ds;
        }
        public virtual bool prepareStatement(string sfreeSql, int iNumberOfParameters)
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
        public bool readResultSet()
        {  bool bRet = true;
            try
            {
                bRet = dr.Read();
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
        
    }
    
}
