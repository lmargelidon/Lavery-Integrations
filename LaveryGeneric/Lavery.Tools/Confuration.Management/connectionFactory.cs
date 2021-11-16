using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Tools.Configuration.Management
{
    public class connectionFactory
    {
      
        public connectionFactory()
        { }

        public String ConnectionString(String sName)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[sName].ConnectionString;
        }
        public String getKeyValueString(String sKey)
        {
            String sRet = "";
            try
            {
                var appSettings = System.Configuration.ConfigurationManager.AppSettings;
                sRet = appSettings[sKey] ?? "Not Found";
                
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return sRet;
        }
        public int getKeyValueInt(String sKey)
        {
            int iRet = -1;
            try
            {
                var appSettings = System.Configuration.ConfigurationManager.AppSettings;
                String sRet = appSettings[sKey] ?? "Not Found";
                if(sRet.Equals("Not Found"))
                    throw(new ConfigurationErrorsException("value for " + sKey  + "Not Found"));
                iRet = int.Parse(sRet);

            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine(ex.Data);
            }
            return iRet;
        }

    }
}
