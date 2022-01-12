using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Wcf.Api.Client.E3;
using Laverfy.Wcf.Schemas;
using Laverfy.Wcf.Schemas.Matters;
using Lavery.Wcf.Core;


namespace SqlDependency
{
    public class MattersManagement
    {

        public MattterGetResponse getMatters(int iIndex)
        {
            MattersGet oRequest = new MattersGet();
            MattterGetResponse response = default(MattterGetResponse);
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
