using Lavery.Tools.Interfaces;
using Lavery.Tools.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lavery.Tools.Connections
{
    public abstract class genericDataBaseConnection: IGenericConnection
    {
        protected String sConnectionString = "";
        
        public static genericDataBaseConnection buildDatabaseConnection(int iWithDb)
        {
            genericDataBaseConnection oRet = default(genericDataBaseConnection); 
            try
            {
                switch(iWithDb)
                {
                    case 0:
                        
                        break;
                    case 1:
                        oRet = new genericSqlConnection();
                        break;
                }
            }
            catch(Exception ex)
            {}
            return oRet;
        }
        public abstract Object getConnection();
        public abstract Boolean Open(String sWithConnectionString);
        public abstract Boolean Close();
        public abstract Boolean execute(String sWithStatementString, Object oWithSqlTransaction);
        public abstract Object getInformations(String sWithStatementString, eReturnObjectType oWithReturnType = eReturnObjectType.None);
        public abstract Object getInformationsObjectType(String sWithStatementString);
    }
}
