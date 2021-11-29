using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;


namespace Lavery.dynamicConfiguration
{
    public class ListenerConfig : ConfigurationSection
    {
        public static Object oSynchronizeConfig = new object();
        // Create a property that lets us access the collection
        // of SageCRMInstanceElements

        // Specify the name of the element used for the property
        [ConfigurationProperty("instances")]
        // Specify the type of elements found in the collection
        [ConfigurationCollection(typeof(ListenerSectionCollection))]
        public ListenerSectionCollection ListenerConfigInstances
        {
            get
            {
                // Get the collection and parse it
                return (ListenerSectionCollection)this["instances"];
            }
        }
        public static ListenerConfig getDynamicConfig()
        {
            lock (ListenerConfig.oSynchronizeConfig)
            {
                System.Configuration.ConfigurationManager.RefreshSection("Listeners");
            }
            return (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");
        }
        public int getRegistredAssemblies()
        {
            int iRet = 0;
            foreach (ListenerSectionElement instance in ListenerConfigInstances)           
                if (instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                    iRet++;
            return iRet;
        }
        public int getRegistredListeners()
        {
            int iRet = 0;
            
            foreach (ListenerSectionElement instance in ListenerConfigInstances)
                if (instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                {
                    String[] aString = instance.ClassName.Split(';');
                    iRet += aString.Length;
                }
            
            return iRet;
        }
        public void setActiveInstance(String sInstanceName, Boolean bActivity)
        {
            lock (ListenerConfig.oSynchronizeConfig)
            {
                System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
                xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                // System.Xml.XmlNode node;
                // node = xml.SelectSingleNode("configuration/Listeners/instances[name='']");
                XmlNodeList dataNodes = xml.SelectNodes("configuration/Listeners/instances");
                Boolean bBreak = false;
                foreach (XmlNode node in dataNodes)
                {
                    if (bBreak)
                        break;
                    foreach (XmlNode syxn in node.ChildNodes)
                    {
                        if (bBreak)
                            break;
                        if (syxn.NodeType == XmlNodeType.Element)
                        {
                            if (syxn.Attributes["name"].InnerText.Equals(sInstanceName, StringComparison.CurrentCultureIgnoreCase))
                            {
                                syxn.Attributes["active"].InnerText = bActivity ? "True" : "False";
                                bBreak = true;
                            }

                        }
                    }
                }
                xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                System.Configuration.ConfigurationManager.RefreshSection("Listeners");
            }
        }
        public void setActiveInstance(int iLequel, Boolean bActivity)
        {
            lock (ListenerConfig.oSynchronizeConfig)
            {
                System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
                xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                // System.Xml.XmlNode node;
                // node = xml.SelectSingleNode("configuration/Listeners/instances[name='']");
                XmlNodeList dataNodes = xml.SelectNodes("configuration/Listeners/instances");
                Boolean bBreak = false;
                foreach (XmlNode node in dataNodes)
                {
                    if (bBreak)
                        break;
                    foreach (XmlNode syxn in node.ChildNodes)
                    {
                        if (bBreak)
                            break;
                        if (syxn.NodeType == XmlNodeType.Element)
                        {
                            if (iLequel == 0)
                            {
                                syxn.Attributes["active"].InnerText = bActivity ? "True" : "False";
                                bBreak = true;
                            }
                            iLequel--;
                        }
                    }
                }
                xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                System.Configuration.ConfigurationManager.RefreshSection("Listeners");
            }
        }
    }
}