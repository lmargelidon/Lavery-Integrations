using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;
using System.Diagnostics;
using System.Data.SqlClient;
using Lavery.Tools.Interfaces;


namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CDBConnectionForSqlServer : CDBConnection
    {
        private SqlConnection conn;
        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public CDBConnectionForSqlServer(string sWithconnString)
            : base(sWithconnString)
        {
            eType = ConnType.eConnType.SQLSERVER;
        }
        public CDBConnectionForSqlServer(bool bUsePropertyFile)
            : base(System.Configuration.ConfigurationManager.AppSettings.Get("ConnectionString"))
        {
            eType = ConnType.eConnType.SQLSERVER;
        }
        public CDBConnectionForSqlServer(string sWithconnString, eTypeOfConnection eWithToc)
            : base(sWithconnString, eWithToc)
        {
            eType = ConnType.eConnType.SQLSERVER;
        }
        public CDBConnectionForSqlServer(bool bUsePropertyFile, eTypeOfConnection eWithToc)
            : base(System.Configuration.ConfigurationManager.AppSettings.Get("ConnectionString"), eWithToc)
        {
            eType = ConnType.eConnType.SQLSERVER;
        }

        public override bool connect()
        {
            try
            {
                if (!isConnected())
                {
                    
                    conn = new SqlConnection(ConnString);
                    conn.Open();
                    base.connect();
                }
            }
            catch (SqlException ex)
            {
                
                throw (ex);
            }
            return isConnected();
        }
        public override bool disConnect()
        {
            try
            {
                if (isConnected())
                {
                    conn.Close();
                    base.disConnect();
                }
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            return isConnected();
        }

        
        public SqlTransaction beginTransaction()
        {
            SqlTransaction pTrans = null;
            try
            {
                if (isConnected())
                {
                    pTrans = conn.BeginTransaction();
                }
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            return pTrans;
        }
    }
}
