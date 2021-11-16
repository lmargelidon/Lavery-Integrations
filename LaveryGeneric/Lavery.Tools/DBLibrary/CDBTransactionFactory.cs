using System;
using System.Collections.Generic;
using System.Text;

using Lavery.Tools.Interfaces;
using Lavery.Tools.Connections;

namespace Lavery.Tools.DBLibrary
{
    public class CDBTransactionFactory: CDBObject
    {
        private static List<CDBTransaction> elements = new List<CDBTransaction>();

        public CDBTransactionFactory()
        {
            eType = ConnType.eConnType.NOTHING;
        }
        public CDBTransaction createTransaction(ConnType.eConnType eWithType, ConnectionPoolDatabases<IGenericConnection> pWithConnFactory)
        {
            CDBTransaction pTrans = null;
            try
            {
                if (eWithType == ConnType.eConnType.DB2UDB)
                {  
#if DB2 
                    pTrans = new CDBTransactionForDB2UDB(pWithConnFactory.getConnection(ConnType.eConnType.DB2UDB, 500));
#endif
                }
                lock (this)
                {
                    elements.Add(pTrans);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return pTrans;
        }

        public void releaseTransaction(CDBTransaction pTrans)
        {
            try
            {   lock (this)
                {
                    elements.Remove(pTrans);
                }
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            
        }

    }
}
