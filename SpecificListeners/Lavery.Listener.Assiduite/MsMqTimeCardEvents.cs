using System;
using System.Collections.Generic;
using System.Transactions;
using System.Threading;
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
        List<TimeTypeMapping> lTimeType = new List<TimeTypeMapping>(); 

        public MsMqTimeCardEvents(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory)
        {
            try
            {
                this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
                OGuidContext = Guid.NewGuid();
                this.oSerializer = new jsonSerializer<TimeCard>();
                this.SPrefixeName = SPrefixeName;
                ODataReferentialManagement.EListenerType = ListenerType.TimeCard;

                if (oGuid != default(Guid))
                    OGuidContext = oGuid;
                else
                    OGuidContext = Guid.NewGuid();

                String [] aTimeTypes = OConnectionFactory.getKeyValueString("AssiduiteTimeTypeMapping").Split(';');
                foreach (String sTimeType in aTimeTypes)
                    lTimeType.Add(new TimeTypeMapping(sTimeType));

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
                isInitialized = true;

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
            Boolean bInsideTrx = false;
            try
            {                
                TimeCard oTS = default(TimeCard);
                /*
                if (oMq.isTransactional())
                    oTS = oMq.receiveInTransaction(performTransaction);
                else
                    oTS = oMq.receive(performTransaction);
                */
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection oConnectionReferentialTrx = new SqlConnection(OConnectionFactory.ConnectionString("ConnectionReferential")))
                    using (SqlConnection oConnectionTargetTrx = new SqlConnection(OConnectionFactory.ConnectionString("ConnectionTarget")))
                    using (MsMq<TimeCard> oMsMq = new MsMq<TimeCard>(OConnectionFactory, "AssiduiteValidateQueue", true, true))
                    {
                        
                        oTS = oMsMq.receiveInTransaction();
                        if (oTS != null && oTS.WorkHrs > 0)
                        {
                            bInsideTrx = true;
                            oConnectionReferentialTrx.Open();
                            oConnectionTargetTrx.Open();
                            switch (oTS.etypeEnvelopp)
                            {
                                case typeEnvelopp.Insert:
                                    insertAssiduity(oTS, oConnectionTargetTrx, oConnectionReferentialTrx);
                                    break;
                                case typeEnvelopp.Update:
                                    updatetAssiduity(oTS, oConnectionTargetTrx, oConnectionReferentialTrx);
                                    break;
                                case typeEnvelopp.Delete:
                                    deleteAssiduity(oTS, oConnectionTargetTrx, oConnectionReferentialTrx);
                                    break;
                                default:
                                    bRet = false;
                                    break;                               
                            }
                            /*
                            if (BAleatoirExceptionGeneration)
                                if(ORandomException.Next(10) > 5)
                                    throw (new Exception("Aleatoire exception generated..."));
                         */

                        }
                        else
                            Thread.Sleep(5000);
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                TimeCard oTS = default(TimeCard);
                if (bInsideTrx)
                {
                   
                    using (TransactionScope scope = new TransactionScope())
                    {
                        using (MsMq<TimeCard> oMsMqDlq = new MsMq<TimeCard>(OConnectionFactory, "AssiduiteValidateDLQRead", true, true))
                        using (MsMq<TimeCard> oMsMq = new MsMq<TimeCard>(OConnectionFactory, "AssiduiteValidateQueue", true, true))
                        {

                            oTS = oMsMq.receiveInTransaction();
                            if (oTS != default(TimeCard))
                            {
                                String sMessageOut = oSerializer.serialize(oTS);
                                oMsMqDlq.send(sMessageOut, oTS);
                            }

                        }
                        scope.Complete();
                    }
                }
                if(oTS != default(TimeCard))
                    persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                        LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                        OConnectionFactory.getKeyValueString("Environment"),
                        String.Format("Operation Falied : {0}\n{1}", oSerializer.serialize(oTS), ex.Message),
                        oTS.refGuid.ToString(), SPrefixeName);
                else
                    persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                       LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                       OConnectionFactory.getKeyValueString("Environment"),
                       String.Format("Operation Failed : {0}", ex.Message),
                       OGuidContext.ToString(), SPrefixeName);

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
          
        private int insertAssiduity(TimeCard oTimeCard, SqlConnection  oConnectionTargetTrx = null, SqlConnection oConnectionReferentialTrx = null)
        {
            int iRet = default(int);
            try
            {

                using (var command = new SqlCommand("[dbo].[absence__insert_bis]", oConnectionTargetTrx != null ? oConnectionTargetTrx : OConnectionTarget))
                {
                    
                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    executePersistAssiduity(command, oTimeCard);

                    var result = returnParameter.Value;

                    int iVal = ODataReferentialManagement.registerLink(oTimeCard.TimecardID, (int)result, oTimeCard.refGuid, oConnectionReferentialTrx);

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
        private int updatetAssiduity(TimeCard oTimeCard, SqlConnection oConnectionTargetTrx = null, SqlConnection oConnectionReferentialTrx = null)
        {
            int iRet = default(int);
            try
            {

               
                int iUpdateKey = ODataReferentialManagement.getLinkAssiduityId(oTimeCard.TimecardID, oConnectionReferentialTrx);

                if (iUpdateKey > 0)
                    using (var command = new SqlCommand("[dbo].[absence__update]", oConnectionTargetTrx !=null ? oConnectionTargetTrx : OConnectionTarget))
                    {
                        command.Parameters.Add(new SqlParameter("@absence_request_ID", iUpdateKey));

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
                int iTimeType = 2;
                foreach (TimeTypeMapping oTimeType in lTimeType)
                    if (oTimeType.isMe(oTimeCard.TimeType))
                        iTimeType = oTimeType.LaveryType;


                command.CommandType = CommandType.StoredProcedure;

                if (!is_forUpdate) command.Parameters.Add(new SqlParameter("@timeKeeper_id", oTimeCard.Timekeeper));     //@user_id int
                command.Parameters.Add(new SqlParameter("@absence_type_id", iTimeType.ToString())); //@absence_type_iD int,
                if (oTimeCard.WorkDate.Year > 2020)
                {
                    command.Parameters.Add(new SqlParameter("@date_from", oTimeCard.WorkDate)); //@date_from datetime,  
                    command.Parameters.Add(new SqlParameter("@date_to", oTimeCard.WorkDate)); //@date_to datetime,
                }
                //??????????????????????????????
                if (oTimeCard.TimeType.Equals("Hourly", StringComparison.CurrentCultureIgnoreCase))
                {
                    command.Parameters.Add(new SqlParameter("@nb_hours", oTimeCard.WorkHrs)); //@nb_hours decimal(16, 2),  
                    command.Parameters.Add(new SqlParameter("@nb_days", (int)Math.Ceiling((double)oTimeCard.WorkHrs / (double)8) )); //@nb_days decimal(16, 2), 
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@nb_hours", oTimeCard.WorkHrs)); //@nb_hours decimal(16, 2), 
                    command.Parameters.Add(new SqlParameter("@nb_days",  (int)Math.Ceiling((double)oTimeCard.WorkHrs / (double)8)));//@nb_days decimal(16, 2), 
                }
                //??????????????????????????????
                command.Parameters.Add(new SqlParameter("@is_approved", true)); // @is_approved bit,
                command.Parameters.Add(new SqlParameter("@is_adjustment", false)); //@is_adjustment bit,
                command.Parameters.Add(new SqlParameter("@absence_ref", 500));      // @absence_ref int,
                command.Parameters.Add(new SqlParameter("@group_id", oTimeCard.refGuid));   //@group_id uniqueidentifier,
                command.Parameters.Add(new SqlParameter("@schedule_bitmask", 1));               //@schedule_Bitmask int
                command.Parameters.Add(new SqlParameter("@comment", oTimeCard.Narrative_UnformattedText)); //@comment VARCHAR(MAX), 
                command.Parameters.Add(new SqlParameter("@comment2", oTimeCard.InternalComments != default(String) ? oTimeCard.InternalComments : "")); //@comment2 VARCHAR(MAX),



                if (is_forUpdate)
                {
                    using (var cmd = new SqlCommand("Select top(1)user_id from usr where UsrTkinit = CAST(@timeKeeper_id as varchar)", OConnectionTarget))
                    {
                        cmd.Parameters.Add("@timeKeeper_id", System.Data.SqlDbType.Int);
                        cmd.Parameters["@timeKeeper_id"].Value = oTimeCard.Timekeeper;
                        //sRet = (String)cmd.ExecuteScalar();
                        int userId = (int)cmd.ExecuteScalar();

                        command.Parameters.Add(new SqlParameter("@user_id", userId));
                    }

                    

                    command.Parameters.Add(new SqlParameter("@is_exception", false));           //@is_exception bit,
                    command.Parameters.Add(new SqlParameter("@is_invisible", false));           //@is_invisible bit = 0,  
                    command.Parameters.Add(new SqlParameter("@is_cancel", false));              //@is_cancel bit,
                    command.Parameters.Add(new SqlParameter("@date_received", DateTime.Today));     //@is_cancel bit,
                    

                    command.Parameters.Add(new SqlParameter("@is_denied", false));              //@is_denied bit,
                    command.Parameters.Add(new SqlParameter("@is_pending_cancel", false));      //@is_pending_cancel bit,
                    command.Parameters.Add(new SqlParameter("@is_supervisor_approved", true));  //@is_supervisor_approved bit,
                    command.Parameters.Add(new SqlParameter("@date_cancellation", null));      //@date_cancellation
                    command.Parameters.Add(new SqlParameter("@denied_reason", null));         // @denied_reason VARCHAR(MAX) = null,
                    command.Parameters.Add(new SqlParameter("@is_deleted", false));         //@is_deleted bit,
                }

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
        private int deleteAssiduity(TimeCard oTimeCard, SqlConnection oConnectionTargetTrx = null, SqlConnection oConnectionReferentialTrx = null)
        {
            int iRet = default(int);
            try
            {
                
                int iUpdateKey = ODataReferentialManagement.getLinkAssiduityId(oTimeCard.TimecardID, oConnectionReferentialTrx);
                if (iUpdateKey > 0)
                    using (var command = new SqlCommand("[dbo].[absence__delete]", oConnectionTargetTrx != null ? oConnectionTargetTrx : OConnectionTarget))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TimeCard_ID", iUpdateKey));
                        iRet = command.ExecuteNonQuery();
                        ODataReferentialManagement.deleteLink(oTimeCard.TimecardID, oConnectionReferentialTrx);
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
