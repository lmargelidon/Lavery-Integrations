
using LsaObjectCommunication;
using lsaTools.GenericInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lsaTools.genericConnections
{
    enum eHTTPOperation { None, POST, GET};
    class genericHttpConnection: IGenericConnection
    {
        LsaHttpObjectCommunication oConnection = default(LsaHttpObjectCommunication);


        public genericHttpConnection()
        { }
        public Object getConnection()
        {
            return oConnection;
        }
        public Boolean Open(String sWithConnectionString)
        {
            Boolean bRet = false;
            try
            {
                char[] cSep = {';'};
                String[] aVal = sWithConnectionString.Split(cSep);
                LsaObjectCommunicationParameters oParam = new LsaObjectCommunicationParameters(eCommunicationType.HTTP);
                foreach (String sParam in aVal)
                {
                    char[] cSep1 = { '=' };
                    String[] aVal1 = sParam.Split(cSep1);
                    try
                    {
                        oParam.addParameter(aVal1[0], aVal1[1]);
                    }
                    catch
                    { }

                }
                oConnection = new LsaHttpObjectCommunication(oParam);                

            }
            catch (Exception ex)
            {
                throw (ex);

            }

            return bRet;
        }

        public Boolean Close()
        {
            Boolean bRet = false;
            try
            {

                bRet = true;
            }
            catch (Exception ex)
            {
                throw (ex);

            }

            return bRet;
        }
        public Boolean execute(String sWithDataString, Object oWithOperationType)
        {
            Boolean bRet = true;
            try
            {
                String sRet = default(String);
                if ((eHTTPOperation)oWithOperationType == eHTTPOperation.POST)
                    sRet = oConnection.httpPOST(sWithDataString);
                else
                    if ((eHTTPOperation)oWithOperationType == eHTTPOperation.GET)
                        sRet = oConnection.HttpGET(sWithDataString);
                if (sRet == default(String))
                    bRet = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw (ex);

            }

            return bRet;
        }
        public Object getInformations(String sWithStatementString)
        {
            Object oRet = default(Object);
            try
            {
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw (ex);

            }

            return oRet;
        }
    }
}
