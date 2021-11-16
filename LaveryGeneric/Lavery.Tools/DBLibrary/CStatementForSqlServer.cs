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
using Lavery.Tools.Connections;

namespace Lavery.Tools.DBLibrary
{
    public class CStatementForSqlServer : CStatement
    {
        SqlCommand oSqlCommand = null;

        public CStatementForSqlServer(String sWithSchema, String sWithName, String sWithAlias, ConnectionPoolDatabases<IGenericConnection> pWithConnFactory)
            : base(pWithConnFactory, sWithSchema, sWithName)
        {               
        }
        public CStatementForSqlServer(ConnectionPoolDatabases<IGenericConnection> pWithConnFactory)
            : base(pWithConnFactory)
        {
        }
        public CStatementForSqlServer(ConnectionPoolDatabases<IGenericConnection> pWithConnFactory, String szWithConnString)
            :
             base(pWithConnFactory, szWithConnString)
        {

        }
        
        public override bool PrepareText(String sWithSql)
        {
            bool bRet = true;
            try
            {
                oSqlCommand = new SqlCommand();
                oSqlCommand.CommandText = sWithSql;
                oSqlCommand.CommandType = CommandType.Text;

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
                oSqlCommand = new SqlCommand();
                oSqlCommand.CommandText = sWithSql;

                oSqlCommand.CommandType = CommandType.StoredProcedure;
                
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
                oSqlCommand.Parameters.Add(idParam);
                oSqlCommand.Parameters[sParameter].Value = new SqlXml(new XmlTextReader(xParameterValue.InnerXml,
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

                oSqlCommand.Parameters.Add(idParam);
                oSqlCommand.Parameters[sParameter].Value = sParameterValue;

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

                oSqlCommand.Parameters.Add(idParam);
                oSqlCommand.Parameters[sParameter].Value = iParameterValue;

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
                    oSqlCommand.Connection = (SqlConnection)((IGenericConnection)PTrans.PConn).getConnection();
                    oSqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if(szConnString != "")
                        oSqlCommand.Connection = (SqlConnection)((IGenericConnection)pConnFactory.getConnection(szConnString)).getConnection();
                  
                oSqlCommand.Prepare();

                oSqlCommand.ExecuteNonQuery();


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
                    oSqlCommand.Connection = (SqlConnection)((IGenericConnection)PTrans.PConn).getConnection();
                    oSqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if (szConnString != "")
                        oSqlCommand.Connection = (SqlConnection)((IGenericConnection)pConnFactory.getConnection(szConnString)).getConnection();
                    else
                        throw (new Exception("no connection factory available"));

                if (oSqlCommand.Connection == null)
                    throw (new Exception("no connection available"));

                XmlReader xmlReader = oSqlCommand.ExecuteXmlReader();


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
                    oSqlCommand.Connection = (SqlConnection)((IGenericConnection)PTrans.PConn).getConnection();
                    oSqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if (szConnString != "")
                        oSqlCommand.Connection = (SqlConnection)((IGenericConnection)pConnFactory.getConnection(szConnString)).getConnection();
                    else
                        throw (new Exception("no connection factory available"));
                

                oSqlCommand.Prepare();

                dtRet = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(oSqlCommand);
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
                    oSqlCommand.Connection = (SqlConnection)((IGenericConnection)PTrans.PConn).getConnection();
                    oSqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if (szConnString != "")
                        oSqlCommand.Connection = (SqlConnection)((IGenericConnection)pConnFactory.getConnection(szConnString)).getConnection();
                    else
                        throw (new Exception("no connection factory available"));
                
                SqlParameter returnParameter = default(SqlParameter);
                if (tType == typeof(int))
                    returnParameter= oSqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Int);
                if (tType == typeof(String))
                    returnParameter = oSqlCommand.Parameters.Add("@ReturnVal", SqlDbType.NVarChar);
                if (tType == typeof(Boolean))
                    returnParameter = oSqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Bit);
                if (tType == typeof(double))
                    returnParameter = oSqlCommand.Parameters.Add("@ReturnVal", SqlDbType.Float);
                if (tType == typeof(DateTime))
                    returnParameter = oSqlCommand.Parameters.Add("@ReturnVal", SqlDbType.DateTime);
                
                
                returnParameter.Direction = ParameterDirection.ReturnValue;

                oSqlCommand.Prepare();
                oSqlCommand.ExecuteNonQuery();

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
                oSqlCommand = new SqlCommand();
                if (PTrans != null)
                {
                    oSqlCommand.Connection = (SqlConnection)((IGenericConnection)PTrans.PConn).getConnection();
                    oSqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
                else
                    if (szConnString != "")
                        oSqlCommand.Connection = (SqlConnection)((IGenericConnection)pConnFactory.getConnection(szConnString)).getConnection();
                    else
                        throw (new Exception("no connection factory available"));
                
                oSqlCommand.CommandText = sWithSql;
              
                oSqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
               
                throw (ex);
            }
            return bRet;
        }

                

    }
}


