using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;
using Lavery.Tools.ConnectionPool;
using Lavery.Tools.Interfaces;
using Lavery.Tools.Connections;


namespace Lavery.Tools.DBLibrary
{
    public class CPersisentObject : CDBObject
    {
        protected ConnectionPoolDatabases<IGenericConnection> pConnFactory = default(ConnectionPoolDatabases<IGenericConnection>);
        protected CDBDataBase           pDb = null;
        protected String szConnString = null;
        protected CDBTransaction pTrans = null;
        protected String sSchema = null;
        protected String sName = null;
        public CDBTransaction PTrans
        {
            get { return pTrans; }
            set { pTrans = value; }
        }
        protected CPersisentObject(ConnectionPoolDatabases<IGenericConnection> pWithConnFactory, String sWithSchema, String sWithName)
        {   pConnFactory    = pWithConnFactory;
            sSchema         = sWithSchema;
            sName           = sWithName;
            szConnString    = "";
        }
        protected CPersisentObject(CDBDataBase pWithDb, String sWithSchema, String sWithName)
        {            
            pDb = pWithDb;
            pConnFactory = pDb.OPool;
            sSchema = sWithSchema;
            sName = sWithName;
            szConnString = "";
        }
        protected CPersisentObject(ConnectionPoolDatabases<IGenericConnection> pWithConnFactory)
        {
            pConnFactory = pWithConnFactory;
            sSchema = "";
            sName = "";
            szConnString = "";
        }
        protected CPersisentObject(ConnectionPoolDatabases<IGenericConnection> pWithConnFactory, String szWithConnString)
        {
            pConnFactory = pWithConnFactory;
            sSchema = "";
            sName = "";
            szConnString = szWithConnString;
        }

    }
}
