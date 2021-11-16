using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Collections;


namespace Lavery.Listeners
{
    public enum mediumType { None, Esb, Mq, StorageQueue, BlobStorageReceiver, BlobStorageSender }

    [DataContract]
    public class functionPayload
    {
        [DataMember(Name = "MediumType")]
        mediumType eMediumType { get; set; }


        [DataMember(Name = "Guid")]
        Guid oGuid { get; set; }

        [DataMember(Name = "ConnectionString")]
        String oConnectionString { get; set; }

        [DataMember(Name = "CanalName")]
        String oCanalName { get; set; }

        [DataMember(Name = "ContainerName")]
        String oContainerName { get; set; }


        [DataMember(Name = "CanalNameReceiver")]
        String oCanalNameReceiver { get; set; }

        [DataMember(Name = "ContainerNameReceiver")]
        String oContainerNameReceiver { get; set; }


        [DataMember(Name = "SenderCorrelKey")]
        String oSenderCorrelKey { get; set; }

        [DataMember(Name = "SenderCorrelValue")]
        String oSenderCorrelValue { get; set; }

        [DataMember(Name = "ReceiverCorrelKey")]
        String oReceiverCorrelKey { get; set; }

        [DataMember(Name = "ReceiverCorrelValue")]
        String oReceiverCorrelValue { get; set; }

        [DataMember(Name = "DeleteCanal")]
        Boolean bDeleteCanal { get; set; }

        [DataMember(Name = "Content")]
        byte[] byteContent { get; set; }

        [DataMember(Name = "MaxWaitTime")]
        int iMaxWaitTime { get; set; }

        [DataMember(Name = "UseGuidToPeekUpMessage")]
        Boolean bUseGuidToPeekUpMessage { get; set; }

        /*-----------------------------------------*/
        public int IMaxWaitTime()
        {
            return iMaxWaitTime;
        }
        public void IMaxWaitTime(int iMaxWaitTime)
        {
            this.iMaxWaitTime = iMaxWaitTime;
        }
        /*-----------------------------------------*/
        public Boolean BUseGuidToPeekUpMessage()
        {
            return bUseGuidToPeekUpMessage;
        }
        public void BUseGuidToPeekUpMessage(Boolean bUseGuidToPeekUpMessage)
        {
            this.bUseGuidToPeekUpMessage = bUseGuidToPeekUpMessage;
        }

        /*-----------------------------*/
        public mediumType EMediumType()
        {
            return eMediumType;
        }
        public void EMediumType(mediumType eMediumType)
        {
            this.eMediumType = eMediumType;
        }

        /*-----------------------------*/
        public byte[] ByteContent()
        {
            return byteContent;
        }
        public void ByteContent(byte[] byteContent)
        {
            this.byteContent = byteContent;
        }
        /*-----------------------------*/
        public Guid OGuid()
        {
            return oGuid;
        }
        public void OGuid(Guid oGuid)
        {
            this.oGuid = oGuid;
        }
        /*-----------------------------*/

        public String OConnectionString()
        {
            return oConnectionString;
        }
        public void OConnectionString(String oConnectionString)
        {
            this.oConnectionString = oConnectionString;
        }
        /*-----------------------------*/
        public String OCanalName()
        {
            return oCanalName;
        }
        public void OCanalName(String oCanalName)
        {
            this.oCanalName = oCanalName;
        }
        /*-----------------------------*/
        public String OContainerName()
        {
            return oContainerName;
        }
        public void OContainerName(String oContainerName)
        {
            this.oContainerName = oContainerName;
        }
        /// <summary>
        /// ////////////////////////////////////////////////////
        public String OCanalNameReceiver()
        {
            return oCanalNameReceiver;
        }
        public void OCanalNameReceiver(String oCanalNameReceiver)
        {
            this.oCanalNameReceiver = oCanalNameReceiver;
        }
        /*-----------------------------*/
        public String OContainerNameReceiver()
        {
            return oContainerNameReceiver;
        }
        public void OContainerNameReceiver(String oContainerNameReceiver)
        {
            this.oContainerNameReceiver = oContainerNameReceiver;
        }

        public String OSenderCorrelKey()
        {
            return oSenderCorrelKey;
        }
        public void OSenderCorrelKey(String oSenderCorrelKey)
        {
            this.oSenderCorrelKey = oSenderCorrelKey;
        }
        public String OReceiverCorrelKey()
        {
            return oReceiverCorrelKey;
        }
        public void OReceiverCorrelKey(String oReceiverCorrelKey)
        {
            this.oReceiverCorrelKey = oReceiverCorrelKey;
        }
        ///
        public String OSenderCorrelValue()
        {
            return oSenderCorrelValue;
        }
        public void OSenderCorrelValue(String oSenderCorrelValue)
        {
            this.oSenderCorrelValue = oSenderCorrelValue;
        }
        public String OReceiverCorrelValue()
        {
            return oReceiverCorrelValue;
        }
        public void OReceiverCorrelValue(String oReceiverCorrelValue)
        {
            this.oReceiverCorrelValue = oReceiverCorrelValue;
        }
        ////// 
        /// </summary>
        /// <returns></returns>

        /*-----------------------------*/
        public Boolean BDeleteCanal()
        {
            return bDeleteCanal;
        }
        public void BDeleteCanal(Boolean bDeleteCanal)
        {
            this.bDeleteCanal = bDeleteCanal;
        }

        static public String builder(functionPayload oObjet)
        {

            String sContant = JsonConvert.SerializeObject(oObjet);

            return sContant;
        }
        static public functionPayload builder(string jsonBack)
        {
            functionPayload oObject = null;
            oObject = (functionPayload)JsonConvert.DeserializeObject<functionPayload>(jsonBack);
            return oObject;
        }
    }
}

