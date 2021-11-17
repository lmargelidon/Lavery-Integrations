using System;
using System.Text;
using Lavery.Listeners;
using System.Data;
using System.Data.SqlClient;
using Lavery.Schemas.E3;
using Lavery.Connector;
using Lavery.Schemas;
using Lavery.Tools;
using Lavery.Events.Listeners;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;

namespace Lavery.Listeners
{
    public class MsMqTimeCardEvents : ListenerAssiduityBase
    {

        MsMq<TimeCard> oMq;
        jsonSerializer<TimeCard> oSerializer = new jsonSerializer<TimeCard>();

        public MsMqTimeCardEvents(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory)
        {
            try
            {
                this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
                OGuidContext = Guid.NewGuid();
                this.oSerializer = new jsonSerializer<TimeCard>();
                this.SPrefixeName = SPrefixeName;
                if (oGuid != default(Guid))
                    OGuidContext = oGuid;
                else
                    OGuidContext = Guid.NewGuid();
               
            }
            catch (Exception ex)
            {

            }
        }

        public Boolean performTransaction(Object oObjectMessage, String sJcon)
        {
            Boolean bRet = true;
            try
            {
                switch (((TimeCard)oObjectMessage).etypeEnvelopp)
                {
                    case typeEnvelopp.Insert:
                        insertAssiduity((TimeCard)oObjectMessage);
                        break;
                    case typeEnvelopp.Update:
                        updatetAssiduity((TimeCard)oObjectMessage);
                        break;
                    case typeEnvelopp.Delete:
                        deleteAssiduity((TimeCard)oObjectMessage);
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
        }

        protected override void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!Disposed)
            {   
                if (disposing)
                {
                    oMq.Dispose();
                }

                Disposed = true;
            }
        }
        public override Boolean doInitialize()
        {
            Boolean bRet = true;
            try
            {

                oMq = new MsMq<TimeCard>(OConnectionFactory, "AssiduiteValidateQueue");


                Console.WriteLine("\t\t\tInitializing listener on MsMq : (" + oMq.getQueueName() + ")...");
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Listen on the queue (naming: " + oMq.getQueueName() + ")...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen on the queue (naming: " + oMq.getQueueName() + ")...", ex.Message),
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
                TimeCard oTS = default(TimeCard);

                if (oMq.isTransactional())
                    oTS = oMq.receiveInTransaction(performTransaction);
                else
                    oTS = oMq.receive(performTransaction);


            }
            catch (Exception ex)
            {
                bRet = false;
            }
            return bRet;
        }
        public override Boolean doTerminate()
        {
            Boolean bRet = true;
            try
            {
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   "Listen on the queue Stopped (naming: " + oMq.getQueueName() + ")...",
                                                   OGuidContext.ToString(), SPrefixeName);

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OConnectionFactory.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen on the queue (naming: " + oMq.getQueueName() + ")...", ex.Message),
                                                   OGuidContext.ToString(), SPrefixeName);
                bRet = false;
            }
            return bRet;
        }

        private int insertAssiduity(TimeCard oTimeCard)
        {
            int iRet = default(int);
            try
            {

                using (var command = new SqlCommand("[dbo].[absence__insert_bis]", OConnectionTarget))
                {
                    /*
                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    executePersistAssiduity(command, oTimeCard);

                    var result = returnParameter.Value;

                    int iVal = ODataReferentialManagement.registerLink(Convert.ToInt32(oTimeCard.id_origine), (int)result, oTimeCard.group_id);

                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.InsertAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("{0}", oSerializer.Serialize(oTimeCard)),
                                                  oTimeCard.group_id.ToString(), SPrefixeName);
                    */
                }
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.InsertAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("Operation Falied : {0}\n{1}", oSerializer.serialize(oTimeCard), ex.Message),
                                                  oTimeCard.refGuid.ToString(), SPrefixeName);
                Console.WriteLine(ex.Message);
                throw (ex);
            }
            return iRet;
        }
        private int updatetAssiduity(TimeCard oTimeCard)
        {
            int iRet = default(int);
            try
            {

                /*
                int iUpdateKey = ODataReferentialManagement.getLinkAssiduityId(Convert.ToInt32(oTimeCard.id_origine));

                if (iUpdateKey > 0)
                    using (var command = new SqlCommand("[dbo].[absence__update]", OConnectionTarget))
                    {
                        command.Parameters.Add(new SqlParameter("@TimeCard_ID", iUpdateKey));

                        executePersistAssiduity(command, oTimeCard, true);
                        persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.UpdateAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("{0}", oSerializer.Serialize(oTimeCard)),
                                                  oTimeCard.group_id.ToString(), SPrefixeName);

                    }
                else
                    throw (new Exception(String.Format("Update failure no corresponding id <{0}> found in the referential link", oTimeCard.id_origine)));
                */
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.UpdateAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("Operation Falied : {0}\n{1}", oSerializer.serialize(oTimeCard), ex.Message),
                                                  oTimeCard.refGuid.ToString(), SPrefixeName);
                Console.WriteLine(ex.Message);
                throw (ex);
            }
            return iRet;
        }
        private int executePersistAssiduity(SqlCommand command, TimeCard oTimeCard, Boolean is_forUpdate = false)
        {
            int iRet = -1;
            try
            {/*
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@user_id", oTimeCard.user_id));
                command.Parameters.Add(new SqlParameter("@absence_type_id", oTimeCard.absence_type_id));
                //command.Parameters.Add(new SqlParameter("@absence_type_id", 2));
                if (oTimeCard.date_from.Year > 2020)
                    command.Parameters.Add(new SqlParameter("@date_from", oTimeCard.date_from));
                if (oTimeCard.date_to.Year > 2020)
                    command.Parameters.Add(new SqlParameter("@date_to", oTimeCard.date_to));
                command.Parameters.Add(new SqlParameter("@nb_hours", oTimeCard.nb_hours));
                command.Parameters.Add(new SqlParameter("@nb_days", oTimeCard.nb_days));
                command.Parameters.Add(new SqlParameter("@is_approved", oTimeCard.is_approved));
                command.Parameters.Add(new SqlParameter("@absence_ref", oTimeCard.absence_ref));
                command.Parameters.Add(new SqlParameter("@group_id", oTimeCard.group_id));
                command.Parameters.Add(new SqlParameter("@schedule_bitmask", oTimeCard.schedule_Bitmask));
                command.Parameters.Add(new SqlParameter("@comment", oTimeCard.comment));
                command.Parameters.Add(new SqlParameter("@comment2", oTimeCard.comment2 != default(String) ? oTimeCard.comment2 : ""));
                command.Parameters.Add(new SqlParameter("@is_adjustment", oTimeCard.is_adjustment));


                if (is_forUpdate)
                {
                    if (oTimeCard.date_received.Year > 2020)
                        command.Parameters.Add(new SqlParameter("@date_received", oTimeCard.date_received));
                    if (oTimeCard.date_approved.Year > 2020)
                        command.Parameters.Add(new SqlParameter("@date_approved", oTimeCard.date_approved));

                    command.Parameters.Add(new SqlParameter("@is_exception", oTimeCard.is_exception));
                    command.Parameters.Add(new SqlParameter("@is_invisible", oTimeCard.is_invisible));
                    command.Parameters.Add(new SqlParameter("@is_cancel", oTimeCard.is_cancel));
                    command.Parameters.Add(new SqlParameter("@is_denied", oTimeCard.is_denied));

                    command.Parameters.Add(new SqlParameter("@is_pending_cancel", oTimeCard.is_pending_cancel));
                    command.Parameters.Add(new SqlParameter("@is_supervisor_approved", oTimeCard.is_supervisor_approved));
                    if (oTimeCard.date_cancellation.Year > 2020)
                        command.Parameters.Add(new SqlParameter("@date_cancellation", oTimeCard.date_cancellation));
                    command.Parameters.Add(new SqlParameter("@denied_reason", oTimeCard.denied_reason));

                    command.Parameters.Add(new SqlParameter("@is_deleted", oTimeCard.is_deleted));
                }

                iRet = command.ExecuteNonQuery();
                */
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.PerformEntry.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("Exception catched {0}:\n{1}", command.CommandText, ex.Message),
                                                  oTimeCard.refGuid.ToString(), SPrefixeName);
                throw (ex);
            }
            return iRet;
        }
        private int deleteAssiduity(TimeCard oTimeCard)
        {
            int iRet = default(int);
            try
            {
                /*
                int iUpdateKey = ODataReferentialManagement.getLinkAssiduityId(Convert.ToInt32(oTimeCard.id_origine));
                if (iUpdateKey > 0)
                    using (var command = new SqlCommand("[dbo].[absence__delete]", OConnectionTarget))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TimeCard_ID", iUpdateKey));
                        iRet = command.ExecuteNonQuery();
                        ODataReferentialManagement.deleteLink(Convert.ToInt32(oTimeCard.id_origine));
                        persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                       LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                                                       OConnectionFactory.getKeyValueString("Environment"),
                                                       String.Format("{0}", oSerializer.Serialize(oTimeCard)),
                                                       oTimeCard.group_id.ToString(), SPrefixeName);

                    }
                else
                    throw (new Exception(String.Format("Delete failure no corresponding id <{0}> found in the referential link", oTimeCard.id_origine)));
                */

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                 LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                                                 OConnectionFactory.getKeyValueString("Environment"),
                                                 String.Format("Operation Falied : {0}\n{1}", oSerializer.serialize(oTimeCard), ex.Message),
                                                 oTimeCard.refGuid.ToString(), SPrefixeName);
                throw (ex);
            }
            return iRet;
        }
    }
}
