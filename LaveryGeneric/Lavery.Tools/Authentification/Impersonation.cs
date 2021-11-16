using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.ComponentModel;





namespace Lavery.Tools
{
    /*
    public class Impersonation2:IDisposable
    {

        SafeTokenHandle safeTokenHandle = default(SafeTokenHandle);
        WindowsIdentity oldId = default(WindowsIdentity);
        WindowsIdentity newId = default(WindowsIdentity);
        WindowsImpersonationContext impersonatedUser = default(WindowsImpersonationContext);

       
        private bool disposed = false;
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                
                if (disposing && impersonatedUser != default(WindowsImpersonationContext))
                {
                    impersonatedUser.Undo();
                    impersonatedUser.Dispose();

                }
                if (disposing && newId != default(WindowsIdentity))
                {
                    newId.Dispose();
                }
                if (disposing && oldId != default(WindowsIdentity))
                {
                   // oldId.Impersonate();
                   // oldId.Dispose();

                }
                if (disposing && safeTokenHandle != default(SafeTokenHandle))
                {
                    safeTokenHandle.Dispose();
                }
                // Free your own state (unmanaged objects).
                // Set large fields to null.
                disposed = true;
            }
        }

        // Use C# destructor syntax for finalization code.
        ~Impersonation2()
        {
            // Simply call Dispose(false).
            Dispose (false);
        }



        // Test harness. 
        // If you incorporate this code into a DLL, be sure to demand FullTrust.
        [PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
        public Boolean runAs(String sWithDomainName, String sWithUserName, String sWithPassword)
        {
            Boolean bRet = true;
            
            try
            {
                oldId = WindowsIdentity.GetCurrent();
                

                // Call LogonUser to obtain a handle to an access token. 
                bool returnValue = LogonUser(sWithUserName, sWithDomainName, sWithPassword,
                   LaveryConstants.LOGON32_LOGON_NETWORK_CLEARTEXT, LaveryConstants.LOGON32_PROVIDER_DEFAULT, out safeTokenHandle);
                    //LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,out safeTokenHandle);
                    
               

                if (false == returnValue)
                {
                    int ret = Marshal.GetLastWin32Error();
                    
                    throw new Exception("Logon Failure with error : " + ret.ToString());
                }


                // Use the token handle returned by LogonUser. 
                newId = new WindowsIdentity(safeTokenHandle.DangerousGetHandle());
                WindowsImpersonationContext impersonatedUser = newId.Impersonate();

                WindowsIdentity FinalId = WindowsIdentity.GetCurrent();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bRet;
        }
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword,
            int dwLogonType, int dwLogonProvider, out SafeTokenHandle phToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]        
        public static extern int DuplicateToken(IntPtr hToken, int impersonationLevel,  ref IntPtr hNewToken);
        sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            private SafeTokenHandle()
                : base(true)
            {
            }

            [DllImport("kernel32.dll")]
            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool CloseHandle(IntPtr handle);

            protected override bool ReleaseHandle()
            {
                return CloseHandle(handle);
            }

        }
    } 
    */
    
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    public class Impersonation : IDisposable
    {
        WindowsIdentity oldId = null;
        WindowsIdentity newId = null;

        private readonly SafeTokenHandle _handle;
        private readonly WindowsImpersonationContext _context;
        Boolean bPromtToProvideCredential;

        public static void promptCurrentIdentity()
        {
            WindowsIdentity oldId = WindowsIdentity.GetCurrent();
            //jsonSerializer<WindowsIdentity> oSerial = new jsonSerializer<WindowsIdentity>();
            //String sOut = oSerial.serialize(oldId);
            Console.WriteLine("Name:{0} User:{1} Token:{2} Groups:{3} TypeAuth:{4}", oldId.Name, oldId.User, oldId.Token, oldId.Groups, oldId.AuthenticationType);
        }
        public Impersonation(string domain, string username, string password, Boolean bPromtToProvideCredential = false)
        {
            oldId = WindowsIdentity.GetCurrent();
            Boolean ok;

            if (bPromtToProvideCredential)
                ok = LogonUser(username, domain, password,
                           LaveryConstants.LOGON32_LOGON_INTERACTIVE, 0, out this._handle);
            else
                ok = LogonUser(username, domain, password,
                           LaveryConstants.LOGON_TYPE_NEW_CREDENTIALS, 0, out this._handle);
            if (!ok)
            {
                var errorCode = Marshal.GetLastWin32Error();
                throw new ApplicationException(string.Format("Could not impersonate the elevated user.  LogonUser returned error code {0}.", errorCode));
            }
            newId = new WindowsIdentity(this._handle.DangerousGetHandle());

            this._context = newId.Impersonate();
            Console.WriteLine("After impersonation: "  + WindowsIdentity.GetCurrent().Name);
            WindowsIdentity oldId1 = WindowsIdentity.GetCurrent(); 
        }

        public void Dispose()
        {
            this._context.Undo();
            this._context.Dispose();
            this._handle.Dispose();
            oldId.Impersonate();
            oldId.Dispose();
            newId.Impersonate();
            newId.Dispose();


        }

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword, int dwLogonType, int dwLogonProvider, out SafeTokenHandle phToken);

        public sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
        {
            private SafeTokenHandle()
                : base(true) { }

            [DllImport("kernel32.dll")]
            [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
            [SuppressUnmanagedCodeSecurity]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool CloseHandle(IntPtr handle);

            protected override bool ReleaseHandle()
            {
                return CloseHandle(handle);
            }
        }
    }
    
    
}

