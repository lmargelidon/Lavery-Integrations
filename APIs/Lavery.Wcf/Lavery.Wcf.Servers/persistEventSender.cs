using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Net;
using System.Security.Principal;

using System.Diagnostics;
using lsaTools.genericConnections;
using LsaInterfaces.WcfServices;
using lsaTools.genericEvents;
using Lsa.Tools.XML;
using lsaTools.ConnectionPool;
using lsaTools.GenericInterface;

namespace WCFServices.Clients
{
    [Serializable()]
    public class persistEventSender:WcfBaseClient
    {
        ConnectionPool<IGenericConnection, genericWCFConnection<IWcfPersistEvents>> oPool = new ConnectionPool<IGenericConnection, genericWCFConnection<IWcfPersistEvents>>();
        public persistEventSender(String sWithWCFLoggerEndPointName)
            : base(sWithWCFLoggerEndPointName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
         
        public void propageEvent(String sWithEntry, eEventType eWithEventEntry)
        {
            try
            {
                genericWCFConnection<IWcfPersistEvents> oGenericWrapper =
                                        (genericWCFConnection<IWcfPersistEvents>)oPool.getConnection(sWCFEndPointName);
                try
                {
                    
                    IWcfPersistEvents oConn = (IWcfPersistEvents)oGenericWrapper.getConnection();

                    oConn.persistEvent(sWithEntry, eWithEventEntry);
                }
                catch (Exception ex)
                {

                    throw (ex);
                }
                finally
                {
                    oPool.releaseGenericConnection(oGenericWrapper);

                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
