using System;
using System.IO;
using System.Threading;
using System.Transactions;
using Lavery.Listeners;
using Lavery.specific.Listeners;
using System.Collections.Generic;

using Lavery.Events.Listeners;
using Lavery.Events;
using Lavery.Constants;
using Lavery.Tools;

using Lavery.Client.E3;
using Lavery.Schemas.E3;
using System.Reflection;
using Lavery.Tools.Configuration.Management;
using Org.OpenAPITools.Model;
using Newtonsoft.Json;
using System.Messaging;


using Lavery.ClassResponse.Generator;
using Lavery.Wcf.Core;
using EF.Entities.management;





/*
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;

using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
*/

namespace SqlDependency
{
    public class Program
    {
        static void getClassInformations(Type t)
        {
            foreach (FieldInfo f in t.GetFields())
            {

                Console.WriteLine("\t{0}", f.Name);
            }

            Console.WriteLine("\t***********");

            foreach (MethodInfo f  in t.GetMethods())
            {

                Console.WriteLine("\t{0}", f.Name);
            }
            
        }
        private static Boolean  createClientl(String clientId, String clientName , String domainName, String userId, String passWord)
        {
            Boolean bRet = true;
           
            
            /*    
            using (Impersonation oImpersonate = new Impersonation(domainName, userId, passWord))
            {
                try
                {
                    ClientApiFacade oDFacade1 = new ClientApiFacade(new connectionFactory());
                    E3EAPIClientModelsClientGetResponse oResponse1 = oDFacade1.ClientGetClients((new ClientGetClientsRequest() { clientIndex = 1 }));
                }
                catch (Exception ex)
                {
                    bRet = false;
                    Console.WriteLine(ex.Message);
                }
            }
            */
            return bRet;
        }
        static public void send(MessageQueue rmQ, String sMessage)
        {

            try
            {
                if (rmQ == default(MessageQueue))
                    throw (new Exception("MSMQ not Accessible"));

                if (rmQ.Transactional == true)
                {
                    MessageQueueTransaction transaction = new MessageQueueTransaction();
                    try
                    {
                        // Begin the transaction.
                        transaction.Begin();
                        
                        // Send the message.
                        rmQ.Send(sMessage, transaction);

                        // Commit the transaction.
                        transaction.Commit();
                    }
                    catch (MessageQueueException e)
                    {
                        transaction.Abort();

                        throw e;
                        // Handle other sources of MessageQueueException.
                    }
                    catch (System.Exception e)
                    {
                        // Cancel the transaction.
                        transaction.Abort();

                        // Propagate the exception.
                        throw e;
                    }
                    finally
                    {
                        // Dispose of the transaction object.
                        transaction.Dispose();
                    }
                }
                
            }
            catch (System.Exception e)
            {
                throw e;
            }


        }
        
        public static void Main(string[] args)
        {

            //createClientl("Client1-lkasjd","TestClient 1","LBTREE", "EliteTestA", "Pr0pul$10n");
            //createClientl("Client2-lkasjd", "TestClient 2", "LBTREE", "EliteTestB", "Pr0pul$10n");
            //createClientl("Client3-lkasjd", "TestClient 3", "LBTREE", "lmargelidon", "Dorianlola1$");

            //E3EAPIAttachmentModelsAttachmentCreateResponse AttachmentUploadDMSAttachment(AttachmentUploadDMSAttachmentRequest oClassRequestValue)
            //E3EAPIClientModelsClientGetResponse oResponse1 = oFacade.ClientGetClients((new ClientGetClientsRequest() { ClientIndex = 74 }));

            //ClientApiFacade oFacade = new ClientApiFacade(new connectionFactory());
            //E3EAPIClientModelsClientGetResponse oResponse1 = oFacade.ClientGetClients((new ClientGetClientsRequest() { number = "10073" }));


            const string filePath = @".\json.txt";

            TimeCard timeCard = new TimeCard()
            {
                TimecardID = Guid.NewGuid(),
                TimeIndex=1450,
                OrigTimeIndex = 24,
                IsActive = 36,
                Office= "Lavery",
                WorkDate = DateTime.Now,
                PostDate = DateTime.Now,
                Currency = "CAD"

            };
            /*
            jsonSerializer<TimeCard> oSeial = new jsonSerializer<TimeCard>();

            String sValue = oSeial.serialize(timeCard);
            TimeCard oSuite = oSeial.deserialize(sValue);
            using (TransactionScope scope = new TransactionScope())
            {
                //using (MessageQueue rmQ1 = new MessageQueue(@".\private$\System.Lavery.assiduitydPending"))
                using (MessageQueue rmQ2 = new MessageQueue(@".\private$\System.Lavery.assiduitydValidate"))
                {
                    
                    //rmQ1.Send("aaaaaaaaaaaaaaaaa", MessageQueueTransactionType.Automatic);
                    rmQ2.Send(sValue,  MessageQueueTransactionType.Automatic);
                }                
            }
           
            using (MessageQueue rmQ2 = new MessageQueue(@".\private$\System.Lavery.assiduitydValidate"))
            {
                send(rmQ2, sValue);
            }
            */
            /*

            TimeApiFacade oFacade = new TimeApiFacade(new connectionFactory());
            TimeGetPendingTimecardsRequest oParam = new TimeGetPendingTimecardsRequest() { startDate = new DateTime(2021, 11, 7), timekeeperNumber = "1014" };            
            E3EAPITimeModelsTimecardGetResponse oResponse = oFacade.TimeGetPendingTimecards(oParam);

            TimeGetTimeCaptureAllCardsRequest oParam1 = new TimeGetTimeCaptureAllCardsRequest() { startDate = new DateTime(2021, 11, 7), timekeeperNumber = "1014" };
            E3EAPITimeModelsTimecardGetAllResponse oResponse1 = oFacade.TimeGetTimecards(oParam1);
            */



            //ListenerConfig myConfig = (ListenerConfig)Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");
            //Lavery.Tools.Configuration.Management.ConfigurationManager.GetSection<ListenerConfig>("Listeners");

            /*
            ReflectionAssembly oReflection = new ReflectionAssembly();
            oReflection.loadAssembly(@"C:\Users\LMargelidon\source\repos\LaveryIntegration\APIs\Lavery.E3\src\Org.OpenAPITools\bin\Debug\Org.OpenAPITools.dll");
            oReflection.GenerateTypes(@"C:\Users\LMargelidon\source\repos\LaveryIntegration\APIs\Lavery.Client.E3\ApiFacade", "Lavery.Client.E3");
            */




            /*
            ClientStorageBlobs oBlob = new ClientStorageBlobs(new connectionFactory(), "laverycontainer");
            oBlob.Open("blobessai2");
            String fFileName = @"C:\Integrations\services\OutBoundMessages\Assisuity{C6B43D00-9C85-4EF2-AACB-8347BB39D7D1}.xml";
            byte[] oByte;
            if (File.Exists(fFileName))
            {
                    oByte = File.ReadAllBytes(fFileName);
                    oBlob.sendMsg(oByte);
            }
            oBlob.Close(false);
            */
            /*
            ServiceRelayServer oServer = new ServiceRelayServer(new connectionFactory(), null);
            oServer.Open("ConnectionServiceRelay");
            oServer.HybridConnectionName = "AssiduiteServiceRelayHip";
            while (true)
            {
                Thread.Sleep(500);
            }
            */
            /*
            String StrPath = @".\ListenerAssiduite.dll";
            AppDomain newDomain = null;
            loaderHelper loader = default(loaderHelper) ;
            try
            {
                //FullPath to the Assembly
                AppDomainSetup setup = AppDomain.CurrentDomain.SetupInformation;
                newDomain = AppDomain.CreateDomain("newDomain", AppDomain.CurrentDomain.Evidence, setup); //Create an instance of loader class in new appdomain  
                System.Runtime.Remoting.ObjectHandle obj = newDomain.CreateInstance(typeof(loaderHelper).Assembly.FullName, typeof(loaderHelper).FullName);

                loader = (loaderHelper)obj.Unwrap();//As the object we are creating is from another appdomain hence we will get that object in wrapped format and hence in the next step we have unwrapped it  

                //Call loadassembly method so that the assembly will be loaded into the new appdomain and the object will also remain in the new appdomain only.  
                loader.loadAssembly(StrPath, "ListenerAssiduite");
                Object[] oParam = { new connectionFactory(), "main", Guid.NewGuid() };

                loader.ExecuteConstructor("ListenerAssiduite", "MsSqlTimeCardPendingEvents", oParam);

                //Call exceuteMethod and pass the name of the method from assembly and the parameters.  
                try
                {
                    Object[] oParam1 = { true };
                    loader.ExecuteMethod("ListenerAssiduite", "start", oParam1);

                    while (loader.ExecuteMethod("ListenerAssiduite", "IsAlive", null))
                        Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Catched : {0}", ex.Message);
                }

                //ReflectionAssembly.isAssemblyFullyLoaded("AssiduityServiceBus", newDomain);
                loader.isLoaded("AssiduityServiceBus");

            }
            finally
            {
                loader.unLoadAssembly("AssiduityServiceBus");
                //AppDomain.Unload(newDomain);
                ReflectionAssembly.isAssemblyFullyLoaded("AssiduityServiceBus", newDomain);
            }
            */
            //int x = (int)Math.Ceiling((double)12 / (double)8);




           
            persistEventManager.init();
            Guid oGuid = Guid.NewGuid();
            LaveryReflection.getHashCode(@"C:\Integrations\services\OutboundErsNet\Assisuity{9D0EEF19-646C-4690-A828-ABC85E8C2899}.xml");

            connectionFactory oCF = new connectionFactory();
            
            //Helpers.Start(true, "S1");
            
            MattersManagement oMatter = new MattersManagement();
            /*
            persistEventManager.logInformation( LaveryBusinessFunctions.eCategory.ListenerConsoleService.ToString(),                 
                                                LaveryBusinessFunctions.eBusinessFunction.None.ToString(), oCF.getKeyValueString("Environment"), 
                                                "Icite s'tie", oGuid.ToString());
           */
            Boolean bLoop = true;
            int i = 10;

            List<String> lDirectRelation = new List<String>();            
            List<String> lInverseRelation = new List<String>();
            lInverseRelation.Add("MattBudget");
            lInverseRelation.Add("InvMaster");
            
            EntitiesGenerator oEntitiesGenerator = new EntitiesGenerator(oCF, LaverySql.sSqlForThreeEntities, "Matter", lInverseRelation, lDirectRelation);
            oEntitiesGenerator.doJob("Notarier", "Lavery.OData.Notarier", false);
            


            //genereAllResponsesClasses oGEneration = new genereAllResponsesClasses(oCF, "WcfResApiResponseGenerationPath");
            //oGEneration.doJob("ConnectionSource", "Lavery.Wcf.Core");


            while (bLoop)
                    {
                    //genericResponse oRep = oMatter.getMatters(i++);
                    ConsoleKeyInfo key = Console.ReadKey();
                
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            Console.WriteLine("You pressed Esc to leave!");
                            Helpers.Stop(true);
                            bLoop = false;
                            break;
                        default:
                            break;
                    }
                }
            
          /*  
            var connectionString = string.Empty;
            ConsoleKeyInfo consoleKeyInfo;
            var originalForegroundColor = Console.ForegroundColor;

            //do
            //{
            Console.Clear();

            Console.Write("TableDependency, SqlTableDependency");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" (.NET Core)");
            Console.ForegroundColor = originalForegroundColor;
            Console.WriteLine("Copyright (c) 2015-2020 Christian Del Bianco.");
            Console.WriteLine("All rights reserved." + Environment.NewLine);
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine(" - ESC to exit");
            Console.WriteLine("**********************************************************************************************");

            consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.Escape) Environment.Exit(0);

            //} while (consoleKeyInfo.Key != ConsoleKey.F4 && consoleKeyInfo.Key != ConsoleKey.F5);

            Console.ResetColor();
            connectionString = @"Data Source=localhost;Initial Catalog=LaveryE3Mok;User Id=TestNotification; Password=Dorianlola2$";

            // Mapper for DB columns not matching Model's columns
            var mapper = new ModelToTableMapper<Product>();
            mapper.AddMapping(c => c.status, "status");
            
            // As table name (Products) does not match model name (Product), its definition is needed.
            using (var dep = new SqlTableDependency<Product>(connectionString, "produit", mapper: mapper, includeOldValues: true))
            {
                dep.OnChanged += Changed;
                dep.OnError += OnError;
                //dep.OnStatusChanged += OnStatusChanged;

                dep.Start();

                Console.WriteLine();
                Console.WriteLine("Waiting for receiving notifications (db objects naming: " + dep.DataBaseObjectsNamingConvention + ")...");
                Console.WriteLine("Press a key to stop.");
                Console.ReadKey();
            }
        }

        private static void OnError(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Error?.Message);
            Console.ResetColor();
        }

        private static void OnStatusChanged(object sender, StatusChangedEventArgs e)
        {
            Console.WriteLine(Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"SqlTableDependency Status = {e.Status.ToString()}");
            Console.ResetColor();
        }

        private static void Changed(object sender, RecordChangedEventArgs<Product> e)
        {
            Console.WriteLine(Environment.NewLine);


            if (e.ChangeType == ChangeType.Insert)
            {
                var changedEntity = e.Entity;
                Console.WriteLine("Id (Inserted): " + changedEntity.Id);
                Console.WriteLine("Name(Inserted): " + changedEntity.Name);
                Console.WriteLine("Designation(Inserted): " + changedEntity.Description);
                Console.WriteLine("pu(Inserted): " + changedEntity.pu);
                Console.WriteLine("status(Inserted): " + changedEntity.status);
            }
            else
            {
                if (e.ChangeType != ChangeType.None)
                {
                    var changedEntity = e.Entity;
                    Console.WriteLine("Id: " + changedEntity.Id);
                    Console.WriteLine("Name: " + changedEntity.Name);
                    Console.WriteLine("Designation: " + changedEntity.Description);
                    Console.WriteLine("pu: " + changedEntity.pu);
                    Console.WriteLine("status: " + changedEntity.status);
                }

                if (e.ChangeType == ChangeType.Update && e.EntityOldValues != null)
                {
                    Console.WriteLine(Environment.NewLine);

                    var changedEntity = e.EntityOldValues;
                    Console.WriteLine("Id (OLD): " + changedEntity.Id);
                    Console.WriteLine("Name (OLD): " + changedEntity.Name);
                    Console.WriteLine("Designation(OLD): " + changedEntity.Description);
                    Console.WriteLine("pu(OLD): " + changedEntity.pu);
                    Console.WriteLine("status(OLD): " + changedEntity.status);
                }
            }
       */     
        }   
          
       
    }

}
