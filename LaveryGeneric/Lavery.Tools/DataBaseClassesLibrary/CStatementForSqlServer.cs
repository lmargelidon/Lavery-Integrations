using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;
using System.Data.SqlClient;
using System.Diagnostics;

using System.Xml;
using System.Data.SqlTypes;
using Lavery.Tools.Interfaces;

namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CStatementForSqlServer : CStatement
    {
        SqlCommand mySqlCommand = null;
        
        public CStatementForSqlServer(String sWithSchema, String sWithName, String sWithAlias, CDBConnectionFactory pWithConnFactory)
            : base(pWithConnFactory, sWithSchema, sWithName)
        {               
        }
        public CStatementForSqlServer(CDBConnectionFactory pWithConnFactory)
            : base(pWithConnFactory)
        {
        }
        public CStatementForSqlServer(CDBConnectionFactory pWithConnFactory, String szWithConnString)
            :
             base(pWithConnFactory, szWithConnString)
        {

        }
        
        public override bool PrepareText(String sWithSql)
        {
            bool bRet = true;
            try
            {
                mySqlCommand = new SqlCommand();
                mySqlCommand.CommandText = sWithSql;
                mySqlCommand.CommandType = CommandType.Text;

            }
            catch (SqlException ex)
            {
               
                throw (ex);
            }
            return bRet;
        }
        public override bool PrepareStoreProc(String sWithSql)
        {
            bool bRet = true;
            try
            {
                mySqlCommand = new SqlCommand();
                mySqlCommand.CommandText = sWithSql;

                mySqlCommand.CommandType = CommandType.StoredProcedure;
                
            }
            catch (SqlException ex)
            {
               
                throw (ex);
            }
            return bRet;
        }

        public override bool bindParameter(String sParameter, XmlDocument xParameterValue)
        {
            bool bRet = true;
            try
            {
                SqlParameter idParam = new SqlParameter(sParameter, SqlDbType.Xml);
                mySqlCommand.Parameters.Add(idParam);
                mySqlCommand.Parameters[sParameter].Value = new SqlXml(new XmlTextReader(xParameterValue.InnerXml,
                                                                   XmlNodeType.Document, null));
                
            }
            catch (SqlException ex)
            {
              
                throw (ex);
            }
            return bRet;
        }
        public override bool bindParameter(String sParameter, String sParameterValue)
        {
            bool bRet = true;
            try
            {
                SqlParameter idParam = new SqlParameter(sParameter, SqlDbType.Char, sParameterValue.Length);

                mySqlCommand.Parameters.Add(idParam);
                mySqlCommand.Parameters[sParameter].Value = sParameterValue;

            }
            catch (SqlException ex)
            {
              
                throw (ex);
            }
            return bRet;
        }
        public override bool bindParameter(String sParameter, int iParameterValue)
        {
            bool bRet = true;
            try
            {
                SqlParameter idParam = new SqlParameter(sParameter, SqlDbType.Int);

                mySqlCommand.Parameters.Add(idParam);
                mySqlCommand.Parameters[sParameter].Value = iParameterValue;

            }
            catch (SqlException ex)
            {
             
                throw (ex);
            }
            return bRet;
        }
                
        public override bool Execute()
        {
            bool bRet = true;
            try
            {
                if (PTrans != null)
                {
                    mySqlCommand.Connection = ((CDBConnectionForSqlServer)PTrans.PConn).Conn;
                    mySqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if(szConnString != "")
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, szConnString, 1000)).Conn;
                    else
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, 1000)).Conn;

                mySqlCommand.Prepare();

                mySqlCommand.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
               
                throw (ex);
            }
            return bRet;
        }
        public override XmlDocument ExecuteStoreProcAndReturnXml()
        {
            XmlDocument xmlRet = new XmlDocument();
            try
            {
                if (PTrans != null)
                {
                    mySqlCommand.Connection = ((CDBConnectionForSqlServer)PTrans.PConn).Conn;
                    mySqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if (szConnString != "")
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, szConnString, 1000)).Conn;
                    else
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, 1000)).Conn;

                XmlReader xmlReader = mySqlCommand.ExecuteXmlReader();


                XmlElement root = xmlRet.CreateElement("root");
                xmlRet.AppendChild(root);

                XmlNode n;
                while ((n = xmlRet.ReadNode(xmlReader)) != null)
                    root.AppendChild(n);
            }
            catch (SqlException ex)
            {
               
                throw (ex);
            }
            return xmlRet;
        }
       
        public override DataTable ExecuteAndReturnResultSet()
        {
            DataTable dtRet = null;
            try
            {
                if (PTrans != null)
                {
                    mySqlCommand.Connection = ((CDBConnectionForSqlServer)PTrans.PConn).Conn;
                    mySqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if (szConnString != "")
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, szConnString, 1000)).Conn;
                    else
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, 1000)).Conn;

                mySqlCommand.Prepare();

                dtRet = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(mySqlCommand);
                adapter.Fill(dtRet);
                
            }
            catch (SqlException ex)
            {
              
                throw (ex);
            }
            return dtRet;
        }
        public override Object ExecuteAndReturnValue(Type tType)
        {
            Object oRet = null;
            try
            {
                if (PTrans != null)
                {
                    mySqlCommand.Connection = ((CDBConnectionForSqlServer)PTrans.PConn).Conn;
                    mySqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if (szConnString != "")
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, szConnString, 1000)).Conn;
                    else
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, 1000)).Conn;

                SqlParameter returnParameter = default(SqlParameter);
                if (tType == typeof(int))
                    returnParameter= mySqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
                if (tType == typeof(String))
                    returnParameter = mySqlCommand.Parameters.Add("@ReturnVal", SqlDbType.NVarChar);
                if (tType == typeof(Boolean))
                    returnParameter = mySqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Bit);
                if (tType == typeof(double))
                    returnParameter = mySqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Float);
                if (tType == typeof(DateTime))
                    returnParameter = mySqlCommand.Parameters.Add("@ReturnVal", SqlDbType.DateTime);
                
                
                returnParameter.Direction = ParameterDirection.ReturnValue;

                mySqlCommand.Prepare();
                mySqlCommand.ExecuteNonQuery();

                oRet = returnParameter.Value;
    
            }
            catch (SqlException ex)
            {
               
                throw (ex);
            }
            return oRet;
        }
        public override bool ExecuteDirect(String sWithSql)
        {
            bool bRet = true;
            try
            {
                bRet = ExecuteNonQuery(sWithSql);
            }
            catch (SqlException ex)
            {
                
                throw (ex);
            }
            return bRet;
        }

        private bool ExecuteNonQuery(String sWithSql)
        {
            bool bRet = true;
            try
            {
                mySqlCommand = new SqlCommand();
                if (PTrans != null)
                {
                    mySqlCommand.Connection = ((CDBConnectionForSqlServer)PTrans.PConn).Conn;
                    mySqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if (szConnString != "")
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, szConnString, 1000)).Conn;
                    else
                        mySqlCommand.Connection = ((CDBConnectionForSqlServer)pConnFactory.getConnection(ConnType.eConnType.SQLSERVER, 1000)).Conn;

                mySqlCommand.CommandText = sWithSql;
              
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
               
                throw (ex);
            }
            return bRet;
        }

                

    }
}


