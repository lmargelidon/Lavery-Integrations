﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using Lavery.Client.E3;


namespace Lavery.Wcf.Api.E3
{

    [ServiceContract]
    public interface IE3Api : IWcfClientBase
    {
        /*
            * *************************************************************************************************************************
                   expl: http://ldbm3edevbtlk.lavery.qc.ca:8100/getClient?data=\%7B\%22usernumber\%22:\%2210073\%22\%7D
            * *************************************************************************************************************************
            */
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare)]
        String getClient(String data);



        /*
         * *************************************************************************************************************************
                expl:  http://ldbm3edevbtlk.lavery.qc.ca:8100/postexistclient
         * *************************************************************************************************************************
         */
        
        [OperationContract]
        [WebInvoke(UriTemplate = "postexistclient",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           Method = "POST")]        
        String postExistClient(ClientGetClientsRequest data);

       
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "echo")]
        String postEcho();


        /*
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "PingService")]
        Stream postPingService(Stream sWithRequest);
         * */
    }

    [DataContract]
    public class ClientInformation
    {
        [DataMember]
        public String usernumber { get; set; }       
    }

}
