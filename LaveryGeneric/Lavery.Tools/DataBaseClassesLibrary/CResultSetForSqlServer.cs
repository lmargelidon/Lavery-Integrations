using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;
using System.Data.SqlClient;
using System.Diagnostics;
using Lavery.Tools.Interfaces;



namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CResultSetForSqlServer : CResultSet
    {

        private CDBConnectionFactory pConnFactory = null;
        private SqlParameter[] paramArray = null;
        private SqlCommand cmdSql = null;
        private CDBConnectionForSqlServer SqlConnection = null;
        private String TestIP = "172.145.27.134";
        public static String testIP2 = "10.45.112.128";
        public const String testIP3 = "10.45.112.129";


        public CResultSetForSqlServer(CDBConnectionFactory pWithConnFactory)
        {
            pConnFactory = pWithConnFactory;
            eType = ConnType.eConnType.SQLSERVER;
            if (TestIP.Equals("lkjlkjlkj"))
                Console.WriteLine(";lk;lk;k");
            if (testIP2.Equals("lkjlkjlkj"))
                Console.WriteLine(";lk;lk;k");
            if (testIP3.Equals("lkjlkjlkj"))
                Console.WriteLine(";lk;lk;k");



        }
        public CResultSetForSqlServer(CDBConnectionFactory pWithConnFactory, String sWithConnString)
        {
            pConnFactory = pWithConnFactory;
            eType = ConnType.eConnType.SQLSERVER;
            sConnString = sWithConnString;

        }

        public override DataSet executeSelect(string sfreeSql, string sFillWith)
        {   ds = new DataSet();
            SqlConnection = null;
            try
            {   if (pConnFactory != null)
                if (sConnString != "")
                    SqlConnection = (CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, sConnString, 500);
                else
                    SqlConnection = (CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, 500);
                else
                    throw (new Exception("no connection factory available"));
                if (SqlConnection == null)
                    throw (new Exception("no connection available"));
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
                cmdSql.Connection = SqlConnection.Conn;
                cmdSql.CommandText = sSQLStament;

                // Création du DataAdapter.
                // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect(string sfreeSql, string sFillWith) at SqlDataAdapter ");
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdSql;

                // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect(string sfreeSql, string sFillWith) at da.Fill(ds, sFillWith) ");
                // On rempli le DataSet et on ferme le DataAdapter.
                da.Fill(ds, sFillWith);
                /*
                for(int i = 0 ; i < ds.Tables.Count; i++)
                    for(int j = 0 ; i < ds.Tables[i].Columns.Count; i++)
                        dataColumnElement.Add(ds.Tables[i].Columns[j])
                */
                pConnFactory.releaseConnection(SqlConnection);
                SqlConnection = null;
                cmdSql = null;
                if (ds != null)
                    dr = ds.CreateDataReader();

            }
            catch (Exception ex)
            {   pConnFactory.releaseConnection(SqlConnection);
               
                cmdSql = null;
                throw (ex);
            }
            return ds;
        }
        public override DataSet executeSelect(string sFillWith)
        {
            ds = new DataSet();
            
            try
            {
                if (SqlConnection != null && cmdSql != null)
                {
                    // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect( string sFillWith) at SqlDataAdapter ");
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmdSql;

                    // CGenericObject.TraceInformation(this.GetType() + " public DataSet executeSelect( string sFillWith) at da.Fill(ds, sFillWith) ");
                    // On rempli le DataSet et on ferme le DataAdapter.
                    da.Fill(ds, sFillWith);
                    /*
                    for(int i = 0 ; i < ds.Tables.Count; i++)
                        for(int j = 0 ; i < ds.Tables[i].Columns.Count; i++)
                            dataColumnElement.Add(ds.Tables[i].Columns[j])
                    */
                    pConnFactory.releaseConnection(SqlConnection);
                    SqlConnection = null;
                    cmdSql = null;
                    
                    if (ds != null)
                        dr = ds.CreateDataReader();
                    
                }

            }
            catch (Exception ex)
            {
                pConnFactory.releaseConnection(SqlConnection);
                
                cmdSql = null;
                throw (ex);
            }
            return ds;
        }

        public override bool prepareStatement(string sfreeSql, int iParametersNumber)
        {
            bool bRet = false;
            SqlConnection = null;
            try
            {
                if (pConnFactory != null)
                    if (sConnString != "")
                        SqlConnection = (CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, sConnString, 500);
                    else
                        SqlConnection = (CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, 500);
                else
                    throw (new Exception("no connection factory available"));
                if (SqlConnection == null)
                    throw (new Exception("no connection available"));
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
                cmdSql.Connection = SqlConnection.Conn;
                cmdSql.CommandText = sSQLStament;

                cmdSql.Prepare();
                if (iParametersNumber > 0)
                    paramArray = new SqlParameter[iParametersNumber];
            }
            catch (Exception ex)
            {
                pConnFactory.releaseConnection(SqlConnection);
               
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
                    SqlParameter pParam = new SqlParameter(sParamName, SqlDbType.VarBinary, bVal.Length, ParameterDirection.Input, false,
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

