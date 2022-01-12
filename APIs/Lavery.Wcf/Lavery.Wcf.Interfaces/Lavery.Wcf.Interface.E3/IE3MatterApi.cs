using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using Lavery.Client.E3;
using Laverfy.Wcf.Schemas;
using Laverfy.Wcf.Schemas.Matters;
using Lavery.Wcf.Core;


namespace Lavery.Wcf.Api.E3
{

    [ServiceContract]
    public interface IE3MatterApi : IWcfClientBase
    {

        [OperationContract]
        [WebInvoke(UriTemplate = "postlistofmatter",
                    RequestFormat = WebMessageFormat.Json,
                    ResponseFormat = WebMessageFormat.Json,
                    BodyStyle = WebMessageBodyStyle.Bare,
                    Method = "POST")]
        MattterGetResponse postListOfMatter(MattersGet data);

       
    }
}