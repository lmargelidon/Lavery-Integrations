using Lavery.Tools.ConnectionPool;
using Lavery.Tools.Connections;
using Lavery.Tools.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lavery.Tools.Connections
{

    public class ConnectionPoolDatabases<T>    where T: IGenericConnection 
                                        
    {
        String[] aValidConnectionSqlStringToken = { "Data Source", "Initial Catalog", "Integrated Security", "User Id", "Password" };
        private static List<ConnexionBase<T>> lLogicalConnection = new List<ConnexionBase<T>>();
        public static int iMinAvailableConnexion = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["MinAvailableConnexionToPool"]) != 0 ? 
                                                    Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["MinAvailableConnexionToPool"]) : 5;
        public static int iGenerated = 0;
        private static object syncLock = new object();
        int iConnectionActive = 0;
        int iTypeConnection = -1;

        public int IConnectionActive
        {
            get { return iConnectionActive; }
           
        }

        public ConnectionPoolDatabases(int iWithTypeConnection)
        {
            iTypeConnection = iWithTypeConnection;
        }
        public int Count(String sWithConnectionString)
        {
            int iRet = 0;
            try 
            {
                foreach (ConnexionBase<T> oBase in lLogicalConnection)
                    if (oBase.isMe(sWithConnectionString))
                        iRet++;

            }
            catch (Exception ex)
            { 
                throw (ex);
            }
            return iRet;
        }
        public ConnexionBase<T> addConnectionToPool(int iWithAddConnection, String sWithConnectionString)
        {
            ConnexionBase<T> oBase = null;
            try
            {
                lock (syncLock)
                {
                    for (int iConn = 0; iConn < iWithAddConnection; iConn++)
                    {
                        IGenericConnection oOBj = (IGenericConnection)genericDataBaseConnection.buildDatabaseConnection(iTypeConnection);
                        oBase = ConnexionBase<T>.buildConnexion(sWithConnectionString, oOBj);
                        lLogicalConnection.Add(oBase);
                        iGenerated++;
                    }
                }
            }
            catch(Exception ex)
            {
                throw(ex);
            }  
            return oBase;
        }
        public void removeConnectionToPool(int iWithRemoveConnection, String sWithConnectionString)
        {
            try
            {                
                lock (syncLock)
                {   int iMaxConnection = Count(sWithConnectionString);
                    int iTobeRemoved = iMaxConnection - iWithRemoveConnection < iMinAvailableConnexion ?
                                        iMaxConnection - iMinAvailableConnexion : iMaxConnection - iMinAvailableConnexion;
                    List<ConnexionBase<T>> lLogicalConnectionToBeRemoved = new List<ConnexionBase<T>>();
                    foreach (ConnexionBase<T> oBase in lLogicalConnection)
                    {
                        T oConnection = default(T);
                        if (oBase.isMe(sWithConnectionString))
                        {
                            if (iTobeRemoved > 0)
                            {
                                if ((oConnection = (T)oBase.getConnexionIfAvailable(sWithConnectionString)) != null)
                                {
                                    lLogicalConnectionToBeRemoved.Add(oBase);
                                    iTobeRemoved--;

                                }
                            }
                            else
                                break;
                        }
                    }
                      
                    for (int iConn = lLogicalConnectionToBeRemoved.Count - 1; iConn >= 0; iConn-- )
                    {
                        ConnexionBase<T> oBase = lLogicalConnectionToBeRemoved[iConn];
                        lLogicalConnection.Remove(oBase);
                        oBase.Dispose();                            

                    }                 
                    
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public T getConnection(String sWithConnectionStringParameters)
        {
            T oConnection = default(T);
            try
            {
                String sWithConnectionString = getNormalizedConnectionString(sWithConnectionStringParameters);


                int iWait = 10;
                while (oConnection == null /*&& iWait-- > 0*/)
                {
                    int iCountConnection = Count(sWithConnectionString);
                    if (iMinAvailableConnexion > iCountConnection)
                    {
                        lock (syncLock)
                        {
                            iCountConnection = Count(sWithConnectionString);
                            ConnexionBase<T> oConnectionType = default(ConnexionBase<T>);
                            if (iMinAvailableConnexion > iCountConnection)
                                oConnectionType = addConnectionToPool( iMinAvailableConnexion - iCountConnection, sWithConnectionString);
                           
                            if ((oConnection = (T)oConnectionType.getConnexionIfAvailable(sWithConnectionString)) != null)
                            {
                                iConnectionActive++;
                                Console.WriteLine("New Connection<{0}> Thread <{1}> timestamp<{2}>...", Count(sWithConnectionString), Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("fff"));
                                break;
                            }
                           
                        }
                    }
                    else
                    {
                        lock (syncLock)
                        {
                            int iVal = 0;
                            foreach (ConnexionBase<T> oConnectionType in lLogicalConnection)
                            {
                                if (oConnectionType.isMe(sWithConnectionString))
                                    if ((oConnection = (T)oConnectionType.getConnexionIfAvailable(sWithConnectionString)) != null)
                                    {
                                        // Console.WriteLine("Get Available Connection<{0}/{1}> Thread <{2}> timestamp<{3}>...", iVal, lLogicalConnection.Count, Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("fff"));

                                        break;
                                    }
                                iVal++;
                            }
                        }
                    }
                    Thread.Sleep(1);         
                }
                if (oConnection == null)
                    throw (new Exception(iWait < 0 ? "No connexion available to connect to the Database...!" : "Unable to connect to the Database...!"));

            }
            catch (Exception ex)
            { throw (ex); }
            return oConnection;

        }
        public Boolean releaseGenericConnection(T oWithConnection)
        {
            Boolean bRet = false;
            try
            {
                if (oWithConnection != null)
                {
                    while (!bRet)
                    {
                        lock (syncLock)
                        {
                            foreach (ConnexionBase<T> oConnectionType in lLogicalConnection)
                            {
                                if (oConnectionType.isMe(oWithConnection))
                                {

                                    if (oConnectionType.releaseConnexion())
                                    {
                                        iConnectionActive--;
                                        bRet = true;
                                        break;
                                    }
                                }
                            }
                        }
                        Thread.Sleep(1);
                    }
                }

            }
            catch (Exception ex)
            { throw (ex); }
            return bRet;

        }

        String getNormalizedConnectionString(String sWithConnectionString)
        {
            String sRet = sWithConnectionString;
            try
            {
                char[] sSep = new char[2];
                sSep[0] = ';';
                String[] sTokenCS = sWithConnectionString.Split(sSep);
                String sSqlConnectionString = "";
                int iCountValid = 0;
                foreach (String sSubString in sTokenCS)
                {
                    char[] sSep1 = new char[2];
                    sSep1[0] = '=';
                    String[] sTokenCS1 = sSubString.Split(sSep1);
                    Boolean bValid = false;
                    foreach(String sToken in aValidConnectionSqlStringToken)
                        if (sTokenCS1[0].Trim().Equals(sToken, StringComparison.CurrentCultureIgnoreCase))
                        {
                            bValid = true;
                            iCountValid++;
                            break;
                        }
                    if(bValid)
                        sSqlConnectionString += ((sRet.Length > 0 ? ";" : "") + sSubString);
                                 
                }
                if (iCountValid > 2)
                    sRet = sSqlConnectionString;
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return sRet;
        
        }
        
        
    }
 
}
