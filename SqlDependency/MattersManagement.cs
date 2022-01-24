using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Wcf.Api.Client.E3;
using Lavery.Client.E3;


using Lavery.Wcf.Core;


namespace SqlDependency
{
    public class MattersManagement
    {

        public genericResponse getMatters(int iIndex)
        {
            MatterGetMattersRequest oRequest = new MatterGetMattersRequest();
            genericResponse response = default(genericResponse);
            WcfApiClientToFacade oApi = new WcfApiClientToFacade("postListOfMatter");
            // TODO uncomment below to test the method and replace null with proper value
            //List<Guid> matterId = null;
            oRequest.matterId = null;
            //int? mattIndex = null;
            oRequest.mattIndex = iIndex;
            //string number = null;
            oRequest.number = null;

            response = oApi.postListOfMatter(oRequest);
            return response;
        }
    }
}
