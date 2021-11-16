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
        static private List<listenerWrapper> lListener = new List<listenerWrapper>();
        static private ListenerConfig myConfig;
        static private Boolean bStop = false;
        static private Boolean bInit = false;
        static private connectionFactory oCF = new connectionFactory();
       

        public static async Task Start(Boolean bWait, String sServicePrefix, Guid oGuid = default(Guid))
        {           
            /*
            if(!bInit)
                AppDomain.CurrentDomain.AssemblyResolve += ReflectionAssembly.assemblyResolve;
            */
            bInit = true;
            await buildListeners(sServicePrefix, oGuid);
            
        }
        public static void Stop(Boolean bWait)
        {
            foreach (listenerWrapper oBase in lListener)
                oBase.OBase.stop(bWait);
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
                            // Write the instance information to the Console
                            /*  Console.WriteLine("{0} {1} {2} {3}",
                              instance.Name,
                              instance.NameSpace,
                              instance.ClassName,
                              instance.Path);
                            */
                            // *****************************
                            // se mettre dans le repertoire cible et loader a partir du repertoire courant..
                            // *****************************
                            if (!ReflectionAssembly.isAssemblyFullyLoaded(instance.Assembly) &&
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
                                if (ReflectionAssembly.isAssemblyFullyLoaded(instance.Assembly) &&
                                    instance.Active.Equals("False", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    String[] aString = instance.ClassName.Split(';');
                                    ReflectionDataStructures oDS = default(ReflectionDataStructures);
                                    foreach (String sListener in aString)
                                    {
                                        foreach (listenerWrapper oWrapper in lListener)
                                            if (oWrapper.isMe(sListener))
                                            {
                                                oDS = oWrapper.OListenerDS;
                                                break;
                                            }
                                        if (oDS != default(ReflectionDataStructures))
                                            break;
                                    }
                                    if (oDS != default(ReflectionDataStructures))
                                    {
                                        List<listenerWrapper> oSubList = lListener.Where(x => x.OListenerDS == oDS).ToList();
                                        lListener.RemoveAll(x => x.OListenerDS == oDS);
                                        foreach (listenerWrapper oW in oSubList)
                                        {
                                            oW.OBase.stop(true);
                                            oW.OBase.Dispose();
                                        }
                                        System.Console.WriteLine(String.Format("Unload Assembly <{0}> from AppDomaine<{1}> ", oDS.OAssembly.FullName, oDS.ODomain.FriendlyName));
                                        
                                        oDS.Dispose();
                                        
                                    }
                                    //AppDomain.Unload(instance.Assembly);
                                }



                                Thread.Sleep(100);

                        }  
                    }
                        catch (Exception ex)
                        { }                
                    }  
                    
               }                
            );

        }
        public static Boolean isOneListenerAlive(List<ListenerBase> Listeners)
        {
            Boolean bRet = false;
            try
            {
                foreach (ListenerBase oListener in Listeners)
                    if (oListener.IsAlive())
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
                foreach (ListenerBase oListener in Listeners)
                    if (!oListener.IsAlive())
                    {
                        bRet = false;
                        break;
                    }

            }
            catch (Exception ex)
            { }

            return bRet;

        }
    }
}
