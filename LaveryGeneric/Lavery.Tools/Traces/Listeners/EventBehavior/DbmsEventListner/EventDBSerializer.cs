using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lavery.Tools.ConnectionPool;
using Lavery.Tools.Interfaces;
using Lavery.Tools.Connections;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using Lavery.Tools.Runtime;




namespace Lavery.Events.Listeners
{
    public class EventDBSerializer : EventSerializerBase
    {
        ConnectionPool<IGenericConnection, genericSqlConnection> oPool = new ConnectionPool<IGenericConnection, genericSqlConnection>();
        String sConnectString = "";

        public EventDBSerializer(String sWithAppSetingEntry)
        {
            try 
            {
                //TracePending.Trace(String.Format("EventDBSerializer connection string: ", sWithAppSetingEntry));
                sConnectString = OConnectionFactory.ConnectionString(sWithAppSetingEntry);               
                
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
        
        }
        public override  int getKey(String sWithTableSchema, String sWithTableName, String sWithWhereClause)
        {
            int iRet = 0;
            try
            {

                IGenericConnection oGenericConnection = oPool.getConnection(sConnectString);
                String sStatementString = "";
                try
                {

                    SqlConnection oConn = (SqlConnection)oGenericConnection.getConnection();

                    sStatementString = String.Format("select TOP 1 [id] from [{0}].[{1}] WITH (NOLOCK)  where {2}", sWithTableSchema, sWithTableName, sWithWhereClause);
                    try 
                    {
                        SqlDataReader reader = (SqlDataReader)oGenericConnection.getInformations(sStatementString, eReturnObjectType.None);
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                iRet =  reader.GetInt32(0);
                            }
                        }
                        
                        reader.Close();
                    
                    }
                    catch (Exception ex)
                    {
                        
                        throw (ex);
                    }
                                                    
                       

                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                finally
                {
                    oPool.releaseGenericConnection(oGenericConnection);

                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
            return iRet;
        }
        Dictionary<String, String> buildDataToBeSerialized(String sWithSchema, String sWithRessource, EventEntryBase oEntryBase)
        {
            Dictionary<String, String> lWithDataToBeserialized = new Dictionary<string, string>();

            try
            {
                foreach (var oObject in oEntryBase.ODicoTobeSerialized)
                    if (oObject.Value.bLookUp)
                        oObject.Value.oTargetValue = getKey(oObject.Value.sFkSchema, oObject.Value.sFkEntity, oObject.Value.sFkFilter);


                
                String sLogOutput = "";
                foreach (var oObject in oEntryBase.ODicoTobeSerialized)
                {
                    String sFormat = "{0}";
                    if (oObject.Value.tBdType == typeof(String) || oObject.Value.tBdType == typeof(DateTime))
                        sFormat = "'{0}'";


                    if (oObject.Value.bLookUp)
                    {
                        lWithDataToBeserialized.Add(oObject.Key, String.Format(sFormat, oObject.Value.oTargetValue.ToString()));
                        sLogOutput += ((sLogOutput.Length > 0 ? "\n" : "") + oObject.Key + " = " + String.Format(sFormat, oObject.Value.oTargetValue.ToString()));
                    }
                    else
                    {
                        String sValueTobeSerialized = String.Format(sFormat, oObject.Value.oOriginalValue);
                        if (oObject.Value.tBdType == typeof(String))
                        {
                            String sVal = (String) oObject.Value.oOriginalValue;
                            sVal = sVal.Replace("'","''");
                            sVal = sVal.Replace("''''","''");
                            sValueTobeSerialized = String.Format(sFormat, sVal);
                        }

                        if (oObject.Value.tBdType == typeof(Boolean))
                            sValueTobeSerialized = String.Format(sFormat, (Boolean)oObject.Value.oOriginalValue ? 1 : 0);
                        lWithDataToBeserialized.Add(oObject.Key, sValueTobeSerialized);
                        sLogOutput += ((sLogOutput.Length > 0 ? "\n" : "") + oObject.Key + " = " + sValueTobeSerialized);
                    }
                }

                                
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
            return lWithDataToBeserialized;
        }
        public override Boolean recordEvent(String sWithSchema, String sWithTable, EventEntryBase oEntryBase)
        {
            Boolean bRet = true;
            try
            {
                //TracePending.Trace("dans recordEvent");
                Dictionary<String, String> lListData = null;
                try
                {
                    lListData = buildDataToBeSerialized(sWithSchema, sWithTable, oEntryBase);
                }
                catch (Exception ex)
                {
                    TracePending.Trace(ex.Message);
                    throw (ex);
                }

                IGenericConnection oGenericConnection = oPool.getConnection(sConnectString);
                try
                {
                    //TracePending.Trace("recordEvent Start...");

                    SqlConnection oConn = (SqlConnection)oGenericConnection.getConnection();

                    String sStatementString = "";
                    String sFields = "";
                    String sValues = "";
                    foreach (var pair in lListData)
                    {
                        sFields += ((sFields.Length > 0 ? "," : "") + String.Format("[{0}]",pair.Key));
                        sValues += ((sValues.Length > 0 ? "," : "") + pair.Value);
                    }
                    sStatementString = String.Format("INSERT INTO [{0}].[{1}] ({2}) VALUES ({3})", sWithSchema, sWithTable, sFields, sValues);
                    // TracePending.Trace("recordEvent Start: " + sStatementString);
                    try
                    {
                        
                        oGenericConnection.execute(sStatementString, null);
                        //TracePending.Trace("recordEvent Executed Successfully...");
                    }
                    catch (Exception ex)
                    {
                        TracePending.Trace(ex.Message);   
                        throw (ex);
                    }



                }
                catch (Exception ex)
                {
                    TracePending.Trace(ex.Message);
                                        
                    throw (ex);
                }
                finally
                {
                    oPool.releaseGenericConnection(oGenericConnection);

                }
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
            return bRet;
        }
    }
}
