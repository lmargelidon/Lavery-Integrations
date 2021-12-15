using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools.Configuration.Management;
using Lavery.Tools.DBLibrary;
using Lavery.Tools.Connections;
using Lavery.Tools.Interfaces;
using Lavery.Tools;
using Newtonsoft.Json.Linq;
using Lavery.Schemas;
using Lavery.Schemas.E3;


namespace Lavery.Listeners
{
    public class ListenerAssiduityBase : ListenerBase
    {
        Boolean Disposed1;
        CDBDataBase oDb;
        List<TimeTypeMapping> lTimeType = new List<TimeTypeMapping>();

        public ListenerAssiduityBase(connectionFactory oConnectionFactory) : base(oConnectionFactory)
        {
           
            oDb = new CDBDataBase(Tools.Interfaces.ConnType.eConnType.SQLSERVER, OConnectionFactory.getKeyValueString("EliteDatabase"));
            oDb.SConnectString = OConnectionFactory.ConnectionString("ConnectionSourceAdminMode");
            oDb.OPool = new ConnectionPoolDatabases<IGenericConnection>(1);
            oDb.enableNotification(OConnectionFactory.getKeyValueString("EliteDatabase"));
            String[] aTimeTypes = OConnectionFactory.getKeyValueString("AssiduiteTimeTypeMapping").Split(';');
            foreach (String sTimeType in aTimeTypes)
                lTimeType.Add(new TimeTypeMapping(sTimeType));

        }

        protected override void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!Disposed1)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {

                }

                Disposed = true;
            }
        }

        public override Boolean doInitialize()
        {

            return false;
        }

        public override Boolean doJob()
        {
            
            return false;
        }
        /*
        * *********************************************************************************************
        * if TimeCard or TimeCardPending was Non Billable and the new transaction is billable change to delete old time 
        * in assiduity system
        * *********************************************************************************************
        */
        protected int getNonBillableTimeType(Object oTS )
        {
            int iTimeType = -1;
            Guid oGuid = default(Guid);
            foreach (TimeTypeMapping oTimeType in lTimeType)
                if (oTimeType.isMe(oTS .GetType() ==  typeof(TimeCard)? ((TimeCard)oTS).TimeType : ((TimeCardPending)oTS).TimeType))
                {
                    iTimeType = oTimeType.LaveryType;

                }
            
            if (iTimeType == -1 && (oGuid = ODataReferentialManagement.getLinkCorrelationId(oTS.GetType() == typeof(TimeCard) ?  ((TimeCard)oTS).TimecardID : 
                                                                                                                                            ((TimeCardPending)oTS).TimeCardPendingID)) != default(Guid))
            {
                if (oTS.GetType() == typeof(TimeCard))
                {
                    ((TimeCard)oTS).IsNB = 1;
                    ((TimeCard)oTS).TimeType = lTimeType[1].GetType().ToString();
                    iTimeType = lTimeType[1].IE3Type;
                    ((TimeCard)oTS).etypeEnvelopp = typeEnvelopp.Delete;
                    ((TimeCard)oTS).refGuid = oGuid;
                }
                else
                {
                    ((TimeCardPending)oTS).IsNB = 1;
                    ((TimeCardPending)oTS).TimeType = lTimeType[1].GetType().ToString();
                    iTimeType = lTimeType[1].IE3Type;
                    ((TimeCardPending)oTS).etypeEnvelopp = typeEnvelopp.Delete;
                    ((TimeCardPending)oTS).refGuid = oGuid;
                }
            }
            return iTimeType;
        }
        public override Boolean doTerminate()
        {

            return false;
        }
      
    }
}
