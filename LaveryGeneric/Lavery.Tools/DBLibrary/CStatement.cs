using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;
using System.Xml;
using Lavery.Tools.Connections;
using Lavery.Tools.Interfaces;

namespace Lavery.Tools.DBLibrary
{
    public class CStatement : CPersisentObject
    {



        protected CStatement(ConnectionPoolDatabases<IGenericConnection> pWithConnFactory, String sWithSchema, String sWithName) :
            base(pWithConnFactory, sWithSchema, sWithName)
        {  
        }
        protected CStatement(ConnectionPoolDatabases<IGenericConnection> pWithConnFactory) :
            base(pWithConnFactory)
        {
           
        }
        protected CStatement(ConnectionPoolDatabases<IGenericConnection> pWithConnFactory, String szWithConnString)
            :
             base(pWithConnFactory, szWithConnString)
        {

        }

        public virtual bool PrepareText(String sWithSql)
        { return true; }

        public virtual bool PrepareStoreProc(String sWithSql)
        { return true; }

        public virtual bool bindParameter(String sNumber, String sParameters)
        { return true; }
        public virtual bool bindParameter(String sNumber, int iParameters)
        { return true; }
        public virtual bool bindParameter(String sNumber, XmlDocument xParameters)
        { return true; }

        public virtual bool Execute()
        { return true; }
        public virtual Object ExecuteAndReturnValue(Type tType)
        { return null; }
        public virtual DataTable ExecuteAndReturnResultSet()
        { return null; }
        public virtual XmlDocument ExecuteStoreProcAndReturnXml()
        { return null; }
        public virtual bool ExecuteDirect(String sWithSql)
        { return true; }
               
      }
}

