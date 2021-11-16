using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Lavery.Schemas.E3
{
	[Serializable()]

	[XmlRoot("TimeSheet", Namespace = TimeSheet.XmlNamespace)]
	public class TimeSheet
    {
		public const string XmlNamespace = "http://AssiduityProcess.Request";
		public const string XmlNamespacePrefix = "ns0";

		public static XmlSerializerNamespaces XmlSerializerNamespaces
		{
			get
			{
				var namespaces = new XmlSerializerNamespaces();
				namespaces.Add(XmlNamespacePrefix, XmlNamespace);
				// namespaces.Add("xsi", xsi);  Uncomment to add standard namespaces.
				// namespaces.Add("xsd", xsd);
				return namespaces;
			}
		}


		[XmlElement("etypeEnvelopp", Namespace = "")]
		public typeEnvelopp etypeEnvelopp{ get; set; }
		[XmlElement("id", Namespace = "")]
		public int id { get; set; }

		[XmlElement("user_id", Namespace = "")]
		public int user_id { get; set; }		

		[XmlElement("absence_type_id", Namespace = "")]
		public int absence_type_id { get; set; }
		
		[XmlElement("date_from", Namespace = "")]
		public DateTime date_from { get; set; }

		[XmlElement("date_to", Namespace = "")]
		public DateTime date_to { get; set; }

		[XmlElement("nb_hours", Namespace = "")]
		public Decimal nb_hours { get; set; }

		[XmlElement("is_approved", Namespace = "")]
		public Boolean is_approved { get; set; }
		
		[XmlElement("date_received", Namespace = "")]
		public DateTime date_received { get; set; }

		[XmlElement("date_approved", Namespace = "")]
		public DateTime date_approved { get; set; }

		[XmlElement("comment", Namespace = "")]
		public String comment { get; set; }

		[XmlElement("nb_days", Namespace = "")]
		public Decimal nb_days { get; set; }

		[XmlElement("is_supervisor_approved", Namespace = "")]
		public Boolean is_supervisor_approved { get; set; }

		[XmlElement("status", Namespace = "")]
		public String status { get; set; }

		[XmlElement("refGuid", Namespace = "")]
		public Guid refGuid { get; set; }
	}
}
