using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace lsaTools.GenericInterface
{
    public enum eServiceStatus { None = 0, Pending = 1, notResponging = 2, Sucess = 3, Error = 4, Stopped = 5 }
    public interface IGenericConnection
    {

        Boolean Open(String sWithConnectionString);
        Boolean Close();
        Boolean execute(String sWithStatementString, Object transactionScopeOrSqlTransaction);
        Object getInformations(String sWithStatementString);
        Object getConnection();
    }
   
}
