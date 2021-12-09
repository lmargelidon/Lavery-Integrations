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
using Newtonsoft.Json.Linq;

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

                TimeCard oRet = (TimeCard)oObjectMessage;
                switch (((TimeCard)oObjectMessage).etypeEnvelopp)
                {
                    case typeEnvelopp.Insert:
                        insertAssiduity(oRet);
                        break;
                    case typeEnvelopp.Update:
                        updatetAssiduity(oRet);
                        break;
                    case typeEnvelopp.Delete:
                        deleteAssiduity((TimeCard)oObjectMessage);
                        break;
                    default:
                        bRet = false;
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
        /*
         
         Specifiques....
         */
          
        private int insertAssiduity(TimeCard oTimeCard)
        {
            int iRet = default(int);
            try
            {

                using (var command = new SqlCommand("[dbo].[absence__insert_bis]", OConnectionTarget))
                {
                    
                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    executePersistAssiduity(command, oTimeCard);

                    var result = returnParameter.Value;

                    int iVal = ODataReferentialManagement.registerLink(oTimeCard.TimecardID, (int)result, oTimeCard.refGuid);

                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.InsertAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("{0}", oSerializer.serialize(oTimeCard)),
                                                  oTimeCard.refGuid.ToString(), SPrefixeName);
                    
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

               
                int iUpdateKey = ODataReferentialManagement.getLinkAssiduityId(Convert.ToInt32(oTimeCard.TimecardID));

                if (iUpdateKey > 0)
                    using (var command = new SqlCommand("[dbo].[absence__update]", OConnectionTarget))
                    {
                        command.Parameters.Add(new SqlParameter("@TimeCard_ID", iUpdateKey));

                        executePersistAssiduity(command, oTimeCard, true);
                        persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.UpdateAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("{0}", oSerializer.serialize(oTimeCard)),
                                                  oTimeCard.refGuid.ToString(), SPrefixeName);

                    }
                else
                    throw (new Exception(String.Format("Update failure no corresponding id <{0}> found in the referential link", oTimeCard.TimecardID)));
               
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
            {
                
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@user_id", oTimeCard.Timekeeper));
                command.Parameters.Add(new SqlParameter("@absence_type_id", 2)); //???????????????                
                if (oTimeCard.WorkDate.Year > 2020)
                {
                    command.Parameters.Add(new SqlParameter("@date_from", oTimeCard.WorkDate));
                    command.Parameters.Add(new SqlParameter("@date_to", oTimeCard.WorkDate));
                }
                //??????????????????????????????
                if (oTimeCard.TimeType.Equals("Hourly", StringComparison.CurrentCultureIgnoreCase))
                {
                    command.Parameters.Add(new SqlParameter("@nb_hours", oTimeCard.WorkHrs));
                    command.Parameters.Add(new SqlParameter("@nb_days", (int)Math.Ceiling((double)oTimeCard.WorkHrs / (double)8) ));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@nb_hours", oTimeCard.WorkHrs));
                    command.Parameters.Add(new SqlParameter("@nb_days",  (int)Math.Ceiling((double)oTimeCard.WorkHrs / (double)8)));
                }
                //??????????????????????????????
                command.Parameters.Add(new SqlParameter("@is_approved", true));
                command.Parameters.Add(new SqlParameter("@is_adjustment", false)); //???????????????
                command.Parameters.Add(new SqlParameter("@absence_ref", 500)); //?????????????????
                command.Parameters.Add(new SqlParameter("@group_id", oTimeCard.refGuid));
                command.Parameters.Add(new SqlParameter("@schedule_bitmask", 1));  //?????????????????
                command.Parameters.Add(new SqlParameter("@comment", oTimeCard.Narrative_UnformattedText));
                command.Parameters.Add(new SqlParameter("@comment2", oTimeCard.InternalComments != default(String) ? oTimeCard.InternalComments : ""));
                


                if (is_forUpdate)
                {
                    if (oTimeCard.WorkDate.Year > 2020)
                    {
                        command.Parameters.Add(new SqlParameter("@date_from", oTimeCard.WorkDate));
                        command.Parameters.Add(new SqlParameter("@date_to", oTimeCard.WorkDate));
                    }

                    command.Parameters.Add(new SqlParameter("@is_exception", false));   //???????????
                    command.Parameters.Add(new SqlParameter("@is_invisible", false)); //???????????
                    command.Parameters.Add(new SqlParameter("@is_cancel", false));  //???????????
                    command.Parameters.Add(new SqlParameter("@date_from", oTimeCard.WorkDate));
                    command.Parameters.Add(new SqlParameter("@date_to", oTimeCard.WorkDate));
                }
                /*
                command.Parameters.Add(new SqlParameter("@is_denied", false)); //???????????

                command.Parameters.Add(new SqlParameter("@is_pending_cancel", false)); //???????????
                command.Parameters.Add(new SqlParameter("@is_supervisor_approved", true));
                    
                command.Parameters.Add(new SqlParameter("@denied_reason", false));

                command.Parameters.Add(new SqlParameter("@is_deleted", false));
                */

                iRet = command.ExecuteNonQuery();

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
                
                int iUpdateKey = ODataReferentialManagement.getLinkAssiduityId(Convert.ToInt32(oTimeCard.TimecardID));
                if (iUpdateKey > 0)
                    using (var command = new SqlCommand("[dbo].[absence__delete]", OConnectionTarget))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TimeCard_ID", iUpdateKey));
                        iRet = command.ExecuteNonQuery();
                        ODataReferentialManagement.deleteLink(Convert.ToInt32(oTimeCard));
                        persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                       LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                                                       OConnectionFactory.getKeyValueString("Environment"),
                                                       String.Format("{0}", oSerializer.serialize(oTimeCard)),
                                                       oTimeCard.refGuid.ToString(), SPrefixeName);

                    }
                else
                    throw (new Exception(String.Format("Delete failure no corresponding id <{0}> found in the referential link", oTimeCard.TimecardID)));
               

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
