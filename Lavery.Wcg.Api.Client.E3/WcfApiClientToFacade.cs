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
using Org.OpenAPITools.Model;
using System.ServiceModel;
using System.ServiceModel.Description;
using Laverfy.Wcf.Schemas;
using Laverfy.Wcf.Schemas.Matters;
using Lavery.Wcf.Core;

namespace Lavery.Wcf.Api.Client.E3
{
    [Serializable()]
    public class WcfApiClientToFacade : WcfBaseClient
    {
        //ConnectionPool<IGenericConnection, genericWCFConnection<IWcfClientMattersApi>> oPool = new ConnectionPool<IGenericConnection, genericWCFConnection<IWcfClientMattersApi>>();
        IWcfClientMattersApi proxy = default(IWcfClientMattersApi);
        public WcfApiClientToFacade(String sWithWCFEndPointName)
            : base(sWithWCFEndPointName)
        {
            try
            {
                var factory = new ChannelFactory<IWcfClientMattersApi>(new WebHttpBinding(), "HTTP://Localhost:8100");
                factory.Endpoint.Behaviors.Add(new WebHttpBehavior());
                proxy = factory.CreateChannel();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public MattterGetResponse postListOfMatter(MattersGet data)
        {
            MattterGetResponse oRet = default(MattterGetResponse);
             
            try
            {
                
                //genericWCFConnection<IWcfClientMattersApi> oGenericWrapper = (genericWCFConnection<IWcfClientMattersApi>)oPool.getConnection(sWCFEndPointName);
                try
                {
                    //IWcfClientMattersApi proxy = (IWcfClientMattersApi)oGenericWrapper.getConnection();

                    //E3EAPIMatterModelsMatterGetResponse oRet1 = default(E3EAPIMatterModelsMatterGetResponse);
                    oRet = proxy.postListOfMatter(data);
                }
                catch (Exception ex)
                {

                    throw (ex);
                }
                finally
                {
                    //oPool.releaseGenericConnection(oGenericWrapper);

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
