namespace AssiduityProcess {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://AssiduityProcess.Response",@"absence_request")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"absence_request"})]
    public sealed class Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://AssiduityProcess.Response"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://AssiduityProcess.PropertySchema"" targetNamespace=""http://AssiduityProcess.Response"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""absence_request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""etypeEnvelopp"" type=""xs:string"" />
        <xs:element name=""id_origine"" type=""xs:int"" />
        <xs:element default=""0"" name=""absence_request_id"" nillable=""true"" type=""xs:int"" />
        <xs:element name=""user_id"" type=""xs:int"" />
        <xs:element name=""absence_type_id"" type=""xs:int"" />
        <xs:element name=""date_from"" type=""xs:dateTime"" />
        <xs:element name=""date_to"" type=""xs:dateTime"" />
        <xs:element name=""nb_hours"" type=""xs:decimal"" />
        <xs:element name=""is_approved"" type=""xs:boolean"" />
        <xs:element name=""date_received"" type=""xs:dateTime"" />
        <xs:element name=""date_approved"" type=""xs:dateTime"" />
        <xs:element name=""is_exception"" type=""xs:boolean"" />
        <xs:element name=""is_invisible"" type=""xs:boolean"" />
        <xs:element name=""comment"" type=""xs:string"" />
        <xs:element name=""is_cancel"" type=""xs:boolean"" />
        <xs:element name=""date_cancellation"" type=""xs:dateTime"" />
        <xs:element name=""is_denied"" type=""xs:boolean"" />
        <xs:element name=""absence_ref"" type=""xs:int"" />
        <xs:element name=""denied_reason"" type=""xs:string"" />
        <xs:element name=""nb_days"" type=""xs:decimal"" />
        <xs:element name=""is_deleted"" type=""xs:boolean"" />
        <xs:element name=""is_supervisor_approved"" type=""xs:boolean"" />
        <xs:element name=""is_adjustement"" type=""xs:boolean"" />
        <xs:element name=""group_id"" type=""xs:string"" />
        <xs:element name=""is_pending_cancel"" type=""xs:int"" />
        <xs:element name=""comment2"" type=""xs:string"" />
        <xs:element default=""62"" name=""schedule_Bitmask"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Response() {
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
