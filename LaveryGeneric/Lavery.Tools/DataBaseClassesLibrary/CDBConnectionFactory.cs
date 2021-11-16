using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using System.Data;
using Lavery.Tools.Interfaces;

namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CDBConnectionFactory : CDBObject
    {   private static List<CDBConnection> elements = new List<CDBConnection>();
        
        public CDBConnectionFactory()
        {
            eType = ConnType.eConnType.NOTHING;
        }
        
       
        public CDBConnection addConnection(eTypeOfConnection eWithToc, ConnType.eConnType eWithType, string sConnectionString)
        {
            CDBConnection pConn = null;
            try
            {
                if (eWithType == ConnType.eConnType.DB2UDB)
                {
#if DB2 
                    CDBConnectionForDB2UDB pConnUdb = null;
                    pConnUdb = new CDBConnectionForDB2UDB(sConnectionString);
                    pConnUdb.connect();
                    pConn = pConnUdb;
#endif
                }

                if (eWithType == ConnType.eConnType.SQLSERVER)
                {
                    CDBConnectionForSqlServer pConnSql = null;
                    pConnSql = new CDBConnectionForSqlServer(sConnectionString, eWithToc);
                    pConnSql.connect();
                    pConn = pConnSql;
                }
               

                lock (this)
                {
                    elements.Add(pConn);
                }
            }
            catch (Exception ex)
            {
                throw (ex); 
            }
            return pConn;
        }
        public CDBConnection addConnection(ConnType.eConnType eWithType, string sConnectionString)
        {   return addConnection(eTypeOfConnection.READ, eWithType, sConnectionString);
        }
        public CDBConnection getConnection(ConnType.eConnType eWithType, int iTo)
        {
            CDBConnection pRet = null;
            try
            {   lock(this)
                {
                    while (pRet == null && iTo > 0)
                    {
                        foreach (CDBConnection pSelect in elements)
                        {
                            if (pSelect.eType == eWithType)
                                if (pSelect.dbLock(1))
                                {
                                    pRet = pSelect;
                                    break;
                                }

                        }
                        if (pRet == null)
                        {
                            Thread.Sleep(100);
                            iTo -= 100;
                        }
                        else
                        {
#if DB2 
                            if (!pRet.isConnected())
                                if (pRet.eType == ConnType.eConnType.DB2UDB)
                                    ((CDBConnectionForDB2UDB)pRet).connect();
#endif
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex); 
            }
            return pRet;
        }
        /*
         */
        public CDBConnection getConnection(eTypeOfConnection eWithToc, ConnType.eConnType eWithType, int iTo)
        {
            CDBConnection pRet = null;
            try
            {
                lock (this)
                {
                    while (pRet == null && iTo > 0)
                    {
                        foreach (CDBConnection pSelect in elements)
                        {
                            if (pSelect.eType == eWithType &&
                                pSelect.EToc == eWithToc)
                                if (pSelect.dbLock(1))
                                {
                                    pRet = pSelect;
                                    break;
                                }

                        }
                        if (pRet == null)
                        {
                            Thread.Sleep(100);
                            iTo -= 100;
                        }
                        else
                        {
#if DB2 
                            if (!pRet.isConnected())
                                if (pRet.eType == ConnType.eConnType.DB2UDB)
                                    ((CDBConnectionForDB2UDB)pRet).connect();
#endif
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return pRet;
        }
        public CDBConnection getConnection(ConnType.eConnType eWithType, String sWithConnString, int iTo)
        {
            CDBConnection pRet = null;
            try
            {
                lock (this)
                {
                    while (pRet == null && iTo > 0)
                    {
                        foreach (CDBConnection pSelect in elements)
                        {
                            if (pSelect.eType == eWithType &&
                                pSelect.isMe(sWithConnString))
                                if (pSelect.dbLock(1))
                                {
                                    pRet = pSelect;
                                    break;
                                }

                        }
                        if (pRet == null)
                        {
                            Thread.Sleep(100);
                            iTo -= 100;
                        }
                        else
                        {
#if DB2 
                            if (!pRet.isConnected())
                                if (pRet.eType == ConnType.eConnType.DB2UDB)
                                    ((CDBConnectionForDB2UDB)pRet).connect();
#endif
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return pRet;
        }
        public void releaseConnection(CDBConnection pConn)
        {
            try
            {
                lock (this)
                {
                    pConn.dbUnlock();
                }
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            
        }
        public int countAvailableConnection(eTypeOfConnection eWithToc, ConnType.eConnType eWithType)
        {
            int iRet = 0;
            try
            {
                foreach (CDBConnection pSelect in elements)
                {
                    if (pSelect.eType == eWithType &&
                        pSelect.EToc == eWithToc && pSelect.isConnected())
                        iRet++;    

                }
            }
            catch (Exception ex)
            {
                throw (ex);
               
            }
            return iRet;
        }
        public int countAvailableConnection(eTypeOfConnection eWithToc, String SConnectionString)
        {
            int iRet = 0;
            try
            {
                foreach (CDBConnection pSelect in elements)
                {
                    if (pSelect.ConnString.Equals(SConnectionString, StringComparison.CurrentCultureIgnoreCase) &&
                        pSelect.EToc == eWithToc && pSelect.isConnected())
                        iRet++;

                }
            }
            catch (Exception ex)
            {
                throw (ex);               
            }
            return iRet;
        }
        
    }
}
