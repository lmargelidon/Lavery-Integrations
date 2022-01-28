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


using Lavery.Wcf.Core;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lavery.Wcf.Api.Client.E3
{
    [Serializable()]
    public class WcfApiClientToFacade : WcfBaseClient
    {
        //ConnectionPool<IGenericConnection, genericWCFConnection<IWcfClientMattersApi>> oPool = new ConnectionPool<IGenericConnection, genericWCFConnection<IWcfClientMattersApi>>();
        IE3Api proxy = default(IE3Api);
        public WcfApiClientToFacade(String sWithWCFEndPointName)
            : base(sWithWCFEndPointName)
        {
            try
            {
                var factory = new ChannelFactory<IE3Api>(new WebHttpBinding(), "HTTP://Localhost:8100");
                factory.Endpoint.Behaviors.Add(new WebHttpBehavior());
                proxy = factory.CreateChannel();
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }

        public genericResponse postListOfMatter(MatterGetMattersRequest data)
        {
            genericResponse oRet = default(genericResponse);

            try
            {
                
                oRet = proxy.postListOfMatter(data);
               
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return oRet;
        }
        /*
        private async Task<HttpResponseMessage> SendRequestAsync(string adaptiveUri, string xmlRequest)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                StringContent httpConent = new StringContent(xmlRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = null;
                try
                {
                    responseMessage = await httpClient.PostAsync(adaptiveUri, httpConent);
                }
                catch (Exception ex)
                {
                    if (responseMessage == null)
                    {
                        responseMessage = new HttpResponseMessage();
                    }
                    responseMessage.StatusCode = HttpStatusCode.InternalServerError;
                    responseMessage.ReasonPhrase = string.Format("RestHttpClient.SendRequest failed: {0}", ex);
                }
                return responseMessage;
            }
        }
        */

    }
}
