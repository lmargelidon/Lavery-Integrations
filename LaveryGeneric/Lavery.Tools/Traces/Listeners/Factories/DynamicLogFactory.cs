using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;






namespace Lavery.Events.Listeners
{

    public class DynamicEventsFactory
    {
        static public IDynamicEvents Create(string sNameOfDBTRace, bool bWithAutoFlush)
        {
            IDynamicEvents iRet = null;
            try
            {

                iRet = new DynamicEvents(sNameOfDBTRace, bWithAutoFlush);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return iRet;
        }
        static public IDynamicEvents Create(string sNameOfDBTRace, bool bWithAutoFlush, bool bWithtraceHeader)
        {
            IDynamicEvents iRet = null;
            try
            {
                DynamicEvents.BTraceHeader = bWithtraceHeader;
                iRet = new DynamicEvents(sNameOfDBTRace, bWithAutoFlush);

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return iRet;
        }
    }
}