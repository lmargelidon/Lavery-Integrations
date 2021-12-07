using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lavery.Listeners;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;
using Lavery.dynamicConfiguration;
using Lavery.Events.Listeners;
using Lavery.Constants;



namespace Lavery.specific.Listeners
{
    public class Helpers
    {
        static List<assemblyLoaderHelper> lAssemblyLoader = new List<assemblyLoaderHelper>();        
        static private Boolean bStop = false;
        static private Boolean bInit = false;
        static private Boolean bStoped = true;
        static private Boolean bAllConfigPassed = false;
        static private connectionFactory oCF = new connectionFactory();
        static Guid oGuid;
        static String sPrefix;

        public static List<assemblyLoaderHelper> LAssemblyLoader { get => lAssemblyLoader; }

        public static assemblyLoaderHelper getAssembly(String sAssemblyname)
        {
            assemblyLoaderHelper oAss = default(assemblyLoaderHelper);
            try
            {
                oAss = LAssemblyLoader.First(m => m.isMe(sAssemblyname));
            }
            catch (Exception ex)
            {

            }

            return oAss;
        }
        public static int getLoadedAssemblyActif()
        {
            int iRet = 0;
            foreach (assemblyLoaderHelper oApp in Helpers.LAssemblyLoader)
            {
                assemblyLoaderHelper oAss_temp = Helpers.getAssembly(oApp.Assembly.GetName().Name);
                int iVal = ReflectionAssembly.isAssemblyFullyLoaded(oApp.Assembly.GetName().Name, oAss_temp.ODomain) ? 1 : 0;
                iRet += iVal;
            }
            return iRet;
        }
    public static void Start(Boolean bWait, String sServicePrefix, Guid oGuid = default(Guid))
        {
            try
            {
                bInit = true;
                bStop = false;
                Helpers.oGuid = oGuid;
                Helpers.sPrefix = sServicePrefix;
                buildListeners(sServicePrefix, oGuid, bWait);
                
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                   oCF.getKeyValueString("Environment"),
                                                   "All Listener started...",
                                                   oGuid.ToString(), sPrefix);
                if (bWait)
                {
                    Thread.Sleep(5000);
                    ListenerConfig myConfig = ListenerConfig.getDynamicConfig();
                    foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
                    {
                        assemblyLoaderHelper loader;
                        if (instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                        {
                            while ((loader = getAssembly(instance.Assembly)) == default(assemblyLoaderHelper))
                            {
                                Thread.Sleep(10);
                            }
                            if (loader != default(assemblyLoaderHelper))
                            {
                                String[] aString = instance.ClassName.Split(';');
                                foreach (String sClasse in aString)
                                {
                                    while (loader.OClassInstance == default(Object))
                                        Thread.Sleep(10);
                                    while (!loader.ExecuteMethod(sClasse.Trim(), "IsAlive", null))
                                        Thread.Sleep(10);
                                }
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                oCF.getKeyValueString("Environment"),
                                                "Exception Catch : " + ex.Message,
                                                oGuid.ToString(), sPrefix);
                throw (ex);
            }

        }
        public static void Stop(Boolean bWait)
        {
            ListenerConfig myConfig = ListenerConfig.getDynamicConfig();
            bStop = true;
            while (!bStoped)
                Thread.Sleep(50);
            foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
            {
                try
                {
                    if (instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                    {
                        assemblyLoaderHelper loader = getAssembly(instance.Assembly);
                        if (loader != default(assemblyLoaderHelper))
                        {
                            String[] aString = instance.ClassName.Split(';');
                            foreach (String sClasse in aString)
                            {
                                if (loader.ExecuteMethod(sClasse.Trim(), "IsAlive", null))
                                {
                                    Object[] oParam1 = { bWait };
                                    loader.ExecuteMethod(sClasse.Trim(), "stop", oParam1);
                                }
                            }
                        }
                        LAssemblyLoader.RemoveAll(m => m.isMe(instance.Assembly));
                        AppDomain.Unload(loader.ODomain);
                    }
                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                    LaveryBusinessFunctions.eBusinessFunction.Stop.ToString(),
                                                    oCF.getKeyValueString("Environment"),
                                                    "All Listener stopped...",
                                                    oGuid.ToString(), sPrefix);
                }
                catch (Exception ex)
                {
                    persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                    LaveryBusinessFunctions.eBusinessFunction.Stop.ToString(),
                                                    oCF.getKeyValueString("Environment"),
                                                    "Exception Catch : " + ex.Message,
                                                    oGuid.ToString(), sPrefix);
                }
            }
        }
       
       
        private static async Task buildListeners(String sServicePrefix, Guid oGuid = default(Guid), Boolean bWait =false)
        {
            await Task.Run(() => {                
                while (!bStop)
                {

                    bStoped = false;
                    ListenerConfig myConfig = ListenerConfig.getDynamicConfig();
                    int iPassed = 0;
                    foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
                    {

                        try
                        {
                            
                            bAllConfigPassed = myConfig.ListenerConfigInstances.Count == iPassed;
                            assemblyLoaderHelper loader = getAssembly(instance.Assembly);
                            if (    loader == default(assemblyLoaderHelper) &&
                                    instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                            {
                                AppDomainSetup setup = AppDomain.CurrentDomain.SetupInformation;
                                AppDomain newDomain = AppDomain.CreateDomain(instance.Assembly + "-Domain", AppDomain.CurrentDomain.Evidence, setup); //Create an instance of loader class in new appdomain  
                                System.Runtime.Remoting.ObjectHandle obj = newDomain.CreateInstance(typeof(assemblyLoaderHelper).Assembly.FullName, typeof(assemblyLoaderHelper).FullName);

                                loader = (assemblyLoaderHelper)obj.Unwrap();//As the object we are creating is from another appdomain hence we will get that object in wrapped format and hence in the next step we have unwrapped it  
                                loader.ODomain = newDomain;
                                loader.loadAssembly(instance.Path + instance.Assembly + ".dll", instance.Assembly);
                                LAssemblyLoader.Add(loader);

                                String[] aString = instance.ClassName.Split(';');
                                foreach (String sClasse in aString)
                                {

                                    Object[] oParam = { oCF, sServicePrefix, oGuid };
                                    loader.ExecuteConstructor( sClasse.Trim(), oParam);
                                    Object[] oParam1 = { bWait };
                                    loader.ExecuteMethod( sClasse.Trim(), "start", oParam1);
                                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                  LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                  oCF.getKeyValueString("Environment"),
                                                  String.Format("Listener {0} started succesfully...", sClasse),
                                                  oGuid.ToString(), sPrefix);

                                    System.Console.WriteLine(String.Format("\tStart Listener<{0}>", sClasse));
                                }
                            }
                            else
                                if (loader != default(assemblyLoaderHelper) &&
                                    instance.Active.Equals("False", StringComparison.InvariantCultureIgnoreCase))
                            {
                                String[] aString = instance.ClassName.Split(';');
                                foreach (String sClasse in aString)
                                {
                                    Object[] oParam1 = { bWait };
                                    loader.ExecuteMethod( sClasse.Trim(), "stop", oParam1);
                                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                 LaveryBusinessFunctions.eBusinessFunction.Stop.ToString(),
                                                 oCF.getKeyValueString("Environment"),
                                                 String.Format("Listener {0} stopped succesfully...", sClasse),
                                                 oGuid.ToString(), sPrefix);
                                }

                                LAssemblyLoader.RemoveAll(m => m.isMe(instance.Assembly));

                                AppDomain.Unload(loader.ODomain);
                            }
                            Thread.Sleep(100);
                            iPassed++;
                        }
                        catch (Exception ex)
                        {
                            persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                       LaveryBusinessFunctions.eBusinessFunction.MainLoop.ToString(),
                                                       oCF.getKeyValueString("Environment"),
                                                       "Exception Catch : " + ex.Message,
                                                       oGuid.ToString(), sPrefix);
                            throw (ex);
                        }
                    }
                    
                }  
                    
               }                
            );
            bStoped = true;

        }
        
        public static Boolean isOneListenerAlive(List<ListenerBase> Listeners)
        {
            Boolean bRet = false;
            try
            {
                ListenerConfig myConfig = ListenerConfig.getDynamicConfig();
                foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
                {
                    assemblyLoaderHelper loader = getAssembly(instance.Assembly);
                    if (loader != default(assemblyLoaderHelper) && loader.ExecuteMethod(instance.Assembly, "IsAlive", null))
                    {
                        bRet = true;
                        break;
                    }

                }

            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.testStatus.ToString(),
                                                oCF.getKeyValueString("Environment"),
                                                "Exception Catch : " + ex.Message,
                                                oGuid.ToString(), sPrefix);
            }

            return bRet;

        }
        public static Boolean isAllListenerAlive(List<ListenerBase> Listeners)
        {
            Boolean bRet = true;
            try
            {
                ListenerConfig myConfig = ListenerConfig.getDynamicConfig();

                foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
                {
                    assemblyLoaderHelper loader = getAssembly(instance.Assembly);
                    
                    if (loader != default(assemblyLoaderHelper) && !loader.ExecuteMethod(instance.Assembly, "IsAlive", null))
                    {
                        bRet = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.testStatus.ToString(),
                                                oCF.getKeyValueString("Environment"),
                                                "Exception Catch : " + ex.Message,
                                                oGuid.ToString(), sPrefix);
            }

            return bRet;

        }
       
    }
}
