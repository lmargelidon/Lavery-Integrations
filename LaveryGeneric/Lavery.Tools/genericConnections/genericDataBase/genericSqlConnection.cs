using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using Lavery.Tools.Interfaces;
using System.Data;



namespace Lavery.Tools.Connections
{
    public class genericSqlConnection : genericDataBaseConnection
    {
        SqlConnection oConnection = null;
      

        public genericSqlConnection()
        { }
       public override  Object getConnection() 
        {
            try
            {
                if( oConnection.State == ConnectionState.Open)
                {
                    try
                    {
                        using (SqlCommand oCommand = oConnection.CreateCommand())
                        {
                            oCommand.CommandText = "SELECT 0";
                            oCommand.ExecuteScalar();
                        }
                    }
                    catch 
                    {
                        
                        oConnection.Close(); //  Declare the connection dead.}
                        try
                        {
                            oConnection.Open();
                        }
                        catch (Exception ex1)
                        {
                            throw (ex1);
                        }

                    }
                }
                else
                if (oConnection.State == ConnectionState.Broken ||
                    oConnection.State == ConnectionState.Closed
                    )
                    oConnection.Open();

                return oConnection;
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }
        public override  Boolean Open(String sWithConnectionString)
        {
            Boolean bRet = false;
            try
            {
                sConnectionString = sWithConnectionString;
                oConnection = new SqlConnection(sWithConnectionString);
                oConnection.Open();
                

            }
            catch (Exception ex)
            {
                throw (ex);
            
            }

            return bRet;
        }

        public override  Boolean Close()
        {
            Boolean bRet = false;
            try
            {
               
                oConnection.Close();
                bRet = true;
            }
            catch (Exception ex)
            {
                throw (ex);

            }

            return bRet;
        }
        public override  Boolean execute(String sWithStatementString, Object oWithSqlTransaction)
        {
            Boolean bRet = false;
            try
            {
                
                SqlCommand command = new SqlCommand(sWithStatementString, oConnection);
                if (oWithSqlTransaction != null)
                    command.Transaction = (SqlTransaction)oWithSqlTransaction;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                
                throw (ex);

            }

            return bRet;
        }
        public override  Object getInformations(String sWithStatementString, eReturnObjectType oWithReturnType = eReturnObjectType.None)
        {
            SqlDataReader oRet = default(SqlDataReader);
            try
            {
                SqlCommand command = new SqlCommand(sWithStatementString, oConnection);

                oRet = command.ExecuteReader();
                           

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw (ex);

            }

            return oRet;
        }
        public override Object getInformationsObjectType(String sWithStatementString)
        {
            SqlDataReader oRet = default(SqlDataReader);
            try
            {
                SqlCommand command = new SqlCommand(sWithStatementString, oConnection);

                oRet = command.ExecuteReader();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw (ex);

            }

            return oRet;
        }
    }
}
