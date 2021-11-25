using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Linq.Expressions;
using System.Threading;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;


namespace Lavery.Listeners
{
    public abstract class ListenerBase: MarshalByRefObject, IDisposable
    {
        connectionFactory oConnectionFactory;
        DataReferentialManagement oDataReferentialManagement;
        
        SqlConnection oConnectionTarget;
        SqlConnection oConnectionSource;
        SqlConnection oConnectionReferential;

        Thread workerThread;
        Boolean bStop = false;
        int iTimeOutThread;
        Boolean bCancelOnJobEchec;
        Stack oStackEnvelopp = new Stack();

        int iWaitOnMutex;
        Guid oGuidContext;
        String sPrefixeName;

        Boolean disposing;
        Boolean disposed;

        ~ListenerBase() => Dispose(false);

        public void Dispose()
        {
            Dispose(disposing: true);            
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.Disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    
                }
                oConnectionReferential.Close();
                oConnectionTarget.Close();
                oConnectionSource.Close();
                Disposed = true;
            }
        }

        public ListenerBase(connectionFactory oConnectionFactory)
        {
            try
            {
                this.oConnectionFactory = oConnectionFactory;
                
                oConnectionReferential = new SqlConnection(oConnectionFactory.ConnectionString("ConnectionReferential"));
                oConnectionReferential.Open();

                oDataReferentialManagement = new DataReferentialManagement(oConnectionReferential);
                
                oConnectionTarget = new SqlConnection(oConnectionFactory.ConnectionString("ConnectionTarget"));
                oConnectionTarget.Open();
                oConnectionSource = new SqlConnection(oConnectionFactory.ConnectionString("ConnectionSource"));
                oConnectionSource.Open();

                this.iTimeOutThread = oConnectionFactory.getKeyValueInt("ThreadTimeOut");
                this.bCancelOnJobEchec = oConnectionFactory.getKeyValueInt("CancelOnJobEchec") == 1;
                workerThread = new Thread(new ThreadStart(ThreadFunction));

            }
            catch (Exception ex)
            {

            }
        }
        
        private void ThreadFunction()
        {
            if (doInitialize())
            {
                while (!bStop)
                {
                    try
                    {
                        if (!doJob() && bCancelOnJobEchec)
                        {
                            bStop = true;
                            continue;
                        }                        
                        Thread.Sleep(ITimeOutThread);
                    }
                    catch (Exception ex)
                    {                         
                    }
                }
                doTerminate();
            }

        }

        public Boolean IsAlive()
        {
            Boolean bRet = true;
            try
            {
                bRet = workerThread.IsAlive;
                    
            }
            catch (Exception ex)
            {
                bRet = false;
            }

            return bRet;
        }
        public Boolean start(Boolean bWait)
        {
            Boolean bRet = true;
            try
            {
                workerThread.Start();
                while (bWait && !IsAlive())
                    Thread.Sleep(ITimeOutThread);
            }
            catch (Exception ex)
            {
                bRet = false;
            }

            return bRet;
        }

        public Boolean stop(Boolean bWait)
        {
            Boolean bRet = true;
            try
            {
                int iWait = 20;
                bStop = true;
                while (bWait && IsAlive() && iWait-- > 0)
                    Thread.Sleep(ITimeOutThread);
                if (IsAlive())
                {
                    workerThread.Abort();
                    while (bWait && IsAlive())
                        Thread.Sleep(ITimeOutThread);
                }
            }
            catch (Exception ex)
            {
                bRet = false;
            }
            return bRet;
        }
        public virtual void doConsistancy(String sStep)
        { }
        abstract public Boolean doInitialize();
        abstract public Boolean doJob();
        abstract public Boolean doTerminate();
                
        public connectionFactory OConnectionFactory { get => oConnectionFactory; set => oConnectionFactory = value; }
        public bool Disposed { get => disposed; set => disposed = value; }
        public bool Disposing { get => disposing; set => disposing = value; }
        public Stack OStackEnvelopp { get => oStackEnvelopp; }
        public int ITimeOutThread { get => iTimeOutThread; }
        
        public SqlConnection OConnectionTarget { get => oConnectionTarget; }
        public SqlConnection OConnectionSource { get => oConnectionSource; }
       
        public DataReferentialManagement ODataReferentialManagement { get => oDataReferentialManagement; }
        public int IWaitOnMutex { get => iWaitOnMutex; set => iWaitOnMutex = value; }
        public Guid OGuidContext { get => oGuidContext; set => oGuidContext = value; }
        public string SPrefixeName { get => sPrefixeName; set => sPrefixeName = value; }
    }
}
