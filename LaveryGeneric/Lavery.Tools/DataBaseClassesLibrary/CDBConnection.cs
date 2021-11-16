
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CDBConnection : CDBObject
    {
        private eTypeOfConnection eToc;

        private string connString;

        
        private bool        bUsed;
        private int         iThreadId;
        private bool        bConnected;

        public eTypeOfConnection EToc
        {
            get { return eToc; }
            set { eToc = value; }
        }
        public string ConnString
        {
            get { return connString; }
            set { connString = value; }
        }
        protected CDBConnection(string sWithconnString)
            : this(sWithconnString , eTypeOfConnection.READ)
        {   
        }
        protected CDBConnection(bool bUsePropertyFile):
            this(System.Configuration.ConfigurationManager.AppSettings.Get("ConnectionString"), eTypeOfConnection.READ)
        {  
        }
        protected CDBConnection(string sWithconnString, eTypeOfConnection eWithToc)
        {   connString  = sWithconnString;
            bUsed       = false;
            iThreadId   = -1;
            bConnected  = false;
            eToc        = eWithToc; 
        }
        public bool isMe(String sWithConnString)
        {
            bool bRet = false;
            try
            {
                bRet = connString.Equals(sWithConnString, StringComparison.CurrentCultureIgnoreCase);
            }
            catch (Exception ex)
            {
                throw (ex); 
            }
            return bRet;
        }
        public bool dbLock(int iTry)
        {   bool bRet = false;
            try
            {   bool bBoucle = true;
                do
                {
                    lock (this)
                    {
                        if (iThreadId == Thread.CurrentThread.ManagedThreadId ||
                            !bUsed)
                        {
                            bUsed = true;
                            iThreadId = Thread.CurrentThread.ManagedThreadId;
                            bRet = true;
                            bBoucle = false;
                        }
                    }
                    iTry--;
                }
                while (bBoucle && iTry > 0);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
        }
        public bool dbUnlock()
        {
            bool bRet = false;
            try
            {
                lock (this)
                {
                    if (iThreadId == Thread.CurrentThread.ManagedThreadId &&
                        bUsed)
                    {
                        bUsed = false;
                        iThreadId = -1;
                        bRet = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
        }
        public bool  isConnected()
        {   return bConnected;
        }
        public virtual bool connect()
        {  if (!bConnected)
                bConnected = true;
           return true;
        }
        public virtual bool disConnect()
        {  if (bConnected)
                bConnected = false;
            return true;
        }
        
       
    }
}
