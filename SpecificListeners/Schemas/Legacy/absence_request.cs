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
	[XmlRoot("absence_request", Namespace = absence_request.XmlNamespace)]
	public class absence_request
	{
		public const string XmlNamespace = "http://AssiduityProcess.Response";
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
		public typeEnvelopp etypeEnvelopp { get; set; }

		[XmlElement("id_origine", Namespace = "")]
		public String id_origine { get; set; }

		[XmlElement("absence_request_id", Namespace = "")]
		public int absence_request_id { get; set; }

		[XmlElement("user_id", Namespace = "")]
		public int user_id { get; set; }

		[XmlElement("userIdString", Namespace = "")]
		public String userIdString { get; set; }

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

		[XmlElement("is_exception", Namespace = "")]
		public Boolean is_exception { get; set; }

		[XmlElement("is_invisible", Namespace = "")]
		public Boolean is_invisible { get; set; }

		[XmlElement("is_cancel", Namespace = "")]
		public Boolean is_cancel { get; set; }

		[XmlElement("is_denied", Namespace = "")]
		public Boolean is_denied { get; set; }

		[XmlElement("date_cancellation", Namespace = "")]
		public DateTime date_cancellation { get; set; }

		[XmlElement("denied_reason", Namespace = "")]
		public String denied_reason { get; set; }

		[XmlElement("absence_ref", Namespace = "")]
		public int absence_ref { get; set; }

		[XmlElement("is_adjustment", Namespace = "")]
		public Boolean is_adjustment { get; set; }

		[XmlElement("nb_days", Namespace = "")]
		public Decimal nb_days { get; set; }

		[XmlElement("is_supervisor_approved", Namespace = "")]
		public Boolean is_supervisor_approved { get; set; }

		[XmlElement("is_deleted", Namespace = "")]
		public Boolean is_deleted { get; set; }

		[XmlElement("group_id", Namespace = "")]
		public Guid group_id { get; set; }

		[XmlElement("comment2", Namespace = "")]
		public String comment2 { get; set; }

		[XmlElement("is_pending_cancel", Namespace = "")]
		public Boolean is_pending_cancel { get; set; }

		[XmlElement("schedule_Bitmask", Namespace = "")]
		public int schedule_Bitmask { get; set; }

		
	}
}
