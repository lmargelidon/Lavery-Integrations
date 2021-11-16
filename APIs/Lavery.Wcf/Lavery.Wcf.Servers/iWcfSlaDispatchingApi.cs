using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using lsaTools.GenericInterface;

namespace DescartesInterfaces
{
    [ServiceContract]
    public interface iWcfSlaDispatchingApi : IWcfClientBase
    {
        [OperationContract]
        String dispatchRequest(String s);
    }
    
    
}
