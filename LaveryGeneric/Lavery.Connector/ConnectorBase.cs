using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools.Configuration.Management;

namespace Lavery.Connector
{
    public class ConnectorBase
    {
        connectionFactory oConnectionFactory;
        private bool _disposedValue;
        public ConnectorBase(connectionFactory oConnectionFactory)
        {
            this.oConnectionFactory = oConnectionFactory;
        }

        public connectionFactory OConnectionFactory { get => oConnectionFactory; }

        public delegate Boolean delegateFonction(Object oObjectMessage, String sJson);
        
        

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
       
        
        ~ConnectorBase() => Dispose(false);
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this._disposedValue)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {

                }
               
                _disposedValue = true;
            }
        }
    }
}
