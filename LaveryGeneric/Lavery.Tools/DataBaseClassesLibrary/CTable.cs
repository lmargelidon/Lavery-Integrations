using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ADODB;

namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CTable : CPersisentObject
    {
        protected DataTable table   = null;
        
        protected CTable( CDBConnectionFactory pWithConnFactory, String sWithSchema, String sWithName):
            base(pWithConnFactory, sWithSchema, sWithName)
        {   
        }
        protected CTable(CDBDataBase pWithDb, String sWithSchema, String sWithName)
            :
            base(pWithDb, sWithSchema, sWithName)
        {
        }
        protected CTable(CDBConnectionFactory pWithConnFactory):
            base(pWithConnFactory)
        {
            
        }


        public virtual DataRow newRow()
        { return null; }
        public virtual bool Reset(String sWithTableName, String sWithSqlCommand)
        { return true; }
        public virtual bool Reset(String sWithSqlCommand)
        { return true; }

        public virtual bool Reset()
        { return true; }
        
        public virtual bool Insert(String sWithSql)
        { return true; }

        public virtual bool Update(String sWithSql)
        { return true; }

        public DataSet executeSelect(string sfreeSql, string sFillWith)
        { return null; }

        public virtual bool Create(String sWithSql, String sWithDataTableSpace, String sWithIndexTableSpace)
        {
            return true;
        }
        public virtual bool Drop()
        {
            return true;
        }
        public virtual bool CreateIndex(bool bWithUnique,
                                       String sWithIndexName,
                                       String sWithColumns)
        {
            return true;
        }
        
      }
}
