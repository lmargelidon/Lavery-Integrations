namespace AssiduityFlow {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://AssiduityFlow.Response",@"absence_request")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"absence_request"})]
    public sealed class Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://AssiduityFlow.Response"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://AssiduityFlow.Response"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""absence_request"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""etypeEnvelopp"" type=""xs:string"" />
        <xs:element name=""id_origine"" type=""xs:int"" />
        <xs:element name=""absence_request_id"" type=""xs:int"" />
        <xs:element name=""user_id"" type=""xs:int"" />
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
