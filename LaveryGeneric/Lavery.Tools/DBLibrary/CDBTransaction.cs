using Lavery.Tools.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lavery.Tools.DBLibrary
{
    public class CDBTransaction: CDBObject
    {
        private IGenericConnection pConn = null;
        private bool disposed = false;


        public IGenericConnection PConn
        {
            get { return pConn; }
            set { pConn = value; }
        }
        private static List<CPersisentObject> elements = new List<CPersisentObject>();

        public CDBTransaction(IGenericConnection pWithConn)
        {
            pConn = pWithConn;
        }

        //Implement IDisposable.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    CDBDataBase.releaseConnection(pConn);
                }
                
                disposed = true;
            }
    }

       // Utliser le destructeur C# pour finaliser le code
        ~CDBTransaction()
        {
            // Simply call Dispose(false).
            Dispose (false);
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
