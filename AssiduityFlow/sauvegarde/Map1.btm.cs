namespace AssiduityFlow {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AssiduityFlow.Envelopp", typeof(global::AssiduityFlow.Envelopp))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AssiduityFlow.Schematext", typeof(global::AssiduityFlow.Schematext))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://AssiduityFlow.Schematext"" xmlns:s0=""http://AssiduityFlow.Envelopp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:TimeSheet"" />
  </xsl:template>
  <xsl:template match=""/s0:TimeSheet"">
    <ns0:Root>
      <id>
        <xsl:value-of select=""id/text()"" />
      </id>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AssiduityFlow.Envelopp";
        
        private const global::AssiduityFlow.Envelopp _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AssiduityFlow.Schematext";
        
        private const global::AssiduityFlow.Schematext _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltEngine {
            get {
                return _xsltEngine;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"AssiduityFlow.Envelopp";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"AssiduityFlow.Schematext";
                return _TrgSchemas;
            }
        }
    }
}
