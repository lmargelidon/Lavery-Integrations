using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lavery.specific.Listeners;
using Lavery.Listeners;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;
using Lavery.dynamicConfiguration;
using System.Threading;

namespace UnitTestAssemblies
{
    [TestClass]
    public class UnitTestInfrastructures
    {
        [TestMethod]
        public void TestStartAssemblies()
        {
            int iValRegistered = 0;
            int iValLoaded = -1;
            try
            {
                System.Configuration.ConfigurationManager.RefreshSection("Assemblies");
                ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");
                Helpers.Start(true, "S1");
                iValRegistered = myConfig.getRegistrtedAssemblies();

                iValLoaded = 0;
                foreach (assemblyLoaderHelper oApp in Helpers.LAssemblyLoader)
                    iValLoaded = ReflectionAssembly.isAssemblyFullyLoaded(oApp.Assembly.GetName().Name)  ? 1 : 0;
            }
            catch (Exception ex)
            {
                iValLoaded = -1;
            }            
            Assert.AreEqual(iValRegistered, iValLoaded);

        }
        
        [TestMethod]
        public void TestUnloadOneAssembly()
        {
            int iValRegistered = 0;
            int iValLoaded = -1;
            try
            {
                System.Configuration.ConfigurationManager.RefreshSection("Assemblies");
                ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");                
                iValRegistered = myConfig.getRegistrtedAssemblies();
                iValLoaded = Helpers.LAssemblyLoader.Count;
                myConfig.setActiveInstance("AssiduityServiceBus", false);
                while (ReflectionAssembly.isAssemblyFullyLoaded("AssiduityServiceBus"))
                {
                    Thread.Sleep(50);
                }
                iValLoaded += !ReflectionAssembly.isAssemblyFullyLoaded("AssiduityServiceBus") ? -1 : 0; ;
            }
            catch (Exception ex)
            {
                iValLoaded = -1;
            }
            Assert.AreEqual(iValRegistered - 1, iValLoaded );

        }
        /*
        [TestMethod]
        public void TestStopAssemblies()
        {   
            int iValLoaded = -1;
            try
            {
                System.Configuration.ConfigurationManager.RefreshSection("Assemblies");
                ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");                
                Helpers.Stop(true);
                iValLoaded = Helpers.LAssemblyLoader.Count;

            }
            catch (Exception ex)
            {
                iValLoaded = -1;
            }
            Assert.AreEqual(iValLoaded, 0);

        }
        */
    }
}
