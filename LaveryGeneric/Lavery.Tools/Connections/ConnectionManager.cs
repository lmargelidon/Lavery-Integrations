using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SqlClient;

using Lavery.Tools.Interfaces;

namespace Lavery.Tools.ConnectionPool
{
    public class ConnexionBase<T> where T : IGenericConnection

    {
        private static object syncLock = new object();
        private Boolean bAvailable = true;

        public Boolean BAvailable
        {
            get { return bAvailable; }           
        }
        private T oConnectionType = default(T);
        private String sConnectionString = "";
        private bool disposed = false;

        public ConnexionBase(String sWithConnectionString, T oWithObj)
        {
            try
            {
               oConnectionType = oWithObj;
               oConnectionType.Open(sWithConnectionString);
                sConnectionString = sWithConnectionString;

            }
            catch (Exception ex)
            {
                throw (new Exception(ex.Message+ " : " + sWithConnectionString));
            }

        }        

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    oConnectionType.Close();
                }
                
                disposed = true;
            }
    }

       // Utliser le destructeur C# pour finaliser le code
        ~ConnexionBase()
        {
            // Simply call Dispose(false).
            Dispose (false);
        }



        static public ConnexionBase<T> buildConnexion(String sWithConnectionString, Object oWithObj)
        {
            ConnexionBase<T> oREt = null;
            try
            {
                oREt = new ConnexionBase<T>(sWithConnectionString, (T)oWithObj);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return oREt;

        }
        public Boolean isMe(Object oWithSqlConnection)
        {
            Boolean bRet = false;
            try
            {
                bRet = oWithSqlConnection.Equals(oConnectionType) ? true : false;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;

        }
        public Boolean isMe(String oWithSqlConnectionString)
        {
            Boolean bRet = false;
            try
            {
                bRet = oWithSqlConnectionString.Equals(sConnectionString, StringComparison.CurrentCultureIgnoreCase) ? true : false;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;

        }
        public Boolean releaseConnexion()
        {
            Boolean bRet = false;
               
            try
            {
                if (Monitor.TryEnter(syncLock, 1))
                {
                    try
                    {
                        bAvailable = true;
                        bRet = true;
                    }
                    finally
                    {
                        Monitor.Exit(syncLock);
                    }
                }


            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
        }
        public Object getConnexionIfAvailable(String sWithConnectionString)
        {
            Object oRet = default(Object);
            try
            {
                if (bAvailable)
                {
                    if (Monitor.TryEnter(syncLock, 1))
                    {
                        try
                        {
                            if (bAvailable)
                            {
                                oRet = this.oConnectionType;
                                bAvailable = false;
                            }
                        }
                        finally
                        {
                            Monitor.Exit(syncLock);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return oRet;
        }
    }
}
