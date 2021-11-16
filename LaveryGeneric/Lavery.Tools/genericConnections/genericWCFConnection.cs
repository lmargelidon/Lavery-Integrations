using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lavery.Tools.Interfaces;
using System.ServiceModel;

namespace Lavery.Tools.Connections
{
    public class genericWCFConnection<T>: IGenericConnection
    {
        ChannelFactory<T> oChannelFactory = default(ChannelFactory<T>);
        T oInterface = default(T);
        String sConnectionString = "";


        public genericWCFConnection()
        { }
       public Object getConnection() 
        {
            try
            {
                try
                {
                    ((IWcfClientBase)oInterface).PingService("");
                }
                catch 
                { }
                
               if (((IClientChannel)oInterface).State == System.ServiceModel.CommunicationState.Faulted)
               {
                   ((IClientChannel)oInterface).Abort();
                   Open(sConnectionString);
               }
            }
            catch (Exception ex)
            {
                throw (ex);
               
            }

            return oInterface;
        }
        public Boolean Open(String sWithConnectionString)
        {
            Boolean bRet = false;
            try
            {
                oChannelFactory = new ChannelFactory<T>(sWithConnectionString);
                oInterface = oChannelFactory.CreateChannel();
                sConnectionString = sWithConnectionString;

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
                ((IClientChannel)oInterface).Close();
                oInterface = default(T);
                oChannelFactory.Close();
                oChannelFactory = default(ChannelFactory<T>);
                bRet = true;
            }
            catch (Exception ex)
            {
                throw (ex);

            }

            return bRet;
        }
        public Boolean execute(String sWithStatementString, Object oWithObject)
        {
            Boolean bRet = false;
            try
            {
                // not applicable because to specific

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw (ex);

            }

            return bRet;
        }
        public Object getInformations(String sWithStatementString, eReturnObjectType oWithReturnType = eReturnObjectType.None)
        { /*
            SqlDataReader oRet = default(SqlDataReader);
            try
            {
                SqlCommand command = new SqlCommand(sWithStatementString, oConnection);

                oRet = command.ExecuteReader();
                           

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw (ex);

            }
            */
            return null;
        }
    }
}
