namespace AssiduityFlow {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AssiduityFlow.Envelopp", typeof(global::AssiduityFlow.Envelopp))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"AssiduityFlow.Output", typeof(global::AssiduityFlow.Output))]
    public sealed class AssiduiteMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://AssiduityFlow.Envelopp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:TimeSheet"" />
  </xsl:template>
  <xsl:template match=""/ns0:TimeSheet"">
    <ns0:absence_request>
      <etypeEnvelopp>
        <xsl:value-of select=""etypeEnvelopp/text()"" />
      </etypeEnvelopp>
      <id_origine>
        <xsl:value-of select=""id/text()"" />
      </id_origine>
      <user_id>
        <xsl:value-of select=""user_id/text()"" />
      </user_id>
      <absence_type_id>
        <xsl:value-of select=""absence_type_id/text()"" />
      </absence_type_id>
      <date_from>
        <xsl:value-of select=""date_from/text()"" />
      </date_from>
      <date_to>
        <xsl:value-of select=""date_to/text()"" />
      </date_to>
      <nb_hours>
        <xsl:value-of select=""nb_hours/text()"" />
      </nb_hours>
      <is_approved>
        <xsl:value-of select=""is_approved/text()"" />
      </is_approved>
      <date_received>
        <xsl:value-of select=""date_received/text()"" />
      </date_received>
      <date_approved>
        <xsl:value-of select=""date_approved/text()"" />
      </date_approved>
      <is_exception>
        <xsl:text>false</xsl:text>
      </is_exception>
      <is_invisible>
        <xsl:text>false</xsl:text>
      </is_invisible>
      <comment>
        <xsl:value-of select=""comment/text()"" />
      </comment>
      <is_cancel>
        <xsl:text>false</xsl:text>
      </is_cancel>
      <is_denied>
        <xsl:text>false</xsl:text>
      </is_denied>
      <nb_days>
        <xsl:value-of select=""nb_days/text()"" />
      </nb_days>
      <is_deleted>
        <xsl:text>false</xsl:text>
      </is_deleted>
      <is_supervisor_approved>
        <xsl:value-of select=""is_supervisor_approved/text()"" />
      </is_supervisor_approved>
      <is_adjustement>
        <xsl:text>false</xsl:text>
      </is_adjustement>
      <group_id>
        <xsl:value-of select=""refGuid/text()"" />
      </group_id>
      <is_pending_cancel>
        <xsl:text>false</xsl:text>
      </is_pending_cancel>
      <comment2>
        <xsl:text>abcdef</xsl:text>
      </comment2>
      <schedule_Bitmask>
        <xsl:text>62</xsl:text>
      </schedule_Bitmask>
    </ns0:absence_request>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"AssiduityFlow.Envelopp";
        
        private const global::AssiduityFlow.Envelopp _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"AssiduityFlow.Output";
        
        private const global::AssiduityFlow.Output _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"AssiduityFlow.Output";
                return _TrgSchemas;
            }
        }
    }
}
