using System;
using System.Collections.Generic;
using System.Text;

namespace Lavery.Tools.DataBaseClassLibrary
{
    public class CDBTransaction: CDBObject
    {
        private CDBConnection pConn = null;

        public CDBConnection PConn
        {
            get { return pConn; }
            set { pConn = value; }
        }
        private static List<CPersisentObject> elements = new List<CPersisentObject>();

        public CDBTransaction(CDBConnection pWithConn)
        {
            pConn = pWithConn;
        }
        public bool addToTransaction(CPersisentObject pWithPersistentObject)
        {
            bool bRet = true;
            try
            {
                elements.Add(pWithPersistentObject);
                pWithPersistentObject.PTrans = this;
                
            }
            catch (Exception ex)
            {
                
                throw (ex);
            }
            return bRet;
        }
        
        public virtual bool begin()
        {
            bool bRet = true;
            try
            { 
            }
            catch (Exception ex)
            {
                throw (ex);
              
            }
            return bRet;
        }
        public virtual bool Commit()
        {
            bool bRet = true;
            try
            {
                foreach (CPersisentObject pElet in elements)
                    pElet.PTrans = null;
            }
            catch (Exception ex)
            {
                
                throw (ex);

            }
            return bRet;
        }
        public virtual  bool RollBack()
        {
            bool bRet = true;
            try
            {
                foreach (CPersisentObject pElet in elements)
                    pElet.PTrans = null;
            }
            catch (Exception ex)
            {
               
                throw (ex);

            }
            return bRet;
        }

    }
}
