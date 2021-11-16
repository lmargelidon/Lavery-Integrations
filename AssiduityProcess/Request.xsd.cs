namespace AssiduityProcess {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://AssiduityProcess.Request",@"TimeSheet")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"TimeSheet"})]
    public sealed class Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://AssiduityProcess.Request"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://AssiduityProcess.Request"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""TimeSheet"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""etypeEnvelopp"" type=""xs:string"" />
        <xs:element name=""id"" type=""xs:int"" />
        <xs:element name=""user_id"" type=""xs:int"" />
        <xs:element name=""absence_type_id"" type=""xs:int"" />
        <xs:element name=""date_from"" type=""xs:dateTime"" />
        <xs:element name=""date_to"" type=""xs:dateTime"" />
        <xs:element name=""nb_hours"" type=""xs:decimal"" />
        <xs:element name=""is_approved"" type=""xs:boolean"" />
        <xs:element name=""date_received"" type=""xs:dateTime"" />
        <xs:element name=""date_approved"" type=""xs:dateTime"" />
        <xs:element name=""comment"" type=""xs:string"" />
        <xs:element name=""nb_days"" type=""xs:decimal"" />
        <xs:element name=""is_supervisor_approved"" type=""xs:boolean"" />
        <xs:element name=""status"" type=""xs:string"" />
        <xs:element name=""refGuid"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Request() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "TimeSheet";
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
