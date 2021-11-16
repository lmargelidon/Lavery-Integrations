using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;



namespace Lavery.Schemas.Legacy
{

	[Serializable()]
	[XmlRoot("Ers_Files_entry", Namespace = Ers_Files_entry.XmlNamespace)]
	public class Ers_Files_entry
	{
		public const string XmlNamespace = "http://Ers_Files_entry.toSend";
		public const string XmlNamespacePrefix = "ns0";

		public static XmlSerializerNamespaces XmlSerializerNamespaces
		{
			get
			{
				var namespaces = new XmlSerializerNamespaces();
				namespaces.Add(XmlNamespacePrefix, XmlNamespace);
				
				return namespaces;
			}
		}


		[XmlElement("etypeEnvelopp", Namespace = "")]
		public typeEnvelopp etypeEnvelopp { get; set; }

		[XmlElement("FilePath", Namespace = "")]
		public String FilePath { get; set; }

		[XmlElement("refGuid", Namespace = "")]
		public Guid refGuid { get; set; }

	}
}
