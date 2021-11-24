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


namespace Lavery.specific.Listeners
{
    public class Helpers
    {
        /*
        public class listenerWrapper : IDisposable
        {
            ListenerBase oBase;            
            ReflectionDataStructures oListenerDS;
            private bool _disposedValue;
            public listenerWrapper(ListenerBase oBase, ReflectionDataStructures oListenerDS)
            {
                this.oBase = oBase;
                this.oListenerDS = oListenerDS;

            }
            ~listenerWrapper() => Dispose(false);

            public Boolean isMe(String sListenerName)
            {
                Boolean bRet = false;
                String [] aElt = oBase.GetType().ToString().Split('.');
                String sBase = aElt[aElt.Length - 1];
                if (sBase.Equals(sListenerName, StringComparison.CurrentCultureIgnoreCase))
                    bRet = true;
                return bRet;
            }
            public ListenerBase OBase { get => oBase; }
            public ReflectionDataStructures OListenerDS { get => oListenerDS;  }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            // Protected implementation of Dispose pattern.
            protected virtual void Dispose(bool disposing)
            {
                if (!_disposedValue)
                {
                    if (disposing)
                    {                       
                        OListenerDS.Dispose();
                    }

                    // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                    // TODO: set large fields to null
                    _disposedValue = true;
                }
            }


        }
        */
        //static private List<listenerWrapper> lListener = new List<listenerWrapper>();
        
        static AppDomain newDomain = null;
        static loaderHelper loader = default(loaderHelper);
        static private ListenerConfig myConfig;
        static private Boolean bStop = false;
        static private Boolean bInit = false;
        static private connectionFactory oCF = new connectionFactory();
       

        public static async Task Start(Boolean bWait, String sServicePrefix, Guid oGuid = default(Guid))
        {   
            bInit = true;
            await buildListeners(sServicePrefix, oGuid);            
        }
        public static void Stop(Boolean bWait)
        {
            /*
            foreach (listenerWrapper oBase in lListener)
                oBase.OBase.stop(bWait);
            */
            foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
            {
                String[] aString = instance.ClassName.Split(';');
                foreach (String sClasse in aString)
                {
                    if (loader.ExecuteMethod(instance.Assembly, sClasse, "IsAlive", null))
                    {
                        Object[] oParam1 = { true };
                        loader.ExecuteMethod(instance.Assembly,  sClasse, "stop", oParam1);
                    }
                }
            }
                    
        }
        private static async Task buildListeners(String sServicePrefix, Guid oGuid = default(Guid))
        {
            await Task.Run(() => {                
                while (!bStop)
                {
                    try
                    {

                        System.Configuration.ConfigurationManager.RefreshSection("Listeners");
                        myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");
                        foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
                        {

                            if (loader == default(loaderHelper))
                            {
                                //FullPath to the Assembly
                                AppDomainSetup setup = AppDomain.CurrentDomain.SetupInformation;
                                newDomain = AppDomain.CreateDomain("newDomain", AppDomain.CurrentDomain.Evidence, setup); //Create an instance of loader class in new appdomain  
                                System.Runtime.Remoting.ObjectHandle obj = newDomain.CreateInstance(typeof(loaderHelper).Assembly.FullName, typeof(loaderHelper).FullName);

                                loader = (loaderHelper)obj.Unwrap();//As the object we are creating is from another appdomain hence we will get that object in wrapped format and hence in the next step we have unwrapped it  
                            }

                            if (!loader.isLoaded(instance.Assembly) &&
                                    instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                            {
                                loader.loadAssembly(instance.Path + instance.Assembly + ".dll", instance.Assembly);

                                String[] aString = instance.ClassName.Split(';');
                                foreach (String sClasse in aString)
                                {

                                    Object[] oParam = { oCF, sServicePrefix, oGuid };
                                    loader.ExecuteConstructor(instance.Assembly, sClasse, oParam);
                                    Object[] oParam1 = { true };
                                    loader.ExecuteMethod(instance.Assembly, sClasse, "start", oParam1);

                                    System.Console.WriteLine(String.Format("\tStart Listener<{0}>", sClasse));
                                }
                            }
                            else
                                if (loader.isLoaded(instance.Assembly) &&
                                    instance.Active.Equals("False", StringComparison.InvariantCultureIgnoreCase))
                            {
                                String[] aString = instance.ClassName.Split(';');
                                foreach (String sClasse in aString)
                                {
                                    Object[] oParam1 = { true };
                                    loader.ExecuteMethod(instance.Assembly, sClasse, "stop", oParam1);
                                }
                                loader.unLoadAssembly(instance.Assembly);
                            }



                            /*
                            ReflectionDataStructures oDs = getReflectionDataStructure(instance);

                            if (!ReflectionAssembly.isAssemblyFullyLoaded(instance.Assembly , oDs != default(ReflectionDataStructures) ? oDs.ODomain: default(AppDomain)) &&
                                instance.Active.Equals("True", StringComparison.InvariantCultureIgnoreCase))
                            {
                                ReflectionAssembly oReflection = ReflectionAssembly.ReflectionBuilder(instance.Path + instance.Assembly + ".dll", instance.Assembly );

                                //*****************************************************************
                                //Voir le stockage du domain direct ou au travers de loaderHelper
                                // ***************************************************************

                                System.Console.WriteLine(String.Format("Load Assembly <{0}> from AppDomaine<{1}>", oReflection.ReflectionDS.OAssembly.FullName, oReflection.ReflectionDS.ODomain.FriendlyName));

                                String[] aString = instance.ClassName.Split(';');
                                foreach (String sClasse in aString)
                                {

                                    Type type = oReflection.GetType(String.Format(@"{1}", instance.NameSpace, sClasse.Trim()));
                                    Boolean bPresent = lListener.Count == 0 ? false : lListener.All(x => x.GetType().Equals(type));
                                    if (!bPresent)
                                    {
                                        ListenerBase oBase = (ListenerBase)Activator.CreateInstance(type, oCF, sServicePrefix, oGuid);
                                        lListener.Add(new listenerWrapper(oBase, oReflection.ReflectionDS));
                                        oBase.start(true);
                                        System.Console.WriteLine(String.Format("\tStart Listener<{0}>", sClasse));
                                    }

                                }

                            }
                            else
                                if (ReflectionAssembly.isAssemblyFullyLoaded(instance.Assembly , oDs != default(ReflectionDataStructures) ? oDs.ODomain : default(AppDomain)) &&
                                    instance.Active.Equals("False", StringComparison.InvariantCultureIgnoreCase))
                                {

                                    if (oDs != default(ReflectionDataStructures))
                                    {
                                        List<listenerWrapper> oSubList = lListener.Where(x => x.OListenerDS == oDs).ToList();
                                        lListener.RemoveAll(x => x.OListenerDS == oDs);
                                        foreach (listenerWrapper oW in oSubList)
                                        {
                                            oW.OBase.stop(true);
                                            oW.OBase.Dispose();
                                        }
                                        System.Console.WriteLine(String.Format("Unload Assembly <{0}> from AppDomaine<{1}> ", oDs.OAssembly.FullName, oDs.ODomain.FriendlyName));

                                        oDs.Dispose();

                                    }
                                    //AppDomain.Unload(instance.Assembly);
                                }
                            }

                            */

                            Thread.Sleep(100);
                        }
                    }
                    catch (Exception ex)
                    { }                
                    }  
                    
               }                
            );

        }
        /*
        static private ReflectionDataStructures getReflectionDataStructure(ListenerSectionElement instance)
        {
            ReflectionDataStructures oRet = default(ReflectionDataStructures);
            String[] aString = instance.ClassName.Split(';');
            
            foreach (String sListener in aString)
            {
                foreach (listenerWrapper oWrapper in lListener)
                    if (oWrapper.isMe(sListener))
                    {
                        oRet = oWrapper.OListenerDS;                        
                        break;
                    }
                if (oRet != default(ReflectionDataStructures))
                {                    
                    break;
                }
            }
            return oRet;
        }
        */
        public static Boolean isOneListenerAlive(List<ListenerBase> Listeners)
        {
            Boolean bRet = false;
            try
            {
                /*
                foreach (ListenerBase oListener in Listeners)
                    if (oListener.IsAlive())
                    {
                        bRet = true;
                        break;
                    }
                */
                foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
                    if (loader.ExecuteMethod(instance.Assembly, "IsAlive", null))
                    {
                        bRet = true;
                        break;
                    }


            }
            catch (Exception ex)
            { }

            return bRet;

        }
        public static Boolean isAllListenerAlive(List<ListenerBase> Listeners)
        {
            Boolean bRet = true;
            try
            {
                /*
                foreach (ListenerBase oListener in Listeners)
                    if (!oListener.IsAlive())
                    {
                        bRet = false;
                        break;
                    }
                */
                foreach (ListenerSectionElement instance in myConfig.ListenerConfigInstances)
                    if (!loader.ExecuteMethod(instance.Assembly, "IsAlive", null))
                    {
                        bRet = true;
                        break;
                    }

            }
            catch (Exception ex)
            { }

            return bRet;

        }
    }
}
