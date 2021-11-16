using System;
using System.Collections;
using System.Collections.Generic;

using Lavery.Tools.Configuration.Management;


namespace Lavery.azure.resources
{
    public enum peekMessageOptions { None, MessageId, CorrelId }
    public abstract class AzureBase : Object
    {
        
        connectionFactory oConnectionFactory;

        public delegate Boolean delegateFonction(Object oObjectMessage);

        public AzureBase(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
        }

        public connectionFactory OConnectionFactory { get => oConnectionFactory; set => oConnectionFactory = value; }

        public abstract Boolean Open(String sWithName);
        public abstract Boolean Close(Boolean bForDeletion);

        public virtual Guid Send(byte[] sMessage)
        {
            return default(Guid);
        }
        public virtual Guid Send(byte[] sMessage, String sMetadataKey, String sMetadataValue)
        {
            return default(Guid);
        }
        public virtual Guid Send(IEnumerable<byte[]> sMessage, Guid oCorrelId)
        {
            return default(Guid);
        }

        public virtual byte[] Receive()
        {
            return default(byte[]);
        }
        public virtual byte[] Receive(Guid iMsgId)
        {
            return default(byte[]);
        }
        public virtual byte[] Receive(String sMetadataKey, String sMetadataValue)
        {
            return default(byte[]);
        }


        public Guid ToGuid(long value)
        {
            byte[] guidData = new byte[16];
            Array.Copy(BitConverter.GetBytes(value), guidData, 8);
            return new Guid(guidData);
        }
        public virtual byte[] purgeMessages()
        {
            return default(byte[]);
        }
        public long ToLong(Guid guid)
        {
            if (BitConverter.ToInt64(guid.ToByteArray(), 8) != 0)
                throw new OverflowException("Value was either too large or too small for an Int64.");
            return BitConverter.ToInt64(guid.ToByteArray(), 0);
        }
        
    }
}

