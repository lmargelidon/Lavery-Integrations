using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lavery.Tools.Configuration.Management;
using Lavery.Events.Listeners;
using Lavery.Constants;

namespace Lavery.Connector
{
    public class FileSystemWatcher : ConnectorBase
    {
        System.IO.FileSystemWatcher oWatcher;
        Guid oGuid;
        String sPrefixeName;
        delegateFonction oDelegateOncreate;
        delegateFonction oDelegateOnChanged;

        public FileSystemWatcher(connectionFactory oConnectionFactory, String sConfigSourceDirectory, Guid oGuid, String sPrefixeName) : base(oConnectionFactory)
        {
            try
            {
                this.oGuid = oGuid;
                this.sPrefixeName = sPrefixeName;
                oWatcher = new System.IO.FileSystemWatcher(oConnectionFactory.getKeyValueString(sConfigSourceDirectory));

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduitySqlNotification.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Exception Catch : " + ex.Message,
                                                   oGuid.ToString(), sPrefixeName);
            }
        }
        public void NotifyFilter(delegateFonction oDelegateOncreate, delegateFonction oDelegateOnChanged)
        {
            oWatcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            //oWatcher.Changed += OnChanged;
            oWatcher.Created += OnCreated;           
            oWatcher.Error += OnError;

            this.oDelegateOncreate = oDelegateOncreate;
            this.oDelegateOnChanged = oDelegateOnChanged;

            oWatcher.Filter = "*.*";
            oWatcher.IncludeSubdirectories = true;
            oWatcher.EnableRaisingEvents = true;
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            oDelegateOnChanged(e, default(String));
            Console.WriteLine($"Changed: {e.FullPath}");
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            oDelegateOncreate(e, default(String));                
            Console.WriteLine(value);
        }
        private  void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private  void PrintException(Exception ex)
        {
            if (ex != null)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("Stacktrace:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                PrintException(ex.InnerException);
            }
        }

    }
}
