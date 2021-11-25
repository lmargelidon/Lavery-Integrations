using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools.Configuration.Management;
using Lavery.Tools.DBLibrary;
using Lavery.Tools.Connections;
using Lavery.Tools.Interfaces;


namespace Lavery.Listeners
{
    public class ListenerAssiduityBase : ListenerBase
    {             
        Boolean Disposed1;
        CDBDataBase oDb;

        public ListenerAssiduityBase( connectionFactory oConnectionFactory) : base(oConnectionFactory)
        {
            oDb = new CDBDataBase(Tools.Interfaces.ConnType.eConnType.SQLSERVER, OConnectionFactory.getKeyValueString("EliteDatabase"));
            oDb.SConnectString = OConnectionFactory.ConnectionString("ConnectionSourceAdminMode");
            oDb.OPool = new ConnectionPoolDatabases<IGenericConnection>(1);
            oDb.enableNotification(OConnectionFactory.getKeyValueString("EliteDatabase"));
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
        public override Boolean doTerminate()
        {
            
            return false;
        }
    }
}
