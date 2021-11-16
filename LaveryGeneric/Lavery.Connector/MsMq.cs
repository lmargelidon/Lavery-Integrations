using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Messaging;
using Lavery.Tools.Configuration.Management;

namespace Lavery.Connector
{
    public class MsMq <T>: ConnectorBase, IDisposable
    {
        MessageQueue rmQ = default(MessageQueue);
        private bool _disposedValue;
        private Boolean isTransactionnal;
        public MsMq(connectionFactory oConnectionFactory, String CinfigurationNameOfQueue, Boolean isTransactionnal = true) :base(oConnectionFactory)
        {
            try
            {
                this.isTransactionnal = isTransactionnal;
                CreateQueue(OConnectionFactory.getKeyValueString(CinfigurationNameOfQueue));                
            }
            catch (Exception ex)
            { 
            }
        }
        protected override void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!_disposedValue)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {
                    rmQ.Dispose();
                }

                _disposedValue = true;
            }
        }

        public String getQueueName() { return rmQ.QueueName;}
        public Boolean isTransactional() { return rmQ.Transactional; }

        public T receive(delegateFonction oDelegateAction)
        {
            T oRet = default(T);
            try 
            {
                if (rmQ == default(MessageQueue))
                    throw (new Exception("MSMQ not Accessible"));

                Object o = new Object();
                System.Type[] arrTypes = new System.Type[2];
                arrTypes[0] = typeof(T);
                arrTypes[1] = o.GetType();
                rmQ.Formatter = new XmlMessageFormatter(arrTypes);
                TimeSpan oTS = new TimeSpan(    OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutHours"),
                                                OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutMinutess"),
                                                OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutSecondes"));
                oRet = ((T)rmQ.Receive(oTS).Body);
                oDelegateAction(oRet, default(String));
                    

            }
            catch (Exception ex)
            {
                throw(ex);
            }

            return oRet;
        }
        public T receiveInTransaction(delegateFonction oDelegateAction)
        {
            T oRet = default(T);
            try
            {
                if (rmQ == default(MessageQueue))
                    throw (new Exception("MSMQ not Accessible"));

                Object o = new Object();
                System.Type[] arrTypes = new System.Type[2];
                arrTypes[0] = typeof(T);
                arrTypes[1] = o.GetType();
                rmQ.Formatter = new XmlMessageFormatter(arrTypes);
                TimeSpan oTS = TimeSpan.FromSeconds(OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutSecondes"));
                
                MessageQueueTransaction transaction = new MessageQueueTransaction();
                try
                {
                    transaction.Begin();

                    oRet = ((T)rmQ.Receive(oTS, transaction).Body);

                    oDelegateAction(oRet, default(String));
                    transaction.Commit();
                }
                catch (MessageQueueException e)
                {
                    transaction.Abort();
                    
                    throw e;
                    // Handle other sources of MessageQueueException.
                }
                catch (System.Exception e)
                {
                    // Cancel the transaction.
                    transaction.Abort();

                    // Propagate the exception.
                    throw e;
                }
                finally
                {
                    // Dispose of the transaction object.
                    transaction.Dispose();
                }

            }
            catch (Exception ex)
            {
            }

            return oRet;

        }
        public void send(delegateFonction oDelegateAction, String sMessage, T oObjectMessage)
        {
            
            try
            {
                if (rmQ == default(MessageQueue))
                    throw (new Exception("MSMQ not Accessible"));

                if (rmQ.Transactional == true)
                {
                    MessageQueueTransaction transaction = new  MessageQueueTransaction();
                    try
                    {
                        // Begin the transaction.
                        transaction.Begin();
                        oDelegateAction(oObjectMessage, sMessage);
                        // Send the message.
                        rmQ.Send(sMessage, transaction);

                        // Commit the transaction.
                        transaction.Commit();
                    }
                    catch (MessageQueueException e)
                    {
                        transaction.Abort();

                        throw e;
                        // Handle other sources of MessageQueueException.
                    }
                    catch (System.Exception e)
                    {
                        // Cancel the transaction.
                        transaction.Abort();

                        // Propagate the exception.
                        throw e;
                    }
                    finally
                    {
                        // Dispose of the transaction object.
                        transaction.Dispose();
                    }
                }
                else
                {
                    oDelegateAction(oObjectMessage, sMessage);
                    rmQ.Send(sMessage);
                }
            }
            catch (System.Exception e)
            {               
                throw e;
            }


        }
        public void CreateLocalePublicQueues(String sWithMessageQueue)
        {

            try
            {

                String sMessageQueue = String.Format(".\\{0}", sWithMessageQueue);
                CreateQueue(sMessageQueue);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return;
        }

        //**************************************************
        // Creates private queues and sends a message.
        //**************************************************

        public void CreateLocalePrivateQueues(String sWithMessageQueue)
        {
            try
            {
                String sMessageQueue = String.Format(".\\Private$\\{0}", sWithMessageQueue);
                CreateQueue(sMessageQueue);
            }
            catch (Exception ex)
            {
                throw (ex);
            }


        }
        public void CreateQueue(String sWithFullPathMessageQueue)
        {

            // Create and connect to a private Message Queuing queue.
            if (!MessageQueue.Exists(sWithFullPathMessageQueue))
                rmQ = MessageQueue.Create(sWithFullPathMessageQueue, true);
            else
                rmQ = new MessageQueue(sWithFullPathMessageQueue);
            

            return;
        }
    }
}
