using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Runtime.InteropServices;
using Lavery.Listeners;
using Lavery.specific.Listeners;
using Lavery.Events.Listeners;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;

namespace LaveryInboundOutboundStream
{


    public enum ServiceState
    {
        SERVICE_STOPPED = 0x00000001,
        SERVICE_START_PENDING = 0x00000002,
        SERVICE_STOP_PENDING = 0x00000003,
        SERVICE_RUNNING = 0x00000004,
        SERVICE_CONTINUE_PENDING = 0x00000005,
        SERVICE_PAUSE_PENDING = 0x00000006,
        SERVICE_PAUSED = 0x00000007,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ServiceStatus
    {
        public int dwServiceType;
        public ServiceState dwCurrentState;
        public int dwControlsAccepted;
        public int dwWin32ExitCode;
        public int dwServiceSpecificExitCode;
        public int dwCheckPoint;
        public int dwWaitHint;
    };

    public partial class LaveryInboundOutboundService : ServiceBase
    {
        private int eventId = 1;
        
        Guid oGuid;
        connectionFactory OCF;

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool SetServiceStatus(System.IntPtr handle, ref ServiceStatus serviceStatus);

        public LaveryInboundOutboundService()
        {
            InitializeComponent();
            eventLogComponent = new System.Diagnostics.EventLog();
            if (!System.Diagnostics.EventLog.SourceExists("LaveryInboundStreamMain"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "LaveryInboundStreamMain", "LaveryInboundStreamLog");
            }
            eventLogComponent.Source = "LaveryInboundStreamMain";
            eventLogComponent.Log = "LaveryInboundStreamLog";
            OCF = new connectionFactory();
        }

        protected override void OnStart(string[] args)
        {
            persistEventManager.init();

            ServiceStatus serviceStatus = new ServiceStatus();
            serviceStatus.dwCurrentState = ServiceState.SERVICE_START_PENDING;
            serviceStatus.dwWaitHint = 100000;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);

            Timer timer = new Timer();
            timer.Interval = 60000; // 60 seconds
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            timer.Start();

            oGuid = Guid.NewGuid();
            try
            {
                Helpers.Start(true, "Main", oGuid);
            }
            catch (Exception ex)
            { 

            }
           

            eventLogComponent.WriteEntry("LaveryInboundOutboundService Started...");
           
            persistEventManager.logInformation( LaveryBusinessFunctions.eCategory.ListenerInboundService.ToString(), 
                                                LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                OCF.getKeyValueString("Environment"), "LaveryInboundOutboundService Started...", oGuid.ToString(), "ServiceContainer-Main");

            serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);
        }

        protected override void OnStop()
        {
            // Update the service state to Stop Pending.
            ServiceStatus serviceStatus = new ServiceStatus();
            serviceStatus.dwCurrentState = ServiceState.SERVICE_STOP_PENDING;
            serviceStatus.dwWaitHint = 100000;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);


            Helpers.Stop(true);
            
            eventLogComponent.WriteEntry("LaveryInboundOutboundService Stopped...");

            persistEventManager.logInformation( LaveryBusinessFunctions.eCategory.ListenerInboundService.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.Stop.ToString(),
                                                OCF.getKeyValueString("Environment"), 
                                                "LaveryInboundOutboundService Stopped...", oGuid.ToString(), "ServiceContainer-Main");
            // Update the service state to Stopped.
            serviceStatus.dwCurrentState = ServiceState.SERVICE_STOPPED;
            SetServiceStatus(this.ServiceHandle, ref serviceStatus);
        }

        protected override void OnContinue()
        {
            eventLogComponent.WriteEntry("LaveryInboundOutboundService Continue...");
        }
        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            eventLogComponent.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
        }

        private void eventLogComponent_EntryWritten(object sender, EntryWrittenEventArgs e)
        {

        }
    }
}
