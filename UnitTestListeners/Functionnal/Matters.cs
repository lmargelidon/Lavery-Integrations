using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lavery.Wcf.Api.E3;
using Lavery.Client.E3;
using Org.OpenAPITools.Model;
using Lavery.Wcf.Api.Client.E3;


using Lavery.Wcf.Core;

namespace UnitTestListeners.Functionnal
{
    [TestClass]
    public class Matters
    {
        [TestMethod]
        public void MatterGetMattersTest()
        {

            MatterGetMattersRequest oRequest = new MatterGetMattersRequest();
            genericResponse response =  default(genericResponse);
            WcfApiClientToFacade oApi = new WcfApiClientToFacade("postListOfMatter");
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid> matterId = null;
            oRequest.matterId = null;
            //int? mattIndex = null;
            oRequest.mattIndex = 647;
            //string number = null;
            oRequest.number = null;
            
            response = oApi.postListOfMatter(oRequest);
            
            Assert.IsInstanceOfType(response, typeof(genericResponse), "response is MatterGetResponse");
        }
    }
}
