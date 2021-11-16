using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lavery.Wcf.Api.E3
{
    [Serializable()]
    public class WcfBaseClient
    {
       
       protected String sWCFEndPointName = default(String);
       
        public WcfBaseClient(String sWithWCFEndPointName)
        {
            try
            {
                sWCFEndPointName = sWithWCFEndPointName;
                
            
            }
            catch (Exception ex)
            {
                throw (ex);
            }
                
        }
        
    }
}
