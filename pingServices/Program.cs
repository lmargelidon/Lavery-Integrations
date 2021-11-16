using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LsaInterfaces.WcfServices;
using System.ServiceModel;
using LsaAspects;
using System.Threading;
using LaveryEvents.Propagation; 
using lsaTools.Runtime;  
using LaveryEvent.EventBehavior;
using LaveryEventClass.Classes;
using System.Configuration;
using System.ServiceModel.Configuration;
using lsaTools.GenericInterface;
using lsaTools.ConfigurationManager;
using System.Net;
using lsaTools.AsyncChroneousSocket;
using LaveryEventClass;
using LsaTools.ConfigurationManager;
using LsaTools.DBLibrary;
using LSALibraries.ResManagement;
using Lsa.Tools.XML;
using System.Xml;
using lsaTools.Xml;


namespace pingServices
{
    class Program
    {
        static int Main(string[] args)
        {
            // Exit code is 0 by default (success)
            int exitCode = 0;

            try
            {
                //testUserResources();
                persistEventManager.init();
                Guid oGuid = Guid.NewGuid();

                ServiceDefinition oMgr1 = default(ServiceDefinition);
                ServiceDefinition oMgr = new ServiceDefinition();
                oMgr.oRessourcePingTest = new resourcePingInvokation();
                
                string sResult =  SerializeMessage.serialize(oMgr);
                XmlDocument odoc = new XmlDocument();
                odoc.LoadXml(sResult);
                XmlNode oNode = odoc.LastChild;
                String sClass = oNode.Name;

                SerializeMessage.derialize(ref oMgr1, odoc);

                int i = 0;

                /*
                

                Guid oGuid = Guid.NewGuid();
                //Thread.Sleep(10000);
                TimingAspect oAspect0 = TimingAspect.startTimer();
                int j = 0;
                persistEventManager.logAudit(eActionType.Insert, "Tatarata", "DEV", true, "titi", "asdadsadad", "", "ASEDQERQWRQER", "", oGuid.ToString());
                Thread.Sleep(10);

                while (j++ < 10)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        persistEventManager.logInformation(LsaBusinessFunctions.eCategory.Application, "Tartata", "DEV", "Icite s'tie", oGuid.ToString());
                        //Thread.Sleep(60000);
                    }
                    Thread.Sleep(10);
                }
                persistEventManager.logStatistic("Tartata", "DEV", 100, 200, (int)oAspect0.stop(), oGuid.ToString());
                Thread.Sleep(30000);
                 * */

              /* AsynchronousClient oClient = new AsynchronousClient();
               oClient.StartClient();*/

                /*persistEventManager.logInformation(LsaBusinessFunctions.eCategory.Webservice, "Tartata", "DEV", "Icite s'tie", oGuid.ToString());
                while (true)
                    Thread.Sleep(1000);
                 * */
                Console.WriteLine("----------------------");
                Console.WriteLine("Pinging services tools");
                Console.WriteLine("----------------------");
                
                List<string> endpointNames = sectionManagement.getSectionServiceModelClientEntries();

                Console.WriteLine("Listener number : " + endpointNames.Count.ToString());
                Console.WriteLine("");

                foreach(String sService in endpointNames)
                {
                    TimingAspect oAspect1 = TimingAspect.startTimer();
                    try
                    {
                        ChannelFactory<IWcfClientBase> channelFactory = new ChannelFactory<IWcfClientBase>(sService);
                        IWcfClientBase oOBj = channelFactory.CreateChannel();
                        Console.WriteLine(String.Format("Service {0} responding in {1} millisecondes\nService Statistics are : {2}", sService, oAspect1.stop(), oOBj.PingService(Guid.NewGuid().ToString())));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Service {0} not responding in {1} millisecondes\nException caught: {2}", sService, oAspect1.stop(), ex.Message));
                        // set exit code to 1 to signal that at least on ping failed
                        exitCode = 1;
                    }
                    Console.WriteLine("----------------------");

                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("Exception while setting up ping commands. {0}", e.Message));
            }

            // Return the exit code (useful for automated call that need to know if all pings were succesful) 
            return exitCode;
        }
        static void testUserResources()
        {
            try 
            {
                List<ConnectionStrings> lConnection = LsaTools.ConfigurationManager.ConfigurationManager.getConnectStrings();
                ConnectionStrings oConnDM = null;
                foreach (ConnectionStrings oConn in lConnection)
                {
                    String sEnv = oConn.SLOB;
                    if (sEnv.Equals(eGenerationFromSource.DROOLS_FACTS.ToString(), StringComparison.CurrentCultureIgnoreCase))
                        oConnDM = oConn;
                }

                CDBDataBase pDb1 = new CDBDataBase(oConnDM.EDBType,
                                                    "ListDataBases");
                 List<DBResourceDefinition> lRet1 =  pDb1.getListOfUserTables(oConnDM.SRessourceName);
                 List<DBResourceDefinition> lRet2 = pDb1.getListOfUserViews(oConnDM.SRessourceName);

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        
        }
    }
}
