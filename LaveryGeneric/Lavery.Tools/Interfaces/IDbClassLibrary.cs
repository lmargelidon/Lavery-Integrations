using System;
using System.Collections.Generic;
using System.Text;

namespace Lavery.Tools.Interfaces
{
    public class ConnType 
    {
        public enum eConnType { NOTHING, DB2UDB, ORACLE, SQLSERVER, MYSQL };
    }

    public interface IDBDatabase
    {
        ITable createTable(ConnType.eConnType eConnType, String sWithSchema, String sWithName, String sWithAlias, IConnFactory pWithConnFactory);
        bool DropTable(ConnType.eConnType eConnType, String sWithSchema, String sWithName, String sWithAlias, IConnFactory pWithConnFactory);
        
    }
    public interface ITable
    {
        
    }
    public interface IConnFactory
    {
        
    }
   
}

