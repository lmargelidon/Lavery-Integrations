using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Net;
using System.Security.Principal;

using System.Diagnostics;
using Lavery.Wcf.Api.E3;

using Lavery.Tools.ConnectionPool;
using Lavery.Tools.Connections;
using Lavery.Tools.Interfaces;
using Lavery.Client.E3;



namespace Lavery.Wcg.Api.Client.E3
{
    [Serializable()]
    public class WcfApiClientToFacade : WcfBaseClient
    {
        //ConnectionPool<IGenericConnection, genericWCFConnection<IWcfPersistEvents>> oPool = new ConnectionPool<IGenericConnection, genericWCFConnection<IWcfPersistEvents>>();
        public WcfApiClientToFacade(String sWithWCFEndPointName)
            : base(sWithWCFEndPointName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public void postExistClient(ClientGetClientsRequest data)
        {
            try
            {
                /*
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
                */
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}
