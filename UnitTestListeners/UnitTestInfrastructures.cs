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
        public void Test_1_StartAll()
        {
            int iValRegistered = 0;
            int iValLoaded = -1;
            try
            {
                System.Configuration.ConfigurationManager.RefreshSection("Assemblies");
                ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");
                Helpers.Start(true, "Unit-Tests");
                iValRegistered = myConfig.getRegistredAssemblies();
                iValLoaded = Helpers.getLoadedAssemblyActif();
            }
            catch (Exception ex)
            {
                iValLoaded = -1;
            }            
            Assert.AreEqual(iValRegistered, iValLoaded);

        }
        
        [TestMethod]
        public void Test_2_UnloadOneAssembly()
        {
            int iValRegistered = 0;
            int iValLoaded = 0;
            try
            {
                System.Configuration.ConfigurationManager.RefreshSection("Assemblies");
                ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");

                myConfig.setActiveInstance("AssiduityServiceBus", false);
                assemblyLoaderHelper oAss;
                int iLoop = 200; 
                while ((oAss = Helpers.getAssembly("AssiduityServiceBus")) != default(assemblyLoaderHelper))
                    {
                        Thread.Sleep(50);
                    if (iLoop-- <= 0)
                        break;
                    }

                iValLoaded = Helpers.getLoadedAssemblyActif(); 

                myConfig = ListenerConfig.getDynamicConfig();
                iValRegistered = myConfig.getRegistredAssemblies();
            }
            catch (Exception ex)
            {
                iValLoaded = -1;
            }
            Assert.AreEqual(iValRegistered , iValLoaded );

        }
        [TestMethod]
        public void Test_3_loadOneAssembly()
        {
            int iValRegistered = 0;
            int iValLoaded = 0;
            try
            {
                System.Configuration.ConfigurationManager.RefreshSection("Assemblies");
                ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");

                

                myConfig.setActiveInstance("AssiduityServiceBus", true);
                assemblyLoaderHelper oAss;
                int iLoop = 200;
                while ((oAss = Helpers.getAssembly("AssiduityServiceBus")) == default(assemblyLoaderHelper))
                {
                    Thread.Sleep(50);
                    if (iLoop-- <= 0)
                        break;
                }
                iValLoaded = Helpers.getLoadedAssemblyActif();

                myConfig = ListenerConfig.getDynamicConfig();
                iValRegistered = myConfig.getRegistredAssemblies();
            }
            catch (Exception ex)
            {
                iValLoaded = -1;
            }
            Assert.AreEqual(iValRegistered, iValLoaded);

        }
       
        [TestMethod]
        public void Test_4_StopAll()
        {   
            int iValLoaded = 0;
            try
            {
                System.Configuration.ConfigurationManager.RefreshSection("Assemblies");
                ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");                
                Helpers.Stop(true);
                iValLoaded = Helpers.getLoadedAssemblyActif();
                               
            }
            catch (Exception ex)
            {
                iValLoaded = -1;
            }
            Assert.AreEqual(iValLoaded, 0);

        }
        [TestMethod]
        public void Test_5_StartAll()
        {
            int iValRegistered = 0;
            int iValLoaded = -1;
            try
            {
                System.Configuration.ConfigurationManager.RefreshSection("Assemblies");
                ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");
                Helpers.Start(true, "Unit-Tests");
                iValRegistered = myConfig.getRegistredAssemblies();

                iValLoaded = Helpers.getLoadedAssemblyActif();
            }
            catch (Exception ex)
            {
                iValLoaded = -1;
            }
            Assert.AreEqual(iValRegistered, iValLoaded);

        }

    }
}
