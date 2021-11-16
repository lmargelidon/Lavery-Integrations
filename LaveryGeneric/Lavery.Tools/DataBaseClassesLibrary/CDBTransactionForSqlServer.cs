
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using ADODB;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CDBTransactionForSqlServer : CDBTransaction
    {
        SqlTransaction pTrans = null;

        public SqlTransaction PTrans
        {
            get { return pTrans; }
            set { pTrans = value; }
        }
        public CDBTransactionForSqlServer(CDBConnection pWithConn)
            : base(pWithConn)
        {
        }
        public override bool begin()
        {
            bool bRet = true;
            try
            {
                pTrans = ((CDBConnectionForSqlServer)PConn).beginTransaction();
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
            return bRet;
        }
        public override bool Commit()
        {
            bool bRet = true;
            try
            {
                pTrans.Commit();
            }   
            catch (Exception ex)
            {
             
                throw (ex);

            }
            return bRet;
        }
        public override bool RollBack()
        {
            bool bRet = true;
            try
            {
                pTrans.Rollback();
            }
            catch (Exception ex)
            {
              
                throw (ex);

            }
            return bRet;
        }

        
    }
}

