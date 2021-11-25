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
        static private ListenerConfig myConfig;
        static private Boolean bStop = false;
        static private Boolean bInit = false;
        static private connectionFactory oCF = new connectionFactory();
        static Guid oGuid;
        static String sPrefix;

        public static assemblyLoaderHelper getAssembly(String sAssemblyname)
        {
            assemblyLoaderHelper oAss = default(assemblyLoaderHelper);
            try
            {
                oAss = lAssemblyLoader.First(m => m.isMe(sAssemblyname));
            }
            catch (Exception ex)
            {

            }

            return oAss;
        }

        public static async Task Start(Boolean bWait, String sServicePrefix, Guid oGuid = default(Guid))
        {
            try
            {
                bInit = true;
                Helpers.oGuid = oGuid;
                Helpers.sPrefix = sServicePrefix;
                await buildListeners(sServicePrefix, oGuid);
                persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                   oCF.getKeyValueString("Environment"),
                                                   "All Listener started...",
                                                   oGuid.ToString(), sPrefix);

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

            foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
            {
                try
                {
                    assemblyLoaderHelper loader = getAssembly(instance.Assembly);
                    if (loader != default(assemblyLoaderHelper))
                    {
                        String[] aString = instance.ClassName.Split(';');
                        foreach (String sClasse in aString)
                        {
                            if (loader.ExecuteMethod(sClasse, "IsAlive", null))
                            {
                                Object[] oParam1 = { true };
                                loader.ExecuteMethod(sClasse, "stop", oParam1);
                            }
                        }
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
        private static async Task buildListeners(String sServicePrefix, Guid oGuid = default(Guid))
        {
            await Task.Run(() => {                
                while (!bStop)
                {
                    

                    System.Configuration.ConfigurationManager.RefreshSection("Listeners");
                    myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");
                    foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
                    {

                        try
                        {
                            assemblyLoaderHelper loader = getAssembly(instance.Assembly);
                            if (loader == default(assemblyLoaderHelper) &&
                                    instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                            {
                                AppDomainSetup setup = AppDomain.CurrentDomain.SetupInformation;
                                AppDomain newDomain = AppDomain.CreateDomain(instance.Assembly + "-Domain", AppDomain.CurrentDomain.Evidence, setup); //Create an instance of loader class in new appdomain  
                                System.Runtime.Remoting.ObjectHandle obj = newDomain.CreateInstance(typeof(assemblyLoaderHelper).Assembly.FullName, typeof(assemblyLoaderHelper).FullName);

                                loader = (assemblyLoaderHelper)obj.Unwrap();//As the object we are creating is from another appdomain hence we will get that object in wrapped format and hence in the next step we have unwrapped it  
                                loader.ODomain = newDomain;
                                loader.loadAssembly(instance.Path + instance.Assembly + ".dll", instance.Assembly);
                                lAssemblyLoader.Add(loader);

                                String[] aString = instance.ClassName.Split(';');
                                foreach (String sClasse in aString)
                                {

                                    Object[] oParam = { oCF, sServicePrefix, oGuid };
                                    loader.ExecuteConstructor( sClasse, oParam);
                                    Object[] oParam1 = { true };
                                    loader.ExecuteMethod( sClasse, "start", oParam1);
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
                                    Object[] oParam1 = { true };
                                    loader.ExecuteMethod( sClasse, "stop", oParam1);
                                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                 LaveryBusinessFunctions.eBusinessFunction.Stop.ToString(),
                                                 oCF.getKeyValueString("Environment"),
                                                 String.Format("Listener {0} stopped succesfully...", sClasse),
                                                 oGuid.ToString(), sPrefix);
                                }

                                lAssemblyLoader.RemoveAll(m => m.isMe(instance.Assembly));

                                AppDomain.Unload(loader.ODomain);
                            }
                            Thread.Sleep(100);
                        }
                        catch (Exception ex)
                        {
                            persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerHelpper.ToString(),
                                                       LaveryBusinessFunctions.eBusinessFunction.MainLoop.ToString(),
                                                       oCF.getKeyValueString("Environment"),
                                                       "Exception Catch : " + ex.Message,
                                                       oGuid.ToString(), sPrefix);
                        }
                    }
                    
                }  
                    
               }                
            );

        }
        
        public static Boolean isOneListenerAlive(List<ListenerBase> Listeners)
        {
            Boolean bRet = false;
            try
            {                
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
