using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lavery.Tools.Interfaces
{
    public enum ServiceStartMode
    {
        Automatic,
        Boot,
        System,
        Manual,
        Disabled,
    }
    public enum ResourceSecurityAccessType
    {
        Specific = 0,
        localSystemAccount = 1,
        NetworkAccount = 2
    }
    /// <summary>
    /// The return code from the WMI Class Win32_Service
    /// </summary>
    public enum ServiceReturnCode
    {
        Success = 0,
        NotSupported = 1,
        AccessDenied = 2,
        DependentServicesRunning = 3,
        InvalidServiceControl = 4,
        ServiceCannotAcceptControl = 5,
        ServiceNotActive = 6,
        ServiceRequestTimeout = 7,
        UnknownFailure = 8,
        PathNotFound = 9,
        ServiceAlreadyRunning = 10,
        ServiceDatabaseLocked = 11,
        ServiceDependencyDeleted = 12,
        ServiceDependencyFailure = 13,
        ServiceDisabled = 14,
        ServiceLogonFailure = 15,
        ServiceMarkedForDeletion = 16,
        ServiceNoThread = 17,
        StatusCircularDependency = 18,
        StatusDuplicateName = 19,
        StatusInvalidName = 20,
        StatusInvalidParameter = 21,
        StatusInvalidServiceAccount = 22,
        StatusServiceExists = 23,
        ServiceAlreadyPaused = 24,
        NotExecuted = 25,
        ServiceRunning = 26,
        ServiceStopped = 27,
        ServiceUnknown = 28
    }

    /// <summary>
    /// What type of service is it? Most of the time it will be OwnProcess
    /// </summary>
    public enum ServiceType
    {
        KernalDriver = 1,
        FileSystemDriver = 2,
        Adapter = 4,
        RecognizerDriver = 8,
        OwnProcess = 16,
        ShareProcess = 32,
        InteractiveProcess = 256,
    }

    internal enum ServiceErrorControl
    {
        UserNotNotified = 0,
        UserNotified = 1,
        SystemRestartedWithLastKnownGoodConfiguration = 2,
        SystemAttemptsToStartWithAGoodConfiguration = 3
    }
    public interface IWmiAccess
    {
        int InvokeInstanceMethod(string machineName, string className, string name, string methodName);

        /// <summary>
        /// Calls a named instance of WMI on the remote machine invoking a method on a WMI Class
        /// </summary>
        /// <param name="machineName">Name of the computer to perform the operation on</param>
        /// <param name="className">The WMI Class to invoke</param>
        /// <param name="name">The name of the WMI Instance</param>
        /// <param name="methodName">The method to call on the WMI Class</param>
        /// <param name="parameters">Parameters for the method</param>
        /// <returns>A return code from the invoked method on the WMI Class</returns>
        int InvokeInstanceMethod(string machineName, string className, string name, string methodName, object[] parameters);

        int InvokeStaticMethod(string machineName, string className, string methodName);

        /// <summary>
        /// Calls WMI on the remote machine invoking a method on a WMI Class
        /// </summary>
        /// <param name="machineName">Name of the computer to perform the operation on</param>
        /// <param name="className">The WMI Class to invoke</param>
        /// <param name="methodName">The method to call on the WMI Class</param>
        /// <param name="parameters">Parameters for the method</param>
        /// <returns>A return code from the invoked method on the WMI Class</returns>
        int InvokeStaticMethod(string machineName, string className, string methodName, object[] parameters);
    }
}
