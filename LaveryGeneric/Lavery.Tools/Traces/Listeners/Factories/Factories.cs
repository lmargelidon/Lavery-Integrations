using Lavery.Tools.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Lavery.Events.Listeners
{
    
    public class FactoryBuilder
    {
        
        static public IDynamicEvents createDynamicEvents(string sNameOfDBTRace, bool bWithAutoFlush, bool bWithTraceHeader)
        {
            IDynamicEvents iRet = null;
            try
            {

                iRet = DynamicEventsFactory.Create(sNameOfDBTRace, bWithAutoFlush, bWithTraceHeader);
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
                throw (ex);
            }
            return iRet;
        }        
    }
}
