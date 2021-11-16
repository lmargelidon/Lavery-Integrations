namespace AssiduityFlow {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://AssiduityFlow.Output",@"absence_request")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::AssiduityFlow.PropertySchema.etypeEnvelopp), XPath = @"/*[local-name()='absence_request' and namespace-uri()='http://AssiduityFlow.Output']/*[local-name()='etypeEnvelopp' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"absence_request"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AssiduityFlow.PropertySchema.PropertySchema", typeof(global::AssiduityFlow.PropertySchema.PropertySchema))]
    public sealed class Output : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://AssiduityFlow.Output"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://AssiduityFlow.PropertySchema"" targetNamespace=""http://AssiduityFlow.Output"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://AssiduityFlow.PropertySchema"" location=""AssiduityFlow.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""absence_request"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:etypeEnvelopp"" xpath=""/*[local-name()='absence_request' and namespace-uri()='http://AssiduityFlow.Output']/*[local-name()='etypeEnvelopp' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""etypeEnvelopp"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:string"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""id_origine"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:int"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""absence_request_id"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:int"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""user_id"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:int"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""absence_type_id"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:int"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""date_from"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:dateTime"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""date_to"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:dateTime"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""nb_hours"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:decimal"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_approved"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""date_received"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:dateTime"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""date_approved"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:dateTime"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_exception"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_invisible"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""comment"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:string"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_cancel"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""date_cancellation"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:dateTime"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_denied"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""absence_ref"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:int"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""denied_reason"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:string"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""nb_days"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:decimal"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_deleted"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_supervisor_approved"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_adjustement"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""group_id"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:string"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""is_pending_cancel"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:boolean"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""comment2"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:string"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
        <xs:element name=""schedule_Bitmask"">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base=""xs:int"" />
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Output() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "absence_request";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
