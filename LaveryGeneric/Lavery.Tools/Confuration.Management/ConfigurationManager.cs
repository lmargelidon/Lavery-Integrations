using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lavery.Tools;

namespace Lavery.Tools.Configuration.Management
{
    public class ConfigurationManager
    {
        public static T GetSection<T>(String sSectionName)
        {
            Object oObj = System.Configuration.ConfigurationManager.GetSection(sSectionName);
            T lRetr = (T)oObj;
           
            return lRetr;
        }
            public static List<ConnectionStrings> getConnectStrings()
        {
            List<ConnectionStrings> lRet = null;
            try
            {
                int iMax = System.Configuration.ConfigurationManager.AppSettings.Count;
                Console.WriteLine("iMax = <{0}> \n", iMax);
                List<ConnectionStrings> lConnectString = new List<ConnectionStrings>();
                for (int i = 0; i < iMax; i++)
                {
                    String sKey = System.Configuration.ConfigurationManager.AppSettings.GetKey(i);
                    Boolean bValidConnectionString = true;
                    if (sKey.Length > 8 && sKey.Substring(0, 8).Equals("UriPlage", StringComparison.CurrentCultureIgnoreCase))
                        bValidConnectionString = false;
                    if (sKey.Equals("FileExtensionForAssembly", StringComparison.CurrentCultureIgnoreCase))
                    {
                        bValidConnectionString = false;
                    }
                    if (sKey.Equals("FileExtensionForXml", StringComparison.CurrentCultureIgnoreCase))
                    {
                        bValidConnectionString = false;
                    }
                    if (sKey.Equals("FileExtensionForRawData", StringComparison.CurrentCultureIgnoreCase))
                    {
                        bValidConnectionString = false;
                    }
                    if (sKey.Equals("FileExtensionForExcelDocument", StringComparison.CurrentCultureIgnoreCase))
                    {
                        bValidConnectionString = false;
                    }
                    if (bValidConnectionString)
                    {
                        ConnectionStrings oConnString = new ConnectionStrings(System.Configuration.ConfigurationManager.AppSettings.Get(i));
                        
                        lConnectString.Add(oConnString);
                       
                    }
                }

                // sRet = System.Configuration.ConfigurationSettings.AppSettings.Get(sConnectString);
                Comparison<ConnectionStrings> Compare = new Comparison<ConnectionStrings>(ConnectionStrings.CompareConnectStringObject);

                lConnectString.Sort(Compare);
                lRet = lConnectString;
               
            }
            catch (Exception ex)
            {

                throw (ex);
            }
            return lRet;
        }
        

    }
}
