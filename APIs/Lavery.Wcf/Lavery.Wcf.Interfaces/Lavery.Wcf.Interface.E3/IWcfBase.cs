using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lavery.Wcf.Api.E3
{

     [ServiceContract]
    public interface IWcfBase
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "pingservice",
                    RequestFormat = WebMessageFormat.Json,
                    ResponseFormat = WebMessageFormat.Json,
                    BodyStyle = WebMessageBodyStyle.Bare,
                    Method = "POST")]
        String PingService();
    }

}
