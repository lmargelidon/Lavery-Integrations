using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Helper.ClassGenerator;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;

namespace EF.Entities.management
{
    public class EntitiesGenerator : Object, IDisposable
    {
        connectionFactory OCF;
        SqlConnection oConnectionSource;
        Boolean disposing;
        Boolean Disposed;
        String sQlGeneration;
        ~EntitiesGenerator() => Dispose(false);

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called.
            if (!this.Disposed)
            {
                // If disposing equals true, dispose all managed
                // and unmanaged resources.
                if (disposing)
                {

                }

                oConnectionSource.Close();
                Disposed = true;
            }
        }
        public EntitiesGenerator(connectionFactory OCF, String sBaseTableName, String dSecondTableName, String dThirdTableName) 
        {
            try
            {
                this.OCF = OCF;
                sQlGeneration = String.Format(LaverySql.sSqlForThreeEntities, sBaseTableName, dSecondTableName, dThirdTableName);
                oConnectionSource = new SqlConnection(OCF.ConnectionString("ConnectionSource"));
                oConnectionSource.Open();                

            }
            catch
            {

            }
        }
        public void doJob(String sNameSpace)
        {
            using (var cmd = new SqlCommand(sQlGeneration, oConnectionSource))
            {               
                
            }

        }
    }
}
