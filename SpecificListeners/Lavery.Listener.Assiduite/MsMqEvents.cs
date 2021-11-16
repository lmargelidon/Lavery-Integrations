using System;
using System.Text;
using Lavery.Listeners;
using System.Data;
using System.Data.SqlClient;
using Lavery.Schemas.Legacy;
using Lavery.Connector;
using Lavery.Schemas;
using Lavery.Tools;
using Lavery.Events.Listeners;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;

namespace Lavery.Listeners
{ 
    public class MsMqEvents : ListenerBase
    {

        MsMq<absence_request> oMq;        
        XMLSerializer<absence_request> oSerializer;
        
        public MsMqEvents(connectionFactory oConnectionFactory, String SPrefixeName, Guid oGuid) : base(oConnectionFactory)
        {
            try
            {
                this.IWaitOnMutex = OConnectionFactory.getKeyValueInt("MutexTimeOut");
                OGuidContext = Guid.NewGuid();
                this.oSerializer = new XMLSerializer<absence_request>();
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
                switch (((absence_request)oObjectMessage).etypeEnvelopp)
                {
                    case typeEnvelopp.Insert:
                        insertAssiduity((absence_request)oObjectMessage);
                        break;
                    case typeEnvelopp.Update:
                        updatetAssiduity((absence_request)oObjectMessage);
                        break;
                    case typeEnvelopp.Delete:
                        deleteAssiduity((absence_request)oObjectMessage);
                        break;
                    default:
                        break;
                }
                
            }
            catch(Exception ex)
            {
                throw(ex);
            }
            return bRet;
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

                oMq = new MsMq<absence_request>(OConnectionFactory, "AssiduiteQueue");

               
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
                //Envelopp<TimeSheet> oEnv = default(Envelopp<TimeSheet>);
                absence_request oTS = default(absence_request);
                
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
        
        private int insertAssiduity(absence_request oAbsence_request)
        {
            int iRet = default(int);
            try
            {   

                using (var command = new SqlCommand("[dbo].[absence__insert_bis]", OConnectionTarget))
                {                    
                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    executePersistAssiduity(command, oAbsence_request);
                    
                    var result = returnParameter.Value;

                    int iVal = ODataReferentialManagement.registerLink(Convert.ToInt32(oAbsence_request.id_origine), (int) result, oAbsence_request.group_id);

                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.InsertAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("{0}", oSerializer.Serialize(oAbsence_request, absence_request.XmlSerializerNamespaces, Encoding.UTF8)),
                                                  oAbsence_request.group_id.ToString(), SPrefixeName);
                }
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.InsertAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("Operation Falied : {0}\n{1}", oSerializer.Serialize(oAbsence_request, absence_request.XmlSerializerNamespaces, Encoding.UTF8), ex.Message),
                                                  oAbsence_request.group_id.ToString(), SPrefixeName);
                Console.WriteLine(ex.Message);
                throw (ex);
            }
            return iRet;
        }
        private int updatetAssiduity(absence_request oAbsence_request)
        {
            int iRet = default(int);
            try
            {
                

                int iUpdateKey = ODataReferentialManagement.getLinkAssiduityId(Convert.ToInt32(oAbsence_request.id_origine));
              
                if(iUpdateKey > 0)
                    using (var command = new SqlCommand("[dbo].[absence__update]", OConnectionTarget))
                    {                            
                        command.Parameters.Add(new SqlParameter("@absence_request_ID", iUpdateKey));
                       
                        executePersistAssiduity(command, oAbsence_request, true);
                        persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.UpdateAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("{0}", oSerializer.Serialize(oAbsence_request, absence_request.XmlSerializerNamespaces, Encoding.UTF8)),
                                                  oAbsence_request.group_id.ToString(), SPrefixeName);
                        
                    }
                else
                    throw(new Exception(String.Format("Update failure no corresponding id <{0}> found in the referential link", oAbsence_request.id_origine )));

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.UpdateAbsenceRequest.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("Operation Falied : {0}\n{1}", oSerializer.Serialize(oAbsence_request, absence_request.XmlSerializerNamespaces, Encoding.UTF8), ex.Message),
                                                  oAbsence_request.group_id.ToString(), SPrefixeName);
                Console.WriteLine(ex.Message);
                throw (ex);
            }
            return iRet;
        }
        private int executePersistAssiduity(SqlCommand command, absence_request oAbsence_request, Boolean is_forUpdate = false)
        {
            int iRet = -1;
            try 
            {
                command.CommandType = CommandType.StoredProcedure;                
                command.Parameters.Add(new SqlParameter("@user_id", oAbsence_request.user_id));
                command.Parameters.Add(new SqlParameter("@absence_type_id", oAbsence_request.absence_type_id));
                //command.Parameters.Add(new SqlParameter("@absence_type_id", 2));
                if (oAbsence_request.date_from.Year > 2020)
                    command.Parameters.Add(new SqlParameter("@date_from", oAbsence_request.date_from));
                if (oAbsence_request.date_to.Year > 2020)
                    command.Parameters.Add(new SqlParameter("@date_to", oAbsence_request.date_to));
                command.Parameters.Add(new SqlParameter("@nb_hours", oAbsence_request.nb_hours));
                command.Parameters.Add(new SqlParameter("@nb_days", oAbsence_request.nb_days));
                command.Parameters.Add(new SqlParameter("@is_approved", oAbsence_request.is_approved));
                command.Parameters.Add(new SqlParameter("@absence_ref", oAbsence_request.absence_ref));
                command.Parameters.Add(new SqlParameter("@group_id", oAbsence_request.group_id));
                command.Parameters.Add(new SqlParameter("@schedule_bitmask", oAbsence_request.schedule_Bitmask));
                command.Parameters.Add(new SqlParameter("@comment", oAbsence_request.comment));
                command.Parameters.Add(new SqlParameter("@comment2", oAbsence_request.comment2 != default(String) ? oAbsence_request.comment2 : ""));
                command.Parameters.Add(new SqlParameter("@is_adjustment", oAbsence_request.is_adjustment));


                if (is_forUpdate)
                {
                    if (oAbsence_request.date_received.Year > 2020)
                        command.Parameters.Add(new SqlParameter("@date_received", oAbsence_request.date_received));
                    if (oAbsence_request.date_approved.Year > 2020)
                        command.Parameters.Add(new SqlParameter("@date_approved", oAbsence_request.date_approved));
                    
                    command.Parameters.Add(new SqlParameter("@is_exception", oAbsence_request.is_exception));
                    command.Parameters.Add(new SqlParameter("@is_invisible", oAbsence_request.is_invisible));
                    command.Parameters.Add(new SqlParameter("@is_cancel", oAbsence_request.is_cancel));
                    command.Parameters.Add(new SqlParameter("@is_denied", oAbsence_request.is_denied));
                    
                    command.Parameters.Add(new SqlParameter("@is_pending_cancel", oAbsence_request.is_pending_cancel));
                    command.Parameters.Add(new SqlParameter("@is_supervisor_approved", oAbsence_request.is_supervisor_approved));
                    if (oAbsence_request.date_cancellation.Year > 2020)
                        command.Parameters.Add(new SqlParameter("@date_cancellation", oAbsence_request.date_cancellation));
                    command.Parameters.Add(new SqlParameter("@denied_reason", oAbsence_request.denied_reason));

                    command.Parameters.Add(new SqlParameter("@is_deleted", oAbsence_request.is_deleted));
                }
                
                iRet = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.PerformEntry.ToString(),
                                                  OConnectionFactory.getKeyValueString("Environment"),
                                                  String.Format("Exception catched {0}:\n{1}", command.CommandText, ex.Message),
                                                  oAbsence_request.group_id.ToString(), SPrefixeName);
                throw (ex);
            }
            return iRet;
        }
        private int deleteAssiduity(absence_request oAbsence_request)
        {
            int iRet = default(int);
            try
            {
                
                int iUpdateKey = ODataReferentialManagement.getLinkAssiduityId(Convert.ToInt32(oAbsence_request.id_origine));
                if (iUpdateKey > 0)
                    using (var command = new SqlCommand("[dbo].[absence__delete]", OConnectionTarget))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@absence_request_ID", iUpdateKey));                        
                        iRet = command.ExecuteNonQuery();
                        ODataReferentialManagement.deleteLink(Convert.ToInt32(oAbsence_request.id_origine));
                        persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                       LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                                                       OConnectionFactory.getKeyValueString("Environment"),
                                                       String.Format("{0}", oSerializer.Serialize(oAbsence_request, absence_request.XmlSerializerNamespaces, Encoding.UTF8)),
                                                       oAbsence_request.group_id.ToString(), SPrefixeName);
                        
                    }
                else
                    throw (new Exception(String.Format("Delete failure no corresponding id <{0}> found in the referential link", oAbsence_request.id_origine)));

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                 LaveryBusinessFunctions.eBusinessFunction.DeleteAbsenceRequest.ToString(),
                                                 OConnectionFactory.getKeyValueString("Environment"),
                                                 String.Format("Operation Falied : {0}\n{1}", oSerializer.Serialize(oAbsence_request, absence_request.XmlSerializerNamespaces, Encoding.UTF8), ex.Message),
                                                 oAbsence_request.group_id.ToString(), SPrefixeName);                
                throw (ex);
            }
            return iRet;
        }
    }
}
