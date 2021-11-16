
namespace LaveryInboundStream
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LaveryInboundOutboundServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.LaveryInboundOutboundService = new System.ServiceProcess.ServiceInstaller();
            // 
            // LaveryInboundOutboundServiceProcessInstaller
            // 
            this.LaveryInboundOutboundServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.LaveryInboundOutboundServiceProcessInstaller.Password = null;
            this.LaveryInboundOutboundServiceProcessInstaller.Username = null;
            // 
            // LaveryInboundOutboundService
            // 
            this.LaveryInboundOutboundService.Description = "Service for all Inbound Stream To On prem components";
            this.LaveryInboundOutboundService.DisplayName = "Lavery Inbound Outbound Traffic";
            this.LaveryInboundOutboundService.ServiceName = "LaveryInbounStream";
            this.LaveryInboundOutboundService.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.LaveryInboundOutboundServiceProcessInstaller,
            this.LaveryInboundOutboundService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller LaveryInboundOutboundServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller LaveryInboundOutboundService;
    }
}