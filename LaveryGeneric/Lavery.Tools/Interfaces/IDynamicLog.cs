using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace lsaTools.GenericInterface
{    
    public interface IDynamicLog
    {
        SourceLevels getTraceLevel();
        string getName();
        void TraceVerbose(String[] sWithOutMessage);
        void TraceInformation(String[] sWithOutMessage);
        void TraceWarning(String[] sWithOutMessage);
        void TraceError(String[] sWithOutMessage);

        void TraceVerbose(String sWithOutMessage);
        void TraceInformation(String sWithOutMessage);
        void TraceWarning(String sWithOutMessage);
        void TraceError(String sWithOutMessage);

    }
}
