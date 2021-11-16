using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;


namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CPersisentObject : CDBObject
    {
        protected CDBConnectionFactory  pConnFactory = null;
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
        protected CPersisentObject( CDBConnectionFactory pWithConnFactory, String sWithSchema, String sWithName)
        {   pConnFactory    = pWithConnFactory;
            sSchema         = sWithSchema;
            sName           = sWithName;
            szConnString    = "";
        }
        protected CPersisentObject(CDBDataBase pWithDb, String sWithSchema, String sWithName)
        {            
            pDb = pWithDb;
            pConnFactory = pDb.PConnFactory;
            sSchema = sWithSchema;
            sName = sWithName;
            szConnString = "";
        }
        protected CPersisentObject(CDBConnectionFactory pWithConnFactory)
        {
            pConnFactory = pWithConnFactory;
            sSchema = "";
            sName = "";
            szConnString = "";
        }
        protected CPersisentObject(CDBConnectionFactory pWithConnFactory, String szWithConnString)
        {
            pConnFactory = pWithConnFactory;
            sSchema = "";
            sName = "";
            szConnString = szWithConnString;
        }

    }
}
