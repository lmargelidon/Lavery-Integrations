using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Messaging;
using Lavery.Tools.Configuration.Management;
using Lavery.Tools;


namespace Lavery.Connector
{
    enum bodyFormater { None, Xml, BYnary}
    public class MsMq <T>: ConnectorBase, IDisposable
    {
        MessageQueue rmQ = default(MessageQueue);
        
        private bool _disposedValue;
        private Boolean isTransactionnal;
        private Boolean enlistInTransactionScope; 
        private bodyFormater ebodyFormater = bodyFormater.BYnary;
        jsonSerializer<T> oSerializer = new jsonSerializer<T>();

        public MsMq(connectionFactory oConnectionFactory, String ConfigurationNameOfQueue, Boolean isTransactionnal = true, Boolean enlistInTransactionScope = false) :base(oConnectionFactory)
        {
            try
            {
                this.isTransactionnal = isTransactionnal;
                this.enlistInTransactionScope = enlistInTransactionScope;
                
                CreateQueue(OConnectionFactory.getKeyValueString(ConfigurationNameOfQueue));                
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
                    if (!enlistInTransactionScope && rmQ != default(MessageQueue))
                        rmQ.Dispose();
                }

                _disposedValue = true;
            }
        }

        public String getQueueName() { return rmQ.QueueName ;}
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
                if(ebodyFormater == bodyFormater.Xml)
                    rmQ.Formatter = new XmlMessageFormatter(arrTypes);
                TimeSpan oTS = new TimeSpan(    OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutHours"),
                                                OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutMinutess"),
                                                OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutSecondes"));
               
                if (ebodyFormater == bodyFormater.Xml)
                    oRet = ((T)rmQ.Receive(oTS).Body);                
                else
                {
                    Message oMsg = rmQ.Receive(oTS);
                    oRet = oSerializer.deserialize((string)oMsg.Body);
                }


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
                if (!enlistInTransactionScope)
                {
                    if (rmQ == default(MessageQueue))
                        throw (new Exception("MSMQ not Accessible"));

                    if (ebodyFormater == bodyFormater.Xml)
                    {
                        Object o = new Object();
                        System.Type[] arrTypes = new System.Type[2];
                        arrTypes[0] = typeof(T);
                        arrTypes[1] = o.GetType();
                        rmQ.Formatter = new XmlMessageFormatter(arrTypes);
                    }
                    else
                        rmQ.Formatter = new BinaryMessageFormatter();

                    TimeSpan oTS = TimeSpan.FromSeconds(OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutSecondes"));

                    MessageQueueTransaction transaction = new MessageQueueTransaction();
                    try
                    {
                        transaction.Begin();
                        if (ebodyFormater == bodyFormater.Xml)
                            oRet = ((T)rmQ.Receive(oTS, transaction).Body);
                        else
                        {
                            Message oMsg = rmQ.Receive(oTS, transaction);
                            oRet = oSerializer.deserialize((string)oMsg.Body);
                        }


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
            }
            catch (Exception ex)
            {
            }

            return oRet;

        }
        public T receiveInTransaction()
        {
            T oRet = default(T);
            try
            {
                if (enlistInTransactionScope && rmQ.Transactional == true)
                {

                    if (ebodyFormater == bodyFormater.Xml)
                    {
                        Object o = new Object();
                        System.Type[] arrTypes = new System.Type[2];
                        arrTypes[0] = typeof(T);
                        arrTypes[1] = o.GetType();
                        rmQ.Formatter = new XmlMessageFormatter(arrTypes);
                    }
                    else
                        rmQ.Formatter = new BinaryMessageFormatter();

                    TimeSpan oTS = TimeSpan.FromSeconds(OConnectionFactory.getKeyValueInt("AssiduiteQueueTimeOutSecondes"));

                    
                    if (ebodyFormater == bodyFormater.Xml)
                        oRet = ((T)rmQ.Receive(oTS, MessageQueueTransactionType.Automatic).Body );
                    else
                    {
                        Message oMsg = rmQ.Receive(oTS, MessageQueueTransactionType.Automatic);
                        oRet = oSerializer.deserialize((string)oMsg.Body);
                    }

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
                if (!enlistInTransactionScope)
                {
                    if (rmQ == default(MessageQueue))
                        throw (new Exception("MSMQ not Accessible"));

                    if (rmQ.Transactional == true)
                    {
                        MessageQueueTransaction transaction = new MessageQueueTransaction();
                        try
                        {
                            // Begin the transaction.
                            transaction.Begin();
                            oDelegateAction(oObjectMessage, sMessage);
                            if (ebodyFormater == bodyFormater.Xml)
                            {
                                Object o = new Object();
                                System.Type[] arrTypes = new System.Type[2];
                                arrTypes[0] = typeof(T);
                                arrTypes[1] = o.GetType();
                                rmQ.Formatter = new XmlMessageFormatter(arrTypes);
                            }
                            else
                                rmQ.Formatter = new BinaryMessageFormatter();
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
            }
            catch (System.Exception e)
            {               
                throw e;
            }


        }
        public void send(String sMessage, T oObjectMessage)
        {
            try
            {
                if (enlistInTransactionScope && rmQ.Transactional)
                {
                    if (ebodyFormater == bodyFormater.Xml)
                    {
                        Object o = new Object();
                        System.Type[] arrTypes = new System.Type[2];
                        arrTypes[0] = typeof(T);
                        arrTypes[1] = o.GetType();
                        rmQ.Formatter = new XmlMessageFormatter(arrTypes);
                    }
                    else
                        rmQ.Formatter = new BinaryMessageFormatter();

                    rmQ.Send(sMessage, MessageQueueTransactionType.Automatic);

                }
            }
            catch (Exception ex)
            {
                throw (ex);
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
