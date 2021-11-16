using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Lavery.Events.Listeners
{    
    public interface IDynamicEvents
    {
        SourceLevels getTraceLevel();
        string getName();
        /*
        void TraceVerbose(String[] sWithOutMessage);
        void TraceInformation(String[] sWithOutMessage);
        void TraceWarning(String[] sWithOutMessage);
        void TraceError(String[] sWithOutMessage);

        void TraceVerbose(String sWithOutMessage);
        void TraceInformation(String sWithOutMessage);
        void TraceWarning(String sWithOutMessage);
        void TraceError(String sWithOutMessage);
         * */
        void TraceEvent(String sWithOutMessage);
        void TraceEvent(EventEntry oWithOutMessage);

    }
}
