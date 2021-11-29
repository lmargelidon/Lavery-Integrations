using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
 
namespace Lavery.dynamicConfiguration
{
    public class ListenerSectionElement : ConfigurationElement
    {   
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                // Return the value of the 'name' attribute as a string
                return (string)base["name"];
            }
            set
            {
                // Set the value of the 'name' attribute
                base["name"] = value;
            }
        }

        [ConfigurationProperty("nameSpace", IsRequired = true)]
        public string NameSpace
        {
            get
            {
                // Return the value of the 'server' attribute as a string
                return (string)base["nameSpace"];
            }
            set
            {
                // Set the value of the 'server' attribute
                base["nameSpace"] = value;
            }
        }

        [ConfigurationProperty("className", IsRequired = true)]
        public string ClassName
        {
            get
            {
                // Return the value of the 'server' attribute as a string
                return (string)base["className"];
            }
            set
            {
                // Set the value of the 'server' attribute
                base["path"] = value;
            }
        }

        [ConfigurationProperty("path", IsRequired = true)]
        public string Path
        {
            get
            {
                // Return the value of the 'server' attribute as a string
                return (string)base["path"];
            }
            set
            {
                // Set the value of the 'server' attribute
                base["path"] = value;
            }
        }
        [ConfigurationProperty("assembly", IsRequired = true)]
        public string Assembly
        {
            get
            {
                // Return the value of the 'server' attribute as a string
                return (string)base["assembly"];
            }
            set
            {
                // Set the value of the 'server' attribute
                base["assembly"] = value;
            }
        }
        [ConfigurationProperty("active", IsRequired = true, DefaultValue = "True")]        
        public String Active
        {
            get
            {
                // Return the value of the 'server' attribute as a string
                return (String)base["active"];
            }
            set
            {
                // Set the value of the 'server' attribute
                base["active"] = value;
            }
        }
    }
}