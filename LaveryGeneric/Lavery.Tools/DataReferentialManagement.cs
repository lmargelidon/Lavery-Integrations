using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;


namespace Lavery.Tools
{
    public enum ListenerType {None, TimeCard, TimeCardPending, ServiceBus, ErsNet, Wcf }

    public class DataReferentialManagement : Object, IDisposable
    {
        SqlConnection oConnectionReferential;
        private readonly object ReintranceLock = new object();
        private int  iEnvironment = default(int);
        private ListenerType eListenerType;

        Boolean disposing;
        Boolean disposed;

        public int IEnvironment { get => iEnvironment; set => iEnvironment = value; }
        public ListenerType EListenerType { get => eListenerType; set => eListenerType = value; }

        public DataReferentialManagement(SqlConnection oConnectionReferential)
        {
            eListenerType = ListenerType.None;
            this.oConnectionReferential = oConnectionReferential;

        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {

                }

                disposed = true;
            }
        }
        ~DataReferentialManagement()
        {
            Dispose(disposing: false);
        }
        /*
         * ********************************************************************************************
         * Set of Api in order to synchronize key as Guid for E3 tables Notification --- TimeCard ----
         * * ********************************************************************************************
         */
        
        public Boolean registerRequestProcessed(Boolean bSensInbound, Guid sGuidE3, SqlConnection oTrxConnectionReferential = null)
        {
            Boolean bRet = false;
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("insert into dbo.CollisionTracker ([SensInbound], [Stream], [GuidE3]) values(@SensInbound,@ListenerName, @GuidE3)",
                                    oTrxConnectionReferential != null ? oTrxConnectionReferential: oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@SensInbound", SqlDbType.Bit).Value = bSensInbound ? 1 : 0;
                        cmd1.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd1.Parameters.Add("@GuidE3", SqlDbType.NVarChar).Value = sGuidE3.ToString();
                        int rowsAdded = cmd1.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
        }
        public int getEnvironment(String sEnv)
        {
            
            try
            {
                lock (ReintranceLock)
                {
                    if (iEnvironment == default(int))
                    {
                        using (var cmd = new SqlCommand("SELECT id FROM dbo.Environment WHERE Code=@Code", oConnectionReferential))
                        {
                            cmd.Parameters.Add("@Code", SqlDbType.NVarChar).Value = sEnv;
                            object result = cmd.ExecuteScalar();
                            if (result != null && result.GetType() != typeof(DBNull))
                                iEnvironment = (int)result;

                        }
                        if (iEnvironment == default(int))
                            using (var cmd1 = new SqlCommand("insert into dbo.Environment ([Code], [Designation]) values(@Code,@Designation)", oConnectionReferential))
                            {
                                cmd1.Parameters.Add("@Code", SqlDbType.NVarChar).Value = sEnv;
                                cmd1.Parameters.Add("@Designation", SqlDbType.NVarChar).Value = String.Format("Environment {0}", sEnv);
                                iEnvironment = cmd1.ExecuteNonQuery();

                            }
                    }
            

                }
            }
            catch (Exception ex)
            { }
            return iEnvironment;
        }
        public Boolean canProcessRequest(Boolean bSensInbound, Guid sGuidE3)
        {
            Boolean bRet = false;
            try
            {
                int iFound = default(int);
                lock (ReintranceLock)
                {
                    using (var cmd = new SqlCommand("SELECT id FROM dbo.CollisionTracker WHERE SensInbound=@SensInbound AND Stream=@ListenerName AND GuidE3 = @GuidE3", oConnectionReferential))
                    {
                        cmd.Parameters.Add("@SensInbound", SqlDbType.Bit).Value = bSensInbound;
                        cmd.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd.Parameters.Add("@GuidE3", SqlDbType.NVarChar).Value = sGuidE3.ToString();

                        object result = cmd.ExecuteScalar();
                        if (result == null || result.GetType() == typeof(DBNull))
                            bRet = true;


                    }
                }
            }
            catch (Exception ex)
            { }
            return bRet;
        }
        public DateTime getLastRegisteredDate()
        {
            DateTime oRet = DateTime.MaxValue;
            try
            {
                int iFound = default(int);
                lock (ReintranceLock)
                {
                    using (var cmd = new SqlCommand("SELECT max(TimeStamp) FROM dbo.AssiduityMasterDataLink WHERE  [trxSource]=@ListenerName and fk_environment = @fk_environment", oConnectionReferential))
                    {
                        cmd.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd.Parameters.Add("@fk_environment", SqlDbType.Int).Value = iEnvironment;
                        Object result = cmd.ExecuteScalar();
                        if (result != null &&  result.GetType() == typeof(DBNull))
                            oRet = new DateTime(2021, 11, 1);
                        else
                            oRet = (DateTime)result;
                    }
                }
            }
            catch (Exception ex)
            { }
            return oRet;
        }
        public IEnumerable<Dictionary<string, object>> Serialize(SqlDataReader reader)
        {
            var results = new List<Dictionary<string, object>>();
            var cols = new List<string>();
            for (var i = 0; i < reader.FieldCount; i++)
                cols.Add(reader.GetName(i));

            while (reader.Read())
                results.Add(SerializeRow(cols, reader));

            return results;
        }
        private Dictionary<string, object> SerializeRow(IEnumerable<string> cols,
                                                        SqlDataReader reader)
        {
            var result = new Dictionary<string, object>();
            foreach (var col in cols)
                result.Add(col, reader[col]);
            return result;
        }
        private String sqlDatoToJson(SqlDataReader dataReader)
        {
            var dataTable = new DataTable();
            dataTable.Load(dataReader);
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(dataTable);
            return JSONString;
        }
        public String getAllEntries(DateTime dtFrom, SqlConnection oConnectionSource)
        {
            String sRet = default(String);
            try
            {
                int iFound = default(int);
                lock (ReintranceLock)
                {
                    //using (var cmd = new SqlCommand(String.Format("SELECT * FROM [dbo].[{0}] WHERE TimeStamp > @TimeStamp FOR JSON PATH, Root('TimeCards')", sListenerName), oConnectionSource))
                    using (var cmd = new SqlCommand(String.Format("SELECT * FROM [dbo].[{0}] WHERE TimeStamp > @TimeStamp and TimeKeeper != ''", eListenerType.ToString()), oConnectionSource))
                    {                     
                        cmd.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = dtFrom.AddMinutes(1);
                        //sRet = (String)cmd.ExecuteScalar();                       
                        string json;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            var r = Serialize(reader);
                            json = JsonConvert.SerializeObject(r, Formatting.Indented);
                        }
                        //json = json.Substring(1).Substring(0,json.Length - 1);
                        sRet = String.Format("{{TimeCards :{0}}}", json);
                    }
                    
                }                
            }
            catch (Exception ex)
            { }
            return sRet;
        }
        public int registerLink(Guid idSource, DateTime tsValue, int idTarget, Guid oGuid,  String sDetail, Boolean isDeleted = false, SqlConnection oTrxConnectionReferential = null)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    if(getLinkCorrelationId(idSource, oTrxConnectionReferential) == default(Guid))
                        using (var cmd1 = new SqlCommand("insert into dbo.AssiduityMasterDataLink ([refCorrelation], [idSource], [idTarget], [trxSource], [is_deleted], [TimeStamp], [fk_environment]) values(@refCorrelation, @idSource,@idTarget,@trxSource, @is_deleted, @TimeStamp, @fk_environment)",
                                            oTrxConnectionReferential == null ? oConnectionReferential: oTrxConnectionReferential))
                        {
                            cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                            cmd1.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = tsValue;
                            cmd1.Parameters.Add("@trxSource", SqlDbType.NVarChar).Value = eListenerType.ToString();
                            cmd1.Parameters.Add("@idTarget", SqlDbType.Int).Value = idTarget;
                            cmd1.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = 0;
                            cmd1.Parameters.Add("@refCorrelation", SqlDbType.UniqueIdentifier).Value = oGuid;
                            cmd1.Parameters.Add("@fk_environment", SqlDbType.Int).Value = iEnvironment;                          


                           iRet = cmd1.ExecuteNonQuery();
                        }
                    else
                        using (var cmd1 = new SqlCommand("update dbo.AssiduityMasterDataLink set [TimeStamp] =  @TimeStamp, [is_deleted] = @is_deleted  where [idSource] = @idSource and fk_environment = @fk_environment and trxSource = @trxSource",
                                            oTrxConnectionReferential == null ? oConnectionReferential : oTrxConnectionReferential))
                        {
                            cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                            cmd1.Parameters.Add("@trxSource", SqlDbType.NVarChar).Value = eListenerType.ToString();
                            cmd1.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = tsValue;
                            cmd1.Parameters.Add("@fk_environment", SqlDbType.Int).Value = iEnvironment;
                            cmd1.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = isDeleted;

                            iRet = cmd1.ExecuteNonQuery();
                            
                        }

                    if (sDetail != default(String))
                    {
                        int  iPKMaster = getLinkPrimaryKeyValue(idSource, oTrxConnectionReferential);
                        using (var cmd1 = new SqlCommand("insert into dbo.AssiduityDetailDataLink ([idMaster], [detailTrx]) values(@idMaster, @detailTrx )",
                                            oTrxConnectionReferential == null ? oConnectionReferential : oTrxConnectionReferential))
                        {
                            cmd1.Parameters.Add("@idMaster", SqlDbType.Int).Value = iPKMaster;
                            cmd1.Parameters.Add("@detailTrx", SqlDbType.NVarChar).Value = sDetail;
                            cmd1.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return iRet;
        }
        
        public int getLinkAssiduityId(Guid idSource, SqlConnection oTrxConnectionReferential = null)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("select [idTarget] from dbo.AssiduityMasterDataLink where [idSource] = @idSource and fk_environment = @fk_environment and trxSource = @trxSource",
                                                        oTrxConnectionReferential != null ? oTrxConnectionReferential : oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                        cmd1.Parameters.Add("@trxSource", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd1.Parameters.Add("@fk_environment", SqlDbType.Int).Value = iEnvironment;
                        object result = cmd1.ExecuteScalar();                        
                        if (result != null && result.GetType() != typeof(DBNull))
                            iRet = (int)result;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return iRet;
        }
        public Guid getLinkCorrelationId(Guid idSource, SqlConnection oTrxConnectionReferential = null)
        {
            Guid iRet = default(Guid);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("select [refCorrelation] from dbo.AssiduityMasterDataLink where [idSource] = @idSource and fk_environment = @fk_environment and trxSource = @trxSource",
                                    oTrxConnectionReferential != null? oTrxConnectionReferential: oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                        cmd1.Parameters.Add("@trxSource", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd1.Parameters.Add("@fk_environment", SqlDbType.Int).Value = iEnvironment;
                        object result = cmd1.ExecuteScalar();
                        if (result != null && result.GetType() != typeof(DBNull))
                            iRet = (Guid)result;
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return iRet;
        }
        public int getLinkPrimaryKeyValue(Guid idSource, SqlConnection oTrxConnectionReferential = null)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("select [id] from dbo.AssiduityMasterDataLink where [idSource] = @idSource and fk_environment = @fk_environment and trxSource = @trxSource",
                                        oTrxConnectionReferential != null ? oTrxConnectionReferential : oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                        cmd1.Parameters.Add("@trxSource", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd1.Parameters.Add("@fk_environment", SqlDbType.Int).Value = iEnvironment;                        
                        object result = cmd1.ExecuteScalar();
                        if (result != null && result.GetType() != typeof(DBNull))
                            iRet = (int)result;
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return iRet;
        }
        public int deleteLink(Guid idSource, SqlConnection oConnectionReferentialTrx = null)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("Update dbo.AssiduityMasterDataLink set is_deleted = 1 where [idSource] = @idSource and fk_environment = @fk_environment and trxSource = @trxSource",
                                                    oConnectionReferentialTrx != null ? oConnectionReferentialTrx : oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                        cmd1.Parameters.Add("@trxSource", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd1.Parameters.Add("@fk_environment", SqlDbType.Int).Value = iEnvironment;
                        int result = cmd1.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            { }
            return iRet;
        }
        /*
         * ********************************************************************************************
         * Set of Api in order to synchronize key as int for Mok tables Notification
         * And for Hashing value for file WatchDog
         * * ********************************************************************************************
         */
       
        public Boolean registerRequestProcessed(Boolean bSensInbound, int iHashCode)
        {
            Boolean bRet = false;
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("insert into dbo.CollisionTracker ([SensInbound], [Stream], [hashValue]) values(@SensInbound,@ListenerName, @HashCode)", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@SensInbound", SqlDbType.Bit).Value = bSensInbound ? 1 : 0;                       
                        cmd1.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd1.Parameters.Add("@HashCode", SqlDbType.Int).Value = iHashCode;
                        int rowsAdded = cmd1.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            { }
            return bRet;
        }
        
        public Boolean canProcessRequest(Boolean bSensInbound, int iHashCode)
        {
            Boolean bRet = false;
            try
            {
                int iFound = default(int);
                lock (ReintranceLock)
                {
                    using (var cmd = new SqlCommand("SELECT id FROM dbo.CollisionTracker WHERE SensInbound=@SensInbound AND Stream=@ListenerName AND hashValue = @HashCode", oConnectionReferential))
                    {
                        cmd.Parameters.Add("@SensInbound", SqlDbType.Bit).Value = bSensInbound;                        
                        cmd.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd.Parameters.Add("@HashCode", SqlDbType.NVarChar).Value = iHashCode;

                        object result = cmd.ExecuteScalar();
                        if (result != null && result.GetType() == typeof(DBNull))
                            bRet = true;

                    }
                }
            }
            catch (Exception ex)
            { }
            return bRet;
        }


        public int registerLink(Guid idSource, int idTarget, Guid oGuid, SqlConnection oConnectionReferentialTrx = null)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand(@"update dbo.AssiduityMasterDataLink 
                                                       set  [refCorrelation] = @refCorrelation,
                                                            [idTarget] = @idTarget
                                                       where [idSource] = @idSource
                                                       AND fk_environment = @fk_environment
                                                       AND trxSource = @ListenerName", oConnectionReferentialTrx != null ? oConnectionReferentialTrx : oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                        cmd1.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = eListenerType.ToString();
                        cmd1.Parameters.Add("@idTarget", SqlDbType.Int).Value = idTarget;
                        cmd1.Parameters.Add("@refCorrelation", SqlDbType.UniqueIdentifier).Value = oGuid;
                        cmd1.Parameters.Add("@fk_environment", SqlDbType.Int).Value = iEnvironment;

                        iRet = cmd1.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            { }
            return iRet;
        }
        /*
        public int getLinkAssiduityId(int idSource)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("select [idTarget] from dbo.AssiduityLink where [idSource] = @idSource", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.Int).Value = idSource;
                        object oRet = cmd1.ExecuteScalar();
                        if (oRet != null)
                            iRet = (int)oRet;
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return iRet;
        }
        public int deleteLink(int idSource)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("Update dbo.AssiduityLink set is_deleted = 1 where [idSource] = @idSource", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.Int).Value = idSource;
                        int result = cmd1.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            { }
            return iRet;
        }
       */
    }
}
