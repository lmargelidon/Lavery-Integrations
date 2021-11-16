using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Lavery.Wcf.Api.E3
{

     [ServiceContract]
    public interface IWcfClientBase
    {
        [OperationContract]      
        String PingService(String sWithCorrelId);
    }

}
