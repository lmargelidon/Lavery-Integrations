using System;
using System.Text;
using System.IO;
using System.Configuration;

using System.Collections.Generic;
using Lavery.Listeners;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;
using Lavery.Events.Listeners;
using Lavery.Constants;
using Lavery.Connector;
using Lavery.Schemas.Legacy;
using Lavery.Schemas;
using Lavery.azure.resources;


namespace Lavery.Listeners
{
    public class ErsNetFilesEvents : ListenerBase
    {

       
              
        String sSourcePath;        
       
        Lavery.Connector.FileSystemWatcher oWatcher;
        XMLSerializer<Ers_Files_entry> oSerializer;
        ClientStorageBlobsContainer oBlobContainer;
       

        public ErsNetFilesEvents(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory)
        {
            try
            {

                
                this.sSourcePath = OConnectionFactory.getKeyValueString("ErsNetFilesDirectory");               
                this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
                this.oSerializer = new XMLSerializer<Ers_Files_entry>();
                this.SPrefixeName = SPrefixeName;
                ODataReferentialManagement.EListenerType = ListenerType.ErsNet;

                oBlobContainer = new ClientStorageBlobsContainer(OConnectionFactory, "connectionRemoteStorageAccount");
                oBlobContainer.Open(OConnectionFactory.getKeyValueString("Ers-Net-BlobContainer"));
                try
                {
                    oBlobContainer.testBlopContainer("Open Step");
                }
                catch (Exception ex)
                {
                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                 LaveryBusinessFunctions.eBusinessFunction.CatchNotification.ToString(),
                                                 OConnectionFactory.getKeyValueString("Environment"),
                                                 "Exception Catched on <" + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + "> : " + ex.Message,
                                                 OGuidContext.ToString(), SPrefixeName);
                }

                if (oGuid != default(Guid))
                    OGuidContext = oGuid;
                else
                    OGuidContext = Guid.NewGuid();
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  "Create object for receiving notifications (File full Path: " + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + ")...",
                                                  OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                 LaveryBusinessFunctions.eBusinessFunction.CatchNotification.ToString(),
                                                 OConnectionFactory.getKeyValueString("Environment"),
                                                 "Exception Catched on <" + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + "> : " + ex.Message,
                                                 OGuidContext.ToString(), SPrefixeName);

            }
        }
        protected override void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!Disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    
                }

                Disposed = true;
            }
        }
        private void performExistingFileEntry()
        {
            try
            {

                string[] fileEntries = Directory.GetFiles(OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory"));
                foreach (string fileName in fileEntries)
                {
                    Ers_Files_entry oTS = new Ers_Files_entry();
                    oTS.FilePath = fileName;
                    oTS.etypeEnvelopp = typeEnvelopp.Insert;
                    oTS.refGuid = Guid.NewGuid();
                    OStackEnvelopp.push(oTS);
                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.CollectExistingFile.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  "Collect existing notifications (File full Path: " + fileName + ")...",
                                                  OGuidContext.ToString(), SPrefixeName);
                }

                

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.CollectExistingFile.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Exception Catch : {0}\n{1}", 
                                                                            "Collect existing notifications (File full Path: " + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + ")...",
                                                                           ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
            }
        }
        public override void doConsistancy(String sStep)
        {
            try
            {
                oBlobContainer.testBlopContainer(sStep);
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.CatchNotification.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  "Exception Catch : " + ex.Message,
                                                  OGuidContext.ToString(), SPrefixeName);
            }
        }
        public override Boolean doInitialize()
        {
            Boolean bRet = true;
            try
            {
                

                performExistingFileEntry();
                oWatcher = new Lavery.Connector.FileSystemWatcher(OConnectionFactory, "Ers-Net-SourceDirectory", OGuidContext, SPrefixeName);
                oWatcher.NotifyFilter(OnCreated, OnChanged);

                isInitialized = true;


                Console.WriteLine("\t\t\tWaiting for receiving Files to process (File full Path: " + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + ")...");
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Waiting for receiving notifications (File full Path: " + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + ")...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.CatchNotification.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Exception Catch : " + ex.Message,
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }

        public override Boolean doJob()
        {
            Boolean bRet = true;

            try
            {
                
                Ers_Files_entry oTS = default(Ers_Files_entry);
                while ((oTS = (Ers_Files_entry)OStackEnvelopp.pop()) != default(Ers_Files_entry))
                {
                    try
                    {
                        Boolean bProcess = false;
                        //String sWithFileName = 
                        using (new SynchronizeGlobalInstance(IWaitOnMutex, OConnectionFactory.getKeyValueString("Ers-Net-Files-MutexGlobalValue")))
                        {
                            int iHashCode = LaveryReflection.getHashCode(oTS.FilePath);

                            if (File.Exists(oTS.FilePath))
                            {
                                if (ODataReferentialManagement.canProcessRequest(true,  iHashCode))
                                {
                                    Guid oGuid = Guid.NewGuid();
                                    ODataReferentialManagement.registerRequestProcessed(false,  iHashCode);
                                    bProcess = true;
                                }
                                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                            LaveryBusinessFunctions.eBusinessFunction.CollectExistingFile.ToString(),
                                                            OConnectionFactory.getKeyValueString("Environment"),
                                                            oSerializer.Serialize(oTS, Ers_Files_entry.XmlSerializerNamespaces, Encoding.UTF8),
                                                            oTS.refGuid.ToString(), SPrefixeName);

                                
                                if (bProcess)
                                {
                                    String sFileName = Path.GetFileName(oTS.FilePath);
                                    byte[] oByte = File.ReadAllBytes(oTS.FilePath);

                                    oBlobContainer.activeBlob(sFileName);
                                    oBlobContainer.Send(oByte);

                                    File.Delete(oTS.FilePath);
                                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                            LaveryBusinessFunctions.eBusinessFunction.CleaningExistingFile.ToString(),
                                                            OConnectionFactory.getKeyValueString("Environment"),
                                                            oSerializer.Serialize(oTS, Ers_Files_entry.XmlSerializerNamespaces, Encoding.UTF8),
                                                            oTS.refGuid.ToString(), SPrefixeName);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                    LaveryBusinessFunctions.eBusinessFunction.CatchNotification.ToString(),
                                                    OConnectionFactory.getKeyValueString("Environment"),
                                                    String.Format("Operation Falied : {0}\n{1}", oSerializer.Serialize(oTS, Ers_Files_entry.XmlSerializerNamespaces, Encoding.UTF8), ex.Message),
                                                    oTS.refGuid.ToString(), SPrefixeName);
                        bRet = false;
                    }
                }
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.PerformEntry.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Terminate for receiving notifications (File full Path: " + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + ")...", ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;

            return bRet;
        }
        public override Boolean doTerminate()
        {
            Boolean bRet = true;
            try
            {
                oBlobContainer.Close(false);
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Terminate.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Terminate for receiving notifications (File full Path: " + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + ")...",
                                                   OGuidContext.ToString(), SPrefixeName);
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerErsFileSystemWatcher.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Terminate.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Terminate for receiving notifications (File full Path: " + OConnectionFactory.getKeyValueString("Ers-Net-SourceDirectory") + ")...", ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }
        private Boolean OnChanged(Object sWithPath, String sJson)
        {
            Boolean bRet = true;
            try { }
            catch (Exception ex)
            {
                bRet = false;
            }
            return bRet;
        }

        private Boolean OnCreated(Object sWithPath, String sJson)
        {
            Boolean bRet = true;
            try 
            {
                Ers_Files_entry oTS = new Ers_Files_entry();
                oTS.FilePath = ((FileSystemEventArgs)sWithPath).FullPath;                
                oTS.etypeEnvelopp = typeEnvelopp.Insert;
                oTS.refGuid = Guid.NewGuid();
                OStackEnvelopp.push(oTS);
            }
            catch (Exception ex)
            {
                bRet = false;
            }
            return bRet;
        }

    }
}
