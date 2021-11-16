using System;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using System.Collections.Generic;
using Lavery.Tools.Configuration.Management;

namespace Lavery.azure.resources
{
    public class ClientStorageBlobs : AzureBase
    {
        BlobClient oBlobClient = default(BlobClient);
        String sBlobContainer = default(String);
        public ClientStorageBlobs(connectionFactory oConnectionFactory, String sBlobContainer) : base(oConnectionFactory)
        {

            this.sBlobContainer = sBlobContainer;//string connectionString = ConfigurationManager.AppSettings["StorageConnectionString"];
            
        }
        public ClientStorageBlobs(BlobClient oBlobClient, connectionFactory oConnectionFactory, String sBlobContainer) : base(oConnectionFactory)
        {

            this.oBlobClient = oBlobClient;
            this.sBlobContainer = sBlobContainer;
           

        }
        public override Boolean Open(String sWithBlobName)
        {
            Boolean bRet = true;
            try
            {
                String sConnection = OConnectionFactory.ConnectionString("ConnectionRemoteStorageAccount");
                if (oBlobClient == default(BlobClient))
                    oBlobClient = new BlobClient(sConnection, sBlobContainer, sWithBlobName);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception catched : " + ex.Message);
                throw (ex);
            }
            return bRet;

        }

        public override Boolean Close(Boolean bForDeletion)
        {
            Boolean bRet = true;
            try
            {
                if (bForDeletion)
                    deleteBlob();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception catched : " + ex.Message);                
                throw (ex);
            }
            return bRet;

        }

        public Boolean deleteBlob()
        {
            Boolean bRet = true;
            try
            {
                if (oBlobClient.Exists())
                    oBlobClient.Delete();
                else
                    throw (new Exception(String.Format("The Storage Queue {0} does not exist...", oBlobClient.Name)));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception catched: {ex.Message}\n\n");
                throw (ex);                
            }
            return bRet;
        }
        public long GetBlobLength()
        {
            long lRet = -1;
            if (oBlobClient.Exists())
            {
                BlobProperties properties = oBlobClient.GetProperties();
                lRet = (int)properties.ContentLength;
            }
            return lRet;
        }
        public override byte[] Receive()
        {
            byte[] bRet = new byte[0];
            try
            {
                bRet = ReadToEnd(oBlobClient.OpenRead());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n\n");
                throw (ex);
            }
            return bRet;
        }
        public override byte[] Receive(Guid oGuid)
        {
            byte[] bRet = new byte[0];
            try
            {
                BlobProperties oProps = oBlobClient.GetProperties();

                if (ToGuid(oProps.BlobSequenceNumber) == oGuid)
                    if (oProps.BlobSequenceNumber == 0L)
                        bRet = ReadToEnd(oBlobClient.OpenRead());
                    else
                        bRet = Encoding.UTF8.GetBytes("Blob Page to be implemented");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n\n");
                throw (ex);
            }
            return bRet;
        }
        public override byte[] Receive(String sMetadataKey, String sMetadataValue)
        {
            byte[] bRet = Encoding.UTF8.GetBytes("a");
            try
            {
                BlobProperties oProps = oBlobClient.GetProperties();

                if (oProps.Metadata[sMetadataKey].Equals(sMetadataValue))
                    bRet = ReadToEnd(oBlobClient.OpenRead());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n\n");
                throw (ex);
            }
            return bRet;
        }



        public override Guid Send(byte[] sMessage, String sMetadataKey, String sMetadataValue)
        {
            Guid iMsgId = default(Guid);
            try
            {
                oBlobClient.DeleteIfExists();
                if (!oBlobClient.Exists())
                {
                    IDictionary<string, string> metadata = new Dictionary<string, string>();

                    iMsgId = ToGuid(oBlobClient.Upload(new MemoryStream(sMessage)).Value.BlobSequenceNumber);
                    metadata.Add(sMetadataKey, sMetadataValue);
                    oBlobClient.SetMetadataAsync(metadata);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n\n");
                throw (ex);
            }

            return iMsgId;
        }
        public override Guid Send(byte[] sMessage)
        {
            Guid iMsgId = default(Guid);
            try
            {
               
                oBlobClient.DeleteIfExists();               
                if (!oBlobClient.Exists())
                {
                    iMsgId = ToGuid(oBlobClient.Upload(new MemoryStream(sMessage)).Value.BlobSequenceNumber);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}\n\n");
                throw (ex);

            }

            return iMsgId;
        }
        public static byte[] ReadToEnd(System.IO.Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }

    }
}
