using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;
using System.Data.SqlClient;
using System.Diagnostics;

using System.Threading;
using Lavery.Tools.Interfaces;
using Lavery.Tools.Connections;

namespace Lavery.Tools.DBLibrary
{
    public class CTableForSqlServer : CTable
    {
        CResultSetForSqlServer pRS = null;
        String sSqlCommand = "";

        static public String sIp = ";lasdkfè;flkaè 172.145.12.10 ^dfèaf;kèf <145.15.12.123>àè;àè;à;";
        public String sIp1 = ";lasdkfè;flkaè 172.145.12.11 ^dfèaf;kèf <145.15.12.122>àè;àè;à;";


        public CTableForSqlServer(String sWithSchema, String sWithName, String sWithAlias, ConnectionPoolDatabases<IGenericConnection> pWithConnFactory)
            : base(pWithConnFactory, sWithSchema, sWithName)
        {   
            pRS = new CResultSetForSqlServer();
            sSqlCommand = "select * from " + (sWithSchema.Length > 0 ? sWithSchema + "." : "")  + sWithName;
            
        }
        public CTableForSqlServer(String sWithSchema, String sWithName, String sWithAlias, CDBDataBase  pWithDB)
            : base(pWithDB, sWithSchema, sWithName)
        {
            pRS = new CResultSetForSqlServer( pWithDB.SConnectString);
            sSqlCommand = "select * from " + (sWithSchema.Length > 0 ? sWithSchema + "." : "") + sWithName;

        }
        
        public bool addTable(String sWithSchema, String sWithName, String sWithAlias, String sWithWhereClause, eJoinType eWithType)
        {   bool bRet = false;

            return bRet;
        }

        public DataColumnCollection getColumns()
        {
            DataColumnCollection oRet = null;
            try
            {
                oRet = table.Columns;
            }
            catch (SqlException ex)
           {
                throw(ex);//(new string[] { "testTrace", this.GetType().ToString(), "getColumns()", Thread.CurrentThread.ManagedThreadId.ToString(), ex.Message.ToString() });
               
            }
            return oRet;

        }

        public override bool Reset(String sWithSqlCommand)
        {
            bool bRet = true;
            try
            {
               
                SqlCommand cmdSql = new SqlCommand();
                cmdSql.Connection = (SqlConnection)((IGenericConnection)pDb.OPool.getConnection(pDb.SConnectString)).getConnection();
                cmdSql.CommandText = sWithSqlCommand;


                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdSql;

                table = new DataTable(sName);
                da.FillSchema(table, SchemaType.Mapped);
                table.TableName = sName;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            return bRet;
        }

        public override bool Reset()
        {
            bool bRet = true;
            try
            {

                String sSql = "select * from " + sName;
                SqlCommand cmdSql = new SqlCommand();
                cmdSql.Connection = (SqlConnection)((IGenericConnection)pDb.OPool.getConnection(pDb.SConnectString)).getConnection();
                cmdSql.CommandText = sSql;


                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdSql;

                table = new DataTable(sName);
                da.FillSchema(table, SchemaType.Mapped);
                table.TableName = sName;
            }
            catch (SqlException ex)
           {
                throw(ex);//(new string[] { "testTrace", this.GetType().ToString(), "Reset()", Thread.CurrentThread.ManagedThreadId.ToString(), ex.Message.ToString() });
                
            }
            return bRet;
        }

        

        public override DataRow newRow()
        {
            DataRow oRet = null;
            try
            {
                oRet = table.NewRow();
            }
            catch (SqlException ex)
            {
                throw(ex);//(new string[] { "testTrace", this.GetType().ToString(), "NewRow()", Thread.CurrentThread.ManagedThreadId.ToString(), ex.Message.ToString() });
            }
            return oRet;
        }
        public override bool Insert(String sWithSql)
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
        public override bool Update(String sWithSql)
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
                SqlCommand mySqlCommand = new SqlCommand();
                if (PTrans != null)
                {
                    mySqlCommand.Connection = (SqlConnection)((IGenericConnection)PTrans.PConn).getConnection();
                    mySqlCommand.Transaction = ((CDBTransactionForSqlServer)PTrans).PTrans;
                }
               
                mySqlCommand.CommandText = sWithSql;
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            return bRet;
        }

        public override bool Drop()
        {
            bool bRet = true;
            try
            {
                IGenericConnection pConnection = null;
                if (pDb != null)
                    pConnection = (IGenericConnection)pConnFactory.getConnection(pDb.SConnectString);
                else
                    throw (new Exception("no connection factory available"));

                SqlCommand mySqlCommand = new SqlCommand();
                mySqlCommand.Connection = (SqlConnection)pConnection.getConnection();
                mySqlCommand.CommandText = "DROP TABLE " + sSchema + "." + sName + ";";
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            return bRet;
        }
        public override bool Create(String sWithSql, String sWithDataTableSpace, String sWithIndexTableSpace)
        {
            bool bRet = true;
            try
            {
                IGenericConnection pConnection = null;
                if (pDb != null)
                    pConnection = (IGenericConnection)pConnFactory.getConnection(pDb.SConnectString);
                else
                    throw (new Exception("no connection factory available"));

                SqlCommand mySqlCommand     = new SqlCommand();
                mySqlCommand.Connection = (SqlConnection)pConnection.getConnection();
                mySqlCommand.CommandText    = "CREATE TABLE " + sSchema + "." + sName + "(" + sWithSql + ")"
                    /*+ (sWithDataTableSpace.Length > 0 ? " IN " + sWithDataTableSpace : "")
                    + (sWithIndexTableSpace.Length > 0 ? " INDEX IN " + sWithIndexTableSpace : "" )
                     * */
                                            + ";";
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw(ex);//(new string[] { "testTrace", this.GetType().ToString(), "Create()", Thread.CurrentThread.ManagedThreadId.ToString(), ex.Message.ToString() });
            }
            return bRet;
        }
        public override bool CreateIndex(bool bWithUnique,
                                        String sWithIndexName,
                                        String sWithColumns)
        {
            bool bRet = true;
            try
            {
                IGenericConnection pConnection = null;
                if (pDb != null)
                    pConnection = (IGenericConnection)pConnFactory.getConnection(pDb.SConnectString);
                else
                    throw (new Exception("no connection factory available"));

                SqlCommand mySqlCommand = new SqlCommand();
                mySqlCommand.Connection = (SqlConnection)pConnection.getConnection();
                /*
                    CREATE [ UNIQUE ] INDEX index_name 
                    ON table ( column [ ASC | DESC ] [ ,...n ] ) 
                 */

                mySqlCommand.CommandText = "CREATE " + (bWithUnique ? "UNIQUE " : "") +
                                            "INDEX " + sWithIndexName + " " +
                                            "ON " + sName + " (" +
                                            sWithColumns + ");";
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw(ex);//(new string[] { "testTrace", this.GetType().ToString(), "CreateIndex()", Thread.CurrentThread.ManagedThreadId.ToString(), ex.Message.ToString() });
            }
            return bRet;
        }
        /*
         * ===========================================================================================
         * ===========================================================================================
         */
        public string BuildAllFieldsSQL()
        {
            string sql = "";
            foreach (DataColumn column in table.Columns)
            {
                if (sql.Length > 0)
                    sql += ", ";
                sql += column.ColumnName;
            }
            return sql;
        }

        public string BuildInsertSQL(DataRow oWithRow, bool bSetWithParameters)
        {
            StringBuilder sql = new StringBuilder ( "INSERT INTO " + table.TableName + " (" );
            StringBuilder values = new StringBuilder ( "VALUES (" );
            bool bFirst = true;
            bool bIdentity = false;
            string identityType = null;

            foreach ( DataColumn column in table.Columns )
            {
              if (column.AutoIncrement )
              {
                bIdentity = true;

                switch ( column.DataType.Name )
                {
                  case "Int16":
                    identityType = "smallint";
                    break;
                  case "SByte":
                    identityType = "tinyint";
                    break;
                  case "Int64":
                    identityType = "bigint";
                    break;
                  case "Decimal":
                    identityType = "decimal";
                    break;
                  default:
                    identityType = "int";
                  break;
                 }
              }
              else
              {
                  if (!(oWithRow[column.Ordinal] is DBNull))
                  {

                      if (bFirst)
                          bFirst = false;
                      else
                      {
                          sql.Append(", ");
                          values.Append(", ");
                      }

                      sql.Append(column.ColumnName);

                      if (bSetWithParameters)
                      {
                          values.Append("@");
                          values.Append(column.ColumnName);
                      }
                      else
                          values.Append("'" + oWithRow[column.ColumnName] + "'");
                  }
               }
            }
            sql.Append ( ") " );
            sql.Append ( values.ToString () );
            sql.Append ( ")" );

            if ( bIdentity )
            {
              sql.Append ( "; SELECT CAST(scope_identity() AS " );
              sql.Append ( identityType );
              sql.Append ( ")" );
            }

            return sql.ToString (); ;
        }




        public void InsertParameters ( SqlCommand command,
                                             string ParametersName,
                                             string sourceColumn,
                                             object value )
        {
            try
            {
                SqlParameter Parameters = new SqlParameter(ParametersName, value);

                Parameters.Direction = ParameterDirection.Input;
                Parameters.ParameterName = ParametersName;
                Parameters.SourceColumn = sourceColumn;
                Parameters.SourceVersion = DataRowVersion.Current;
                command.Parameters.Add(Parameters);
            }
            catch (Exception ex)
            {
                throw(ex);//(new string[] { "testTrace", this.GetType().ToString(), "InsertParameters()", Thread.CurrentThread.ManagedThreadId.ToString(), ex.Message.ToString() });
            }
        }

        
        public SqlCommand CreateInsertCommand ( DataRow oWithRow )
        {
            SqlCommand command = null;
            try
            {
                string sql = BuildInsertSQL(oWithRow, true);
                command = new SqlCommand(sql);
                command.CommandType = System.Data.CommandType.Text;

                foreach (DataColumn column in table.Columns)
                {
                    if (!(oWithRow[column.Ordinal] is DBNull )  )
                        //!column.AutoIncrement && !column.ColumnName.Equals("id", StringComparison.CurrentCultureIgnoreCase))
                    {
                        string ParametersName = "@" + column.ColumnName;
                        InsertParameters(command, ParametersName, column.ColumnName, oWithRow[column.ColumnName]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw(ex);//(new string[] { "testTrace", this.GetType().ToString(), "CreateInsertCommand()", Thread.CurrentThread.ManagedThreadId.ToString(), ex.Message.ToString() });
            }
          
          return command;
        }
      

        // Inserts the DataRow for the connection, returning the identity
        public object InsertRow (DataRow oWithRow)
        {   object oRet = null;
            try
            {
                IGenericConnection pConnection = null;
                if (pDb != null)
                    pConnection = (IGenericConnection)pConnFactory.getConnection(pDb.SConnectString);
                else
                    throw (new Exception("no connection factory available"));

                SqlCommand mySqlCommand = CreateInsertCommand(oWithRow);
                
                mySqlCommand.Connection = (SqlConnection)pConnection.getConnection();
                oRet = mySqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw(ex);//(new string[] { "testTrace", this.GetType().ToString(), "InsertRow()", Thread.CurrentThread.ManagedThreadId.ToString(), ex.Message.ToString() });
            }
            return oRet;
           
        }

  }


}

