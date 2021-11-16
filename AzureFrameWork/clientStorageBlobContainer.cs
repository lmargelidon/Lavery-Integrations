using System;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using System.Collections.Generic;
using Lavery.Tools.Configuration.Management;

namespace Lavery.azure.resources
{
    public class ClientStorageBlobsContainer : AzureBase
    {
        
        BlobContainerClient oBlobContainer = default(BlobContainerClient);
        ClientStorageBlobs oActiveClientStorageBlobs = default(ClientStorageBlobs);
        String sStorageAccountName; 

        public String Name()
        {
            return oBlobContainer.Name;
        }
        
        public ClientStorageBlobsContainer(connectionFactory oConnectionFactory, String sWithStorageAccountName) : base(oConnectionFactory)
        {

            this.sStorageAccountName = sWithStorageAccountName;            

        }
        
        public override Boolean Open(String sWithName)
        {
            Boolean bRet = true;
            try
            {
                oBlobContainer = new BlobContainerClient(OConnectionFactory.ConnectionString(sStorageAccountName), sWithName.ToLower().Replace("-","."));
                bRet = createBlobContainer();
                                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception catched : " + ex.Message);
                throw (ex);
            }
            return bRet;

        }
        public void testBlopContainer(String sAtStep)
        {
            if (oBlobContainer == default(BlobContainerClient))
                throw (new Exception(String.Format("BlobContainer {0} is Null", sAtStep)));
        }
        public override Boolean Close(Boolean bForDeletion)
        {
            Boolean bRet = true;
            try
            {
                if (bForDeletion)
                    deleteBlobContainer();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception catched : " + ex.Message);
                throw (ex);
            }
            return bRet;

        }
        private Boolean createBlobContainer()
        {
            Boolean bRet = true;
            try
            {

                oBlobContainer.CreateIfNotExists();

                if (!oBlobContainer.Exists())
                {
                    Console.WriteLine($"Make sure the Azurite storage emulator running and try again.");
                    bRet = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception catched: {ex.Message}\n\n");
                throw (ex);
            }
            return bRet;
        }
        public ClientStorageBlobs activeBlob(String sWithName)
        {
            oActiveClientStorageBlobs = default(ClientStorageBlobs);
            try
            {
                
                if (oBlobContainer.Exists())
                {    
                    
                    oBlobContainer.DeleteBlobIfExists(sWithName);
                    
                    BlobClient oActiveblobClient = oBlobContainer.GetBlobClient(sWithName.ToLower().Replace("-", "_"));
                    if (oActiveblobClient == default(BlobClient))
                        throw (new Exception(String.Format("Blob Client {0} not created", sWithName.ToLower().Replace("-", "."))));

                    oActiveClientStorageBlobs = new ClientStorageBlobs(oActiveblobClient, OConnectionFactory, Name());
                    if (oActiveClientStorageBlobs == default(ClientStorageBlobs))
                        throw (new Exception(String.Format("Active BlobClient {0} not working", sWithName.ToLower().Replace("-", "."))));
                    
                }
                else
                {
                    Console.WriteLine($"Make sure the Azurite storage emulator running and try again.");

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception catched: {ex.Message}\n\n");
                throw (ex);

            }
            return oActiveClientStorageBlobs;
        }
        
        public Boolean deleteBlobContainer()
        {
            Boolean bRet = true;
            try
            {
                if (oBlobContainer.Exists())
                    oBlobContainer.Delete();
                else
                    throw (new Exception(String.Format("The Storage  {0} does not exist...", oBlobContainer.Name)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception catched: {ex.Message}\n\n");                
                throw (ex);
            }
            return bRet;
        }

        public int Count()
        {
            int iRet = -1;
            if (oBlobContainer.Exists())
            {
                foreach (BlobItem blob in oBlobContainer.GetBlobs())
                {
                    iRet++;
                }

            }
            return iRet;
        }
        public Boolean BlobExists(String sBlobName)
        {
            Boolean bRet = false;
            if (oBlobContainer.Exists())
            {
                foreach (BlobItem blob in oBlobContainer.GetBlobs())
                    if (blob.Name.Equals(sBlobName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        bRet = true;
                        break;
                    }
             
            }
            return bRet;
        }
        public Boolean deleteBlobIfExists(String sBlobName)
        {
            Boolean bRet = false;
            if (oBlobContainer.Exists())
            {
                foreach (BlobItem blob in oBlobContainer.GetBlobs())
                    if (blob.Name.Equals(sBlobName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        bRet = true;
                        
                        break;
                    }

            }
            return bRet;
        }
        public override byte[] Receive(Guid oGuid)
        {
            byte[] bRet = new byte[0];
            try
            {
                if (oBlobContainer.Exists())
                {
                    String sConnString = OConnectionFactory.ConnectionString("ConnectionSource");
                    BlobServiceClient blobServiceClient = new BlobServiceClient(sConnString);
                    BlobContainerClient clientForIndividualContainer = blobServiceClient.GetBlobContainerClient(oBlobContainer.Name);
                    foreach (BlobItem blob in oBlobContainer.GetBlobs())
                    {
                        BlobClient blobClient = clientForIndividualContainer.GetBlobClient(blob.Name);
                        if (ToGuid(blobClient.GetProperties().Value.BlobSequenceNumber) == oGuid)
                        {
                            ClientStorageBlobs pSB = new ClientStorageBlobs(blobClient, OConnectionFactory, oBlobContainer.Name);
                            bRet = pSB.Receive(oGuid);
                            break;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n\n");
                throw (ex);

            }
            return bRet;
        }


        public override Guid Send(byte[] sMessage)
        {
            Guid iMsgId = default(Guid);
            try
            {
                if (oActiveClientStorageBlobs != default(ClientStorageBlobs))
                    iMsgId = oActiveClientStorageBlobs.Send(sMessage);
                else
                    throw (new Exception("No active ClientStorageBlobs available..."));

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n\n");
                throw (ex);

            }

            return iMsgId;
        }
       

    }
}
