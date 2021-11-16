using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using lsaTools.GenericInterface;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.IO;
using AbstractGenericClasses;


namespace DescartesInterfaces.WcfServices
{
    //(Namespace = "http://ezysnap.com/rateApi")
    [DataContract]
    public class requestData
    {
        [DataMember]
        public String detail { get; set; }

    }
    [DataContract]
    public class responseData
    {
        [DataMember]
        public String detail { get; set; }

    }
    
    [ServiceContract]
    public interface IWcfDescartesRateApi : IWcfClientBase
    {
        /*
         * *************************************************************************************************************************
                expl: http://localhost:8085/computeRating?sWithRequest=TERATHP
         * *************************************************************************************************************************
         */
        [OperationContract]
        [WebGet]
        Stream computeRating(String sWithRequest);

        /*
         * *************************************************************************************************************************
                expl: http://localhost:8085/testParsing?sWithInterfaceName=TERATHP
         * *************************************************************************************************************************
         */
        [OperationContract]
        [WebGet]
        Stream testParsing(String sWithInterfaceName);

        [OperationContract]
        [WebInvoke(Method= "POST",
            BodyStyle = WebMessageBodyStyle.Bare, 
            UriTemplate ="computeRating")]
         Stream postRating(Stream sWithRequest);
        [OperationContract]
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "testParsing")]
        Stream postTestParsing(Stream sWithRequest);
    }
}
