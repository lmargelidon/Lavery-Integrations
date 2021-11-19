using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Lavery.Tools
{
    public class DataReferentialManagement : Object, IDisposable
    {
        SqlConnection oConnectionReferential;
        private readonly object ReintranceLock = new object();

        Boolean disposing;
        Boolean disposed;

        public DataReferentialManagement(SqlConnection oConnectionReferential)
        {
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
        public Boolean registerRequestProcessed(Boolean bSensInbound, String sListenerName, Guid sGuidE3)
        {
            Boolean bRet = false;
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("insert into dbo.CollisionTracker ([SensInbound], [Stream], [GuidE3]) values(@SensInbound,@ListenerName, @GuidE3)", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@SensInbound", SqlDbType.Bit).Value = bSensInbound ? 1 : 0;
                        cmd1.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = sListenerName;
                        cmd1.Parameters.Add("@GuidE3", SqlDbType.NVarChar).Value = sGuidE3.ToString();
                        int rowsAdded = cmd1.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            { }
            return bRet;
        }
        public Boolean canProcessRequest(Boolean bSensInbound, String sListenerName, Guid sGuidE3)
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
                        cmd.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = sListenerName;
                        cmd.Parameters.Add("@GuidE3", SqlDbType.NVarChar).Value = sGuidE3.ToString();

                        if (cmd.ExecuteScalar() == null)
                            bRet = true;

                    }
                }
            }
            catch (Exception ex)
            { }
            return bRet;
        }
        public DateTime getLastRegisteredDate(String sListenerName)
        {
            DateTime oRet = DateTime.MaxValue;
            try
            {
                int iFound = default(int);
                lock (ReintranceLock)
                {
                    using (var cmd = new SqlCommand("SELECT max(TimeStamp) FROM dbo.AssiduityMasterDataLink WHERE  [trxSource]=@ListenerName", oConnectionReferential))
                    {
                        cmd.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = sListenerName;
                        oRet = (DateTime)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            { }
            return oRet;
        }
        public String getAllEntries(DateTime dtFrom, String sListenerName, SqlConnection oConnectionSource)
        {
            String sRet = default(String);
            try
            {
                int iFound = default(int);
                lock (ReintranceLock)
                {
                    using (var cmd = new SqlCommand(String.Format("SELECT * FROM [dbo].[{0}] WHERE TimeStamp > @TimeStamp FOR JSON PATH, Root('TimeCards')", sListenerName), oConnectionSource))
                    {                        
                        cmd.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = dtFrom;
                        sRet = (String)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            { }
            return sRet;
        }
        public int registerLink(Guid idSource, DateTime tsValue, int idTarget, Guid oGuid, String sTableSource, String sDetail)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    if(getLinkCorrelationId(idSource) == default(Guid))
                        using (var cmd1 = new SqlCommand("insert into dbo.AssiduityMasterDataLink ([refCorrelation], [idSource], [idTarget], [trxSource], [is_deleted], [TimeStamp]) values(@refCorrelation, @idSource,@idTarget,@trxSource, @is_deleted, @TimeStamp )", oConnectionReferential))
                        {
                            cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                            cmd1.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = tsValue;
                            cmd1.Parameters.Add("@trxSource", SqlDbType.NVarChar).Value = sTableSource;
                            cmd1.Parameters.Add("@idTarget", SqlDbType.Int).Value = idTarget;
                            cmd1.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = 0;
                            cmd1.Parameters.Add("@refCorrelation", SqlDbType.UniqueIdentifier).Value = oGuid;

                            iRet = cmd1.ExecuteNonQuery();
                        }
                    if (sDetail != default(String))
                    {
                        int iPKMaster = getLinkPrimaryKeyValue(idSource);
                        using (var cmd1 = new SqlCommand("insert into dbo.AssiduityDetailDataLink ([idMaster], [detailTrx]) values(@idMaster, @detailTrx )", oConnectionReferential))
                        {
                            cmd1.Parameters.Add("@idMaster", SqlDbType.Int).Value = iPKMaster;
                            cmd1.Parameters.Add("@detailTrx", SqlDbType.NVarChar).Value = sDetail;
                            iRet = cmd1.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
            return iRet;
        }
        public int getLinkAssiduityId(Guid idSource)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("select [idTarget] from dbo.AssiduityMasterDataLink where [idSource] = @idSource", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
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
        public Guid getLinkCorrelationId(Guid idSource)
        {
            Guid iRet = default(Guid);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("select [refCorrelation] from dbo.AssiduityMasterDataLink where [idSource] = @idSource", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
                        object oRet = cmd1.ExecuteScalar();
                        if (oRet != null)
                            iRet = (Guid)oRet;
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return iRet;
        }
        public int getLinkPrimaryKeyValue(Guid idSource)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("select [id] from dbo.AssiduityMasterDataLink where [idSource] = @idSource", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
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
        public int deleteLink(Guid idSource)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("Update dbo.AssiduityMasterDataLink set is_deleted = 1 where [idSource] = @idSource", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.NVarChar).Value = idSource.ToString();
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
        public Boolean registerRequestProcessed(Boolean bSensInbound, String sListenerName, int iHashCode)
        {
            Boolean bRet = false;
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("insert into dbo.CollisionTracker ([SensInbound], [Stream], [hashValue]) values(@SensInbound,@ListenerName, @HashCode)", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@SensInbound", SqlDbType.Bit).Value = bSensInbound ? 1 : 0;
                        cmd1.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = sListenerName;
                        cmd1.Parameters.Add("@HashCode", SqlDbType.Int).Value = iHashCode;
                        int rowsAdded = cmd1.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            { }
            return bRet;
        }
        
        public Boolean canProcessRequest(Boolean bSensInbound, String sListenerName, int iHashCode)
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
                        cmd.Parameters.Add("@ListenerName", SqlDbType.NVarChar).Value = sListenerName;
                        cmd.Parameters.Add("@HashCode", SqlDbType.NVarChar).Value = iHashCode;

                        if (cmd.ExecuteScalar() == null)
                            bRet = true;

                    }
                }
            }
            catch (Exception ex)
            { }
            return bRet;
        }


        public int registerLink(int idSource, int idTarget, Guid oGuid)
        {
            int iRet = default(int);
            try
            {
                lock (ReintranceLock)
                {
                    using (var cmd1 = new SqlCommand("insert into dbo.AssiduityLink ([refCorrelation], [idSource], [idTarget]) values(@refCorrelation, @idSource,@idTarget)", oConnectionReferential))
                    {
                        cmd1.Parameters.Add("@idSource", SqlDbType.Int).Value = idSource;
                        cmd1.Parameters.Add("@idTarget", SqlDbType.Int).Value = idTarget;
                        cmd1.Parameters.Add("@refCorrelation", SqlDbType.UniqueIdentifier).Value = oGuid;

                        iRet = cmd1.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            { }
            return iRet;
        }
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
    }
}
