using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Configuration;
using System.Configuration;

namespace Lavery.Tools.Configuration.Management
{
    public class WcfServiceInformation
    {
        String sName = default(String);
        Uri oUri = default(Uri);

        public Uri OUri
        {
            get { return oUri; }
            set { oUri = value; }
        }


        public String SName
        {
            get { return sName; }
            set { sName = value; }
        }
    }
    static public  class sectionManagement
    {

        static public List<String> getSectionServiceModelClientEntries()
        {
            List<String> lendpointNames = new List<string>();
            try
            {
                ClientSection clientSection = System.Configuration.ConfigurationManager.GetSection("system.serviceModel/client") as ClientSection;

                ChannelEndpointElementCollection endpointCollection =
                    clientSection.ElementInformation.Properties[string.Empty].Value as ChannelEndpointElementCollection;
                
                foreach (ChannelEndpointElement endpointElement in endpointCollection)
                {
                   /* if (endpointElement.Address != null &&
                        endpointElement.Address.AbsolutePath.Length != 0 &&
                        endpointElement.Address.AbsoluteUri.Length != 0)*/
                        lendpointNames.Add(endpointElement.Name);
                }
            }
            catch
            { 
                
            }

            return lendpointNames;
        }
        public static WcfServiceInformation GetWcfServicesInformation(String sWithSpecificService)
        {
            WcfServiceInformation oRet = default(WcfServiceInformation);
            List<WcfServiceInformation> oList = GetWcfServicesInformation();
            foreach(WcfServiceInformation oService in oList)
                if (oService.SName.Equals(sWithSpecificService, StringComparison.CurrentCultureIgnoreCase))
                {
                    oRet = oService;
                    break;
                }
            return oRet;
        }
        public static List<WcfServiceInformation> GetWcfServicesInformation()
        {
            // Get the application configuration file.
            // TODO: Might be adjusted for WCF hosted / web.config
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Get the collection of the section groups.
            var sectionGroups = config.SectionGroups;

            
            // Get the serviceModel section
            var serviceModelSection = sectionGroups.OfType<ServiceModelSectionGroup>().SingleOrDefault();

            // Check if serviceModel section is configured
            if (serviceModelSection == null)
                throw new ArgumentNullException("Configuration section 'system.serviceModel' is missing.");
            
            List<WcfServiceInformation> oList = new List<WcfServiceInformation>();
            foreach (ServiceElement service in serviceModelSection.Services.Services)
                foreach (BaseAddressElement baseAddress in service.Host.BaseAddresses)
                {
                    WcfServiceInformation oObj = new WcfServiceInformation();
                    oObj.SName = service.Name;
                    oObj.OUri = new Uri(baseAddress.BaseAddress);
                    oList.Add(oObj);
                }
            return oList;

            /*        
            // Get base addresses
            return (from ServiceElement service in serviceModelSection.Services.Services
                    from BaseAddressElement baseAddress in service.Host.BaseAddresses
                    select new Uri(baseAddress.BaseAddress)).ToArray();
             * */
        }
    }
}
