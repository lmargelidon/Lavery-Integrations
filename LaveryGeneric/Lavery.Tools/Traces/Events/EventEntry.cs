using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lavery.Tools.Configuration.Management;
namespace Lavery.Events
{
    abstract public class EventEntry
    {
        abstract public EventEntryBase loadEventEntry();
        connectionFactory oConnectionFactory;

        public connectionFactory OConnectionFactory { get => oConnectionFactory; }

        public EventEntry()
        {
            oConnectionFactory = new connectionFactory();
        }

    }
}
