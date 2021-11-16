using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Lavery.Tools.Interfaces
{

     [ServiceContract]
    public interface IWcfClientBase
    {
        [OperationContract]      
        String PingService(String sWithCorrelId);
    }

}
