using System;
using System.Collections.Generic;

namespace Lavery.Constants
{
    abstract public class LaveryBusinessFunctions
    {
        public enum eCategory
        {
            None, ListenerHelpper, ListenerConsoleService, ListenerInboundService, ListenerOutboundService, ListenerAssiduitySqlNotification, ListenerAssiduityMsMq, ListenerErsFileSystemWatcher
        }

        public enum eBusinessFunction
        {
            None, Start, Stop, Initialize, CollectExistingFile, CleaningExistingFile, PerformEntry, Terminate, CatchNotification,
            InsertAbsenceRequest, UpdateAbsenceRequest, DeleteAbsenceRequest, MainLoop, testStatus
        }

        static public Dictionary<eBusinessFunction, String> oBusinessFunction = new Dictionary<eBusinessFunction, string>()
        {
            {eBusinessFunction.None,""}

        };
    }
       
}
