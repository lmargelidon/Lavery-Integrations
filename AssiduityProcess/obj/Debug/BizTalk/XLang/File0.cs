
#pragma warning disable 162

namespace AssiduityProcess
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "ReceiTimeSheet",
        new System.Type[]{
            typeof(AssiduityProcess.__messagetype_AssiduityProcess_Request)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class ReceiveRequestAssiduityPort : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public ReceiveRequestAssiduityPort(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public ReceiveRequestAssiduityPort(ReceiveRequestAssiduityPort p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            ReceiveRequestAssiduityPort p = new ReceiveRequestAssiduityPort(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo ReceiTimeSheet = new Microsoft.XLANGs.Core.OperationInfo
        (
            "ReceiTimeSheet",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(ReceiveRequestAssiduityPort),
            typeof(__messagetype_AssiduityProcess_Request),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "ReceiTimeSheet" ] = ReceiTimeSheet;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __AssiduityProcess_Response__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static AssiduityProcess.Response _schema = new AssiduityProcess.Response();

        public __AssiduityProcess_Response__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "AssiduityProcess.Response",
        new System.Type[]{
            typeof(AssiduityProcess.Response)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__AssiduityProcess_Response__)
        },
        0,
        @"http://AssiduityProcess.Response#absence_request"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_AssiduityProcess_Response : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __AssiduityProcess_Response__ part;

        private void __CreatePartWrappers()
        {
            part = new __AssiduityProcess_Response__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_AssiduityProcess_Response(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "TraceRequest",
        new System.Type[]{
            typeof(AssiduityProcess.__messagetype_AssiduityProcess_Request)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class TraceRequestPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public TraceRequestPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public TraceRequestPortType(TraceRequestPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            TraceRequestPortType p = new TraceRequestPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo TraceRequest = new Microsoft.XLANGs.Core.OperationInfo
        (
            "TraceRequest",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(TraceRequestPortType),
            typeof(__messagetype_AssiduityProcess_Request),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "TraceRequest" ] = TraceRequest;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "TraceOutput",
        new System.Type[]{
            typeof(AssiduityProcess.__messagetype_AssiduityProcess_Response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class TraceAssiduityPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public TraceAssiduityPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public TraceAssiduityPortType(TraceAssiduityPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            TraceAssiduityPortType p = new TraceAssiduityPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo TraceOutput = new Microsoft.XLANGs.Core.OperationInfo
        (
            "TraceOutput",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(TraceAssiduityPortType),
            typeof(__messagetype_AssiduityProcess_Response),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "TraceOutput" ] = TraceOutput;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendMessage",
        new System.Type[]{
            typeof(AssiduityProcess.__messagetype_AssiduityProcess_Response)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SendAssiduityPortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SendAssiduityPortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SendAssiduityPortType(SendAssiduityPortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SendAssiduityPortType p = new SendAssiduityPortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendMessage = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendMessage",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SendAssiduityPortType),
            typeof(__messagetype_AssiduityProcess_Response),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendMessage" ] = SendMessage;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 274 "C:\Users\LMargelidon\source\repos\LaveryIntegration\AssiduityProcess\AssiduityProcess.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "ReceiveRequestAssiduity", "ReceiTimeSheet", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(AssiduityProcess.ReceiveRequestAssiduityPort),
            typeof(AssiduityProcess.TraceRequestPortType),
            typeof(AssiduityProcess.TraceAssiduityPortType),
            typeof(AssiduityProcess.SendAssiduityPortType)
        },
        new System.String[] {
            "ReceiveRequestAssiduity",
            "TraceRequestPort",
            "TraceAssiduityPort",
            "SendAssiduityPort"
        },
        new System.Type[] {
            null,
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class AssiduityOrchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(AssiduityOrchestration));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static AssiduityOrchestration()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __AssiduityOrchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public AssiduityOrchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "AssiduityOrchestration", tracker)
        {
            ConstructorHelper();
        }

        public AssiduityOrchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "AssiduityOrchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>94e5934c-b432-492b-ae77-752fe6655b1a</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>acf169b9-9b23-4d03-8c36-54f1fc93d3fa</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ReceiveRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>a8268f05-bafd-4d25-91b4-b82a0577249c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>TraceRequest</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>bee7ae50-1f30-41e8-a786-15a0e7d57f8d</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessageAssiduity</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>5d6b746d-c637-4f3c-a550-0316b1ce5659</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_E3_To_Assiduity</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>01d08299-8380-44f5-8a4e-ff3cf9bb5eef</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ff402644-f812-48c9-be98-88ea2923ce20</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>7314e5bb-b7af-44ff-83cc-4e813a40857d</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1e65927f-671c-4cd1-8cbc-00538050a6be</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>TraceOutput</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>bf58f24f-06b5-473a-a47a-0ad06e2fc4dd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SendAssiduity</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'AssiduityOrchestration'</ActionName><IsAtomic>0</IsAtomic><Line>274</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>289</Line><Position>22</Position><ShapeID>'acf169b9-9b23-4d03-8c36-54f1fc93d3fa'</ShapeID>
<Messages>
	<MsgInfo><name>MessageRequest</name><part>part</part><schema>AssiduityProcess.Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>291</Line><Position>13</Position><ShapeID>'a8268f05-bafd-4d25-91b4-b82a0577249c'</ShapeID>
<Messages>
	<MsgInfo><name>MessageRequest</name><part>part</part><schema>AssiduityProcess.Request</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>293</Line><Position>13</Position><ShapeID>'bee7ae50-1f30-41e8-a786-15a0e7d57f8d'</ShapeID>
<Messages>
	<MsgInfo><name>MessageAssiduity</name><part>part</part><schema>AssiduityProcess.Response</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>MessageRequest</name><part>part</part><schema>AssiduityProcess.Request</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>299</Line><Position>13</Position><ShapeID>'1e65927f-671c-4cd1-8cbc-00538050a6be'</ShapeID>
<Messages>
	<MsgInfo><name>MessageAssiduity</name><part>part</part><schema>AssiduityProcess.Response</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>301</Line><Position>13</Position><ShapeID>'bf58f24f-06b5-473a-a47a-0ad06e2fc4dd'</ShapeID>
<Messages>
	<MsgInfo><name>MessageAssiduity</name><part>part</part><schema>AssiduityProcess.Response</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='3f76c3bb-3868-4fed-9f71-55f810c64613' LowerBound='1.1' HigherBound='64.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='AssiduityProcess' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='9a830fc6-3979-435d-a710-310e58a059b8' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ReceiveRequestAssiduityPort' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='29288c11-0305-4d38-be61-2fba0236b4d6' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiTimeSheet' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='d27a573d-346d-43a8-b4e0-34385987454e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.20'>
                    <om:Property Name='Ref' Value='AssiduityProcess.Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='0f3dcff1-939b-4091-9049-f0a7793c8bbd' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='TraceRequestPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='a36c1849-f67f-4b1a-9c16-93e06fa50c78' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TraceRequest' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='27b066ec-0d1f-4339-b37d-a511b8f75b6b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.20'>
                    <om:Property Name='Ref' Value='AssiduityProcess.Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='c77361ba-768f-482c-96c7-05a4151ae42f' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='TraceAssiduityPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='fc4c670f-6c82-40bf-8fd4-49e553bce9bd' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TraceOutput' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='a7859324-1605-4b4b-8534-0d23b28d2fc7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.21'>
                    <om:Property Name='Ref' Value='AssiduityProcess.Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='70e6a146-c6f5-452d-8bed-5f75597c3633' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SendAssiduityPortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='ceb47dc3-0bc8-486b-b068-1d101a227fd8' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendMessage' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='d22c794d-95ad-4ed5-912a-e8585abae5f4' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.21'>
                    <om:Property Name='Ref' Value='AssiduityProcess.Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='a80a13b6-7b8d-4c10-a54b-93e09cfcc8e3' ParentLink='Module_ServiceDeclaration' LowerBound='32.1' HigherBound='63.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='AssiduityOrchestration' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='ServiceBody' OID='94e5934c-b432-492b-ae77-752fe6655b1a' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='acf169b9-9b23-4d03-8c36-54f1fc93d3fa' ParentLink='ServiceBody_Statement' LowerBound='47.1' HigherBound='49.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='ReceiveRequestAssiduity' />
                    <om:Property Name='MessageName' Value='MessageRequest' />
                    <om:Property Name='OperationName' Value='ReceiTimeSheet' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ReceiveRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='a8268f05-bafd-4d25-91b4-b82a0577249c' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='51.1'>
                    <om:Property Name='PortName' Value='TraceRequestPort' />
                    <om:Property Name='MessageName' Value='MessageRequest' />
                    <om:Property Name='OperationName' Value='TraceRequest' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='TraceRequest' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='bee7ae50-1f30-41e8-a786-15a0e7d57f8d' ParentLink='ServiceBody_Statement' LowerBound='51.1' HigherBound='57.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessageAssiduity' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='5d6b746d-c637-4f3c-a550-0316b1ce5659' ParentLink='ComplexStatement_Statement' LowerBound='54.1' HigherBound='56.1'>
                        <om:Property Name='ClassName' Value='AssiduityProcess.Assiduity' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_E3_To_Assiduity' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='MessagePartRef' OID='01d08299-8380-44f5-8a4e-ff3cf9bb5eef' ParentLink='Transform_InputMessagePartRef' LowerBound='55.76' HigherBound='55.90'>
                            <om:Property Name='MessageRef' Value='MessageRequest' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='ff402644-f812-48c9-be98-88ea2923ce20' ParentLink='Transform_OutputMessagePartRef' LowerBound='55.28' HigherBound='55.44'>
                            <om:Property Name='MessageRef' Value='MessageAssiduity' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='7314e5bb-b7af-44ff-83cc-4e813a40857d' ParentLink='Construct_MessageRef' LowerBound='52.23' HigherBound='52.39'>
                        <om:Property Name='Ref' Value='MessageAssiduity' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='1e65927f-671c-4cd1-8cbc-00538050a6be' ParentLink='ServiceBody_Statement' LowerBound='57.1' HigherBound='59.1'>
                    <om:Property Name='PortName' Value='TraceAssiduityPort' />
                    <om:Property Name='MessageName' Value='MessageAssiduity' />
                    <om:Property Name='OperationName' Value='TraceOutput' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='TraceOutput' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='bf58f24f-06b5-473a-a47a-0ad06e2fc4dd' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='61.1'>
                    <om:Property Name='PortName' Value='SendAssiduityPort' />
                    <om:Property Name='MessageName' Value='MessageAssiduity' />
                    <om:Property Name='OperationName' Value='SendMessage' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SendAssiduity' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='06e89e2a-6a45-4fcc-bafa-c78b289b0c12' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='35.1' HigherBound='37.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AssiduityProcess.ReceiveRequestAssiduityPort' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ReceiveRequestAssiduity' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='707ddf5d-8d52-4412-9a12-c2dc792412d6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='35.1' HigherBound='36.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a538b705-f911-42d7-91e3-62c2af2e963f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='37.1' HigherBound='39.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='11' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AssiduityProcess.TraceRequestPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TraceRequestPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='71a3ace5-a976-49ef-9ac9-763450a26c4e' ParentLink='PortDeclaration_CLRAttribute' LowerBound='37.1' HigherBound='38.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4b33b9d9-ff69-40b6-aef6-4a4cfa50ea9c' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='23' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AssiduityProcess.TraceAssiduityPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TraceAssiduityPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='45e2cd5d-b79f-481c-8b33-4c5454abe229' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='dd781761-a2d1-46d6-ac03-e193b5eba372' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='41.1' HigherBound='43.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='25' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='AssiduityProcess.SendAssiduityPortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendAssiduityPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='b4cb2f7f-bd10-448f-a64e-a8203045bef9' ParentLink='PortDeclaration_CLRAttribute' LowerBound='41.1' HigherBound='42.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='3a7328c5-ab12-4415-bf78-e13207dfb38f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='AssiduityProcess.Request' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageRequest' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c6d12226-90f2-497d-b716-1773b29bef09' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='AssiduityProcess.Response' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageAssiduity' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __AssiduityOrchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __AssiduityOrchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "AssiduityOrchestration")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                AssiduityOrchestration __svc__ = (AssiduityOrchestration)_service;
                __AssiduityOrchestration_root_0 __ctx0__ = (__AssiduityOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.ReceiveRequestAssiduity != null)
                {
                    __svc__.ReceiveRequestAssiduity.Close(this, null);
                    __svc__.ReceiveRequestAssiduity = null;
                }
                if (__svc__.TraceRequestPort != null)
                {
                    __svc__.TraceRequestPort.Close(this, null);
                    __svc__.TraceRequestPort = null;
                }
                if (__svc__.TraceAssiduityPort != null)
                {
                    __svc__.TraceAssiduityPort.Close(this, null);
                    __svc__.TraceAssiduityPort = null;
                }
                if (__svc__.SendAssiduityPort != null)
                {
                    __svc__.SendAssiduityPort.Close(this, null);
                    __svc__.SendAssiduityPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __AssiduityOrchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __AssiduityOrchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "AssiduityOrchestration")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                AssiduityOrchestration __svc__ = (AssiduityOrchestration)_service;
                __AssiduityOrchestration_1 __ctx1__ = (__AssiduityOrchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__MessageRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageRequest);
                    __ctx1__.__MessageRequest = null;
                }
                if (__ctx1__ != null && __ctx1__.__MessageAssiduity != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageAssiduity);
                    __ctx1__.__MessageAssiduity = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageRequest")]
            public __messagetype_AssiduityProcess_Request __MessageRequest;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MessageAssiduity")]
            public __messagetype_AssiduityProcess_Response __MessageAssiduity;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("ReceiveRequestAssiduity")]
        internal ReceiveRequestAssiduityPort ReceiveRequestAssiduity;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("TraceRequestPort")]
        internal TraceRequestPortType TraceRequestPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("TraceAssiduityPort")]
        internal TraceAssiduityPortType TraceAssiduityPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendAssiduityPort")]
        internal SendAssiduityPortType SendAssiduityPort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {ReceiveRequestAssiduityPort.ReceiTimeSheet},
                                               typeof(AssiduityOrchestration).GetField("ReceiveRequestAssiduity", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(AssiduityOrchestration), "ReceiveRequestAssiduity"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {TraceRequestPortType.TraceRequest},
                                               typeof(AssiduityOrchestration).GetField("TraceRequestPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(AssiduityOrchestration), "TraceRequestPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {TraceAssiduityPortType.TraceOutput},
                                               typeof(AssiduityOrchestration).GetField("TraceAssiduityPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(AssiduityOrchestration), "TraceAssiduityPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SendAssiduityPortType.SendMessage},
                                               typeof(AssiduityOrchestration).GetField("SendAssiduityPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(AssiduityOrchestration), "SendAssiduityPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "acf169b9-9b23-4d03-8c36-54f1fc93d3fa", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "acf169b9-9b23-4d03-8c36-54f1fc93d3fa", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "a8268f05-bafd-4d25-91b4-b82a0577249c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "a8268f05-bafd-4d25-91b4-b82a0577249c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "bee7ae50-1f30-41e8-a786-15a0e7d57f8d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "bee7ae50-1f30-41e8-a786-15a0e7d57f8d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "1e65927f-671c-4cd1-8cbc-00538050a6be", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "1e65927f-671c-4cd1-8cbc-00538050a6be", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "bf58f24f-06b5-473a-a47a-0ad06e2fc4dd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "bf58f24f-06b5-473a-a47a-0ad06e2fc4dd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,3,4,5,5,6,7,7,7,8,9,9,9,10,11,11,11,11,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __AssiduityOrchestration_root_0 __ctx0__ = (__AssiduityOrchestration_root_0)_stateMgrs[0];
            __AssiduityOrchestration_1 __ctx1__ = (__AssiduityOrchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                ReceiveRequestAssiduity = new ReceiveRequestAssiduityPort(0, this);
                TraceRequestPort = new TraceRequestPortType(1, this);
                TraceAssiduityPort = new TraceAssiduityPortType(2, this);
                SendAssiduityPort = new SendAssiduityPortType(3, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], ReceiveRequestAssiduity, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __AssiduityOrchestration_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __AssiduityOrchestration_root_0 __ctx0__ = (__AssiduityOrchestration_root_0)_stateMgrs[0];
            __AssiduityOrchestration_1 __ctx1__ = (__AssiduityOrchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!ReceiveRequestAssiduity.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__MessageRequest != null)
                    __ctx1__.UnrefMessage(__ctx1__.__MessageRequest);
                __ctx1__.__MessageRequest = new __messagetype_AssiduityProcess_Request("MessageRequest", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__MessageRequest);
                ReceiveRequestAssiduity.ReceiveMessage(0, __msgEnv__, __ctx1__.__MessageRequest, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (ReceiveRequestAssiduity != null)
                {
                    ReceiveRequestAssiduity.Close(__ctx1__, __seg__);
                    ReceiveRequestAssiduity = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__MessageRequest);
                    __edata.PortName = @"ReceiveRequestAssiduity";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                TraceRequestPort.SendMessage(0, __ctx1__.__MessageRequest, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (TraceRequestPort != null)
                {
                    TraceRequestPort.Close(__ctx1__, __seg__);
                    TraceRequestPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MessageRequest);
                    __edata.PortName = @"TraceRequestPort";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_AssiduityProcess_Response __MessageAssiduity = new __messagetype_AssiduityProcess_Response("MessageAssiduity", __ctx1__);

                    ApplyTransform(typeof(AssiduityProcess.Assiduity), new object[] {__MessageAssiduity.part}, new object[] {__ctx1__.__MessageRequest.part});

                    if (__ctx1__.__MessageAssiduity != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MessageAssiduity);
                    __ctx1__.__MessageAssiduity = __MessageAssiduity;
                    __ctx1__.RefMessage(__ctx1__.__MessageAssiduity);
                }
                __ctx1__.__MessageAssiduity.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MessageAssiduity);
                    __edata.Messages.Add(__ctx1__.__MessageRequest);
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MessageRequest != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageRequest);
                    __ctx1__.__MessageRequest = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                TraceAssiduityPort.SendMessage(0, __ctx1__.__MessageAssiduity, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if (TraceAssiduityPort != null)
                {
                    TraceAssiduityPort.Close(__ctx1__, __seg__);
                    TraceAssiduityPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MessageAssiduity);
                    __edata.PortName = @"TraceAssiduityPort";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SendAssiduityPort.SendMessage(0, __ctx1__.__MessageAssiduity, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (SendAssiduityPort != null)
                {
                    SendAssiduityPort.Close(__ctx1__, __seg__);
                    SendAssiduityPort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MessageAssiduity);
                    __edata.PortName = @"SendAssiduityPort";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MessageAssiduity != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MessageAssiduity);
                    __ctx1__.__MessageAssiduity = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 23;
            case 23:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __AssiduityProcess_Request__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static AssiduityProcess.Request _schema = new AssiduityProcess.Request();

        public __AssiduityProcess_Request__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "AssiduityProcess.Request",
        new System.Type[]{
            typeof(AssiduityProcess.Request)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__AssiduityProcess_Request__)
        },
        0,
        @"http://AssiduityProcess.Request#TimeSheet"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_AssiduityProcess_Request : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __AssiduityProcess_Request__ part;

        private void __CreatePartWrappers()
        {
            part = new __AssiduityProcess_Request__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_AssiduityProcess_Request(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
