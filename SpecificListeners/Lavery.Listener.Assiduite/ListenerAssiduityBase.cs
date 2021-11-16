using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lavery.Tools.Configuration.Management;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

using Lavery.Listeners;
using Lavery.Schemas.Legacy;
using Lavery.Constants;
using Lavery.Tools;
using Lavery.Events.Listeners;
using System.Data;
using System.Data.SqlClient;

namespace Lavery.Listeners
{
    public class ListenerAssiduityBase : ListenerBase
    {             
        Boolean Disposed;

        public ListenerAssiduityBase( connectionFactory oConnectionFactory) : base(oConnectionFactory)
        {
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
