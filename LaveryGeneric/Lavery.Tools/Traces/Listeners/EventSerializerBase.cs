using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Lavery.Events.Listeners;
using Lavery.Tools.Configuration.Management;
using Lavery.Tools.Runtime;



namespace Lavery.Events.Listeners
{
    public abstract class EventSerializerBase
    {
        static Object syncObject = new Object();
        static Boolean bInitialized = false;
        static connectionFactory oConnectionFactory = new connectionFactory();

        public static connectionFactory OConnectionFactory { get => oConnectionFactory;  }

        abstract public  Boolean recordEvent(String sWithSchema, String sWithRessource, EventEntryBase oEntryBase);
        abstract public int getKey(String sWithTableSchema, String sWithTableName, String sWithWhereClause);
        public static void Initialize()
        {
            try
            {
                
                if (!bInitialized)
                    lock(syncObject)
                    {
                        if (!bInitialized)
                        {
                            TraceSwitch appSwitch = new TraceSwitch("DefaultServiceLoging", "Switch in config file");
                            //TraceSwitch appSwitch = new TraceSwitch("TraceMasterSwitch", "Switch in config file");
                            persistEventManager.init();                           
                            bInitialized = true;
                        }
                    }
            
            }
            catch (Exception ex)
            {
                TracePending.Trace(ex.Message);
            }
        
        }
    }
}
