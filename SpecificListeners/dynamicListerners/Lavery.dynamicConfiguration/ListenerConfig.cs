using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
    }
}