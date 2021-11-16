using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;
using System.Data.SqlClient;
using System.Diagnostics;
using Lavery.Tools.Interfaces;
using Lavery.Tools.Connections;



namespace Lavery.Tools.DBLibrary
{
    public class CResultSetForSqlServer :  CResultSet
    {

       
        private SqlParameter[] paramArray = null;
        private SqlCommand cmdSql = null;        
       
        private SqlDataAdapter da = null;

        public CResultSetForSqlServer(int iWithMaxDataSetRead = ConstNoMaxDSValue)
            : base(iWithMaxDataSetRead)
        {
           
            eType = ConnType.eConnType.SQLSERVER;
        }
        public CResultSetForSqlServer(String sWithConnString, int iWithMaxDataSetRead = ConstNoMaxDSValue)
            : base(iWithMaxDataSetRead)
        {
            
            eType = ConnType.eConnType.SQLSERVER;
            sConnString = sWithConnString;

        }
        
        Boolean fillDataReaderFromAdapter()        
        {
            Boolean bRet = false;
            try 
            {
                if (bCursorPositionChanged)
                {
                    bCursorPositionChanged = false;
                    ds = new DataSet();
                    if (iMaxDataSetRead != ConstNoMaxDSValue)
                    {
                        da.Fill(ds, iStartRowDataSet, iMaxDataSetRead, sCurrentDatasetName);
                        int iRead = rowCount();
                        if (iRead == iMaxDataSetRead)
                            eResultSetStatus = resultSetStatus.moreDataExist;
                        else
                            eResultSetStatus = iRead == 0 ? resultSetStatus.NoDataFound : resultSetStatus.DataFound;
                        iStartRowDataSet += rowCount();
                        bCursorPositionChanged = true;

                    }
                    else
                    {
                        
                        if (iLastRowDataSet != 0 && iLastRowDataSet - iStartRowDataSet >= 0)
                        {
                            da.Fill(ds, iStartRowDataSet, iLastRowDataSet - iStartRowDataSet, sCurrentDatasetName);
                        }
                        else
                        {
                            da.Fill(ds, sCurrentDatasetName);
                            iLastRowDataSet = rowCount();
                        }
                    }


                    if (ds != null)
                        dr = ds.CreateDataReader();

                    if (rowCount() > 0)
                        bRet = true;
                }

                
            }
            catch (Exception ex)
            { }
            return bRet;
        }

        public override void executeSelect(string sfreeSql, string sFillWith)
        {

            try
            {
                sCurrentDatasetName = sFillWith;
                if (iConnection != default(IGenericConnection))
                    CDBDataBase.releaseConnection(iConnection);
                iConnection = CDBDataBase.getConnection(sConnString);

                string sSQLStament;

                if (sfreeSql.Length > 0)
                    sSQLStament = sfreeSql;
                else
                    sSQLStament = buildSqlClause();
                /*
                string connString = "Server=VDRN;Database=TCMRDW;UID=lamarg1;PWD=dorianlola";
                SqlConnection conn = new SqlConnection(connString);
                */
                // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect(string sfreeSql, string sFillWith) at SqlCommand ");

                
                
                cmdSql = new SqlCommand();
                cmdSql.Connection = (SqlConnection)iConnection.getConnection();
                cmdSql.CommandText = sSQLStament;

                // Création du DataAdapter.
                // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect(string sfreeSql, string sFillWith) at SqlDataAdapter ");

                
                da = new SqlDataAdapter();
                da.SelectCommand = cmdSql;
                
                // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect(string sfreeSql, string sFillWith) at da.Fill(ds, sFillWith) ");
                // On rempli le DataSet et on ferme le DataAdapter.
                bCursorPositionChanged = true;
                fillDataReaderFromAdapter();

            }
            catch (Exception ex)
            {


                throw (ex);
            }
            finally
            {
                cmdSql = null;
                releaseConnection();
            }
        }
        public override Boolean selectMoreData()
        {
            Boolean bRet = false;
                  
            try
            {
                bRet = fillDataReaderFromAdapter(); 
            }
            catch (Exception ex)
            {   
               
            }
            
            return bRet;
        }
        public override void executeSelect(string sFillWith)
        {
           

            try
            {
                ds = new DataSet();
                sCurrentDatasetName = sFillWith;
                if (iConnection != null && cmdSql != null)
                {


                    // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect( string sFillWith) at SqlDataAdapter ");
                    da = new SqlDataAdapter();
                    da.SelectCommand = cmdSql;

                    // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect( string sFillWith) at da.Fill(ds, sFillWith) ");
                    // On rempli le DataSet et on ferme le DataAdapter.
                    bCursorPositionChanged = true;
                    fillDataReaderFromAdapter(); 

                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                cmdSql = null;
                releaseConnection();
            }
           
        }

        public override bool prepareStatement(string sfreeSql, int iParametersNumber = 0)
        {
            bool bRet = false;
            
            try
            {
                iConnection = CDBDataBase.getConnection(sConnString);
                
                string sSQLStament;


                if (sfreeSql.Length > 0)
                    sSQLStament = sfreeSql;
                else
                    sSQLStament = buildSqlClause();
                /*
                string connString = "Server=VDRN;Database=TCMRDW;UID=lamarg1;PWD=dorianlola";
                SqlConnection conn = new SqlConnection(connString);
                */
                // CGenericObject.TraceInformation(this.GetType() + " public DataSet prepareStatement(string sfreeSql) at SqlCommand ");
                cmdSql = new SqlCommand();
                cmdSql.Connection = (SqlConnection)iConnection.getConnection();
                cmdSql.CommandText = sSQLStament;

                cmdSql.Prepare();
                if (iParametersNumber > 0)
                    paramArray = new SqlParameter[iParametersNumber];
            }
            catch (Exception ex)
            {

                releaseConnection();
                cmdSql = null;
                throw (ex);
            }
            
            return bRet;
        }
        public override bool prepareStatementParameters( int iParametersNumber)
        {
            bool bRet = false;

            try
            {
                if (iParametersNumber > 0)
                    paramArray = new SqlParameter[iParametersNumber];
            }
            catch (Exception ex)
            {
                iConnection = null;
                CDBDataBase.releaseConnection(iConnection);
                cmdSql = null;
                throw (ex);
            }

            return bRet;
        }
        public override bool bindParameters(String sParamName, string sVal)
        {
            bool bRet = false;
            try {
                if (paramArray != null && cmdSql != null)
                {
                    SqlParameter pParam = new SqlParameter(sParamName, SqlDbType.Char);

                    pParam.Value = sVal;
                    cmdSql.Parameters.Add(pParam);

                }
            }
            catch 
            {
                bRet = false;
            }
            return bRet;
        }
        public override bool bindParameters(String sParamName, byte [] bVal)
        {
            bool bRet = false;
            try
            {
                if (paramArray != null && cmdSql != null)
                {
                    SqlParameter pParam = new SqlParameter(sParamName, SqlDbType.Binary, bVal.Length, ParameterDirection.Input, false,
                                            0, 0, null, DataRowVersion.Current, bVal);
                   
                    cmdSql.Parameters.Add(pParam);

                }
            }
            catch 
            {
                bRet = false;
            }
            return bRet;
        }
    } 
}

