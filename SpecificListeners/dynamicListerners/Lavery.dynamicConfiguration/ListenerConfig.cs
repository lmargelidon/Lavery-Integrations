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
        public int getRegistrtedAssemblies()
        {
            int iRet = 0;
            foreach (ListenerSectionElement instance in ListenerConfigInstances)           
                if (instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                    iRet++;
            return iRet;
        }
        public int getRegistrtedListeners()
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
            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            // System.Xml.XmlNode node;
            // node = xml.SelectSingleNode("configuration/Listeners/instances[name='']");
            XmlNodeList dataNodes = xml.SelectNodes("configuration/Listeners/instances");
            foreach (XmlNode node in dataNodes)
            {
                foreach (XmlNode syxn in node.ChildNodes)
                {
                    if (syxn.NodeType == XmlNodeType.Element)
                    {
                        if (syxn.Attributes["name"].InnerText.Equals(sInstanceName, StringComparison.CurrentCultureIgnoreCase ))
                        {                           
                            syxn.Attributes["active"].InnerText = bActivity ? "True" : "False";
                            return;
                        }
                        
                    }
                }
            }
            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

        }
        public void setActiveInstance(int iLequel, Boolean bActivity)
        {          
            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            // System.Xml.XmlNode node;
            // node = xml.SelectSingleNode("configuration/Listeners/instances[name='']");
            XmlNodeList dataNodes = xml.SelectNodes("configuration/Listeners/instances");
            foreach(XmlNode node in dataNodes)
            {
                foreach (XmlNode syxn in node.ChildNodes)
                {
                    if (syxn.NodeType == XmlNodeType.Element)
                    {
                        if (iLequel == 0)
                        {                            
                            syxn.Attributes["active"].InnerText = bActivity ? "True" : "False";
                            return;
                        }
                        iLequel--;
                    }
                }
            }               
            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}