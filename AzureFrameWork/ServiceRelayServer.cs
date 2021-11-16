using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Relay;
using Lavery.Tools.Configuration.Management;


namespace Lavery.azure.resources
{
    public class ServiceRelayServer: AzureBase
    {

        HybridConnectionListener oListener;
        String sHybridConnectionName;

        Boolean bStopListening = false;
        CancellationTokenSource cts;

        StreamReader reader;
        StreamWriter writer;

        delegateFonction oDelegateAction;

        public bool BStopListening { get => bStopListening; set => bStopListening = value; }
        public string HybridConnectionName { get => sHybridConnectionName; set => sHybridConnectionName = value; }

        public ServiceRelayServer(connectionFactory oConnectionFactory, delegateFonction oDelegateAction) : base(oConnectionFactory)
        {
            this.oDelegateAction = oDelegateAction;
           
        }

        public override Boolean Open(String sWithName)
        {
            Boolean bRet = true;
            try
            {                
                oListener = new HybridConnectionListener(OConnectionFactory.ConnectionString(sWithName));                
                RunAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception catched : " + ex.Message);
                throw (ex);
            }
            return bRet;

        }
        public Boolean canStop()
        {
            Boolean bRet = false;
            try
            {
                if (bStopListening)
                {
                    if(writer != default(StreamWriter))
                        writer.WriteLineAsync(default(String));
                    cts.Cancel();
                    bRet = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception catched : " + ex.Message);
                throw (ex);
            }
            return bRet;

        }
        public override Boolean Close(Boolean bForDeletion)
        {
            Boolean bRet = true;
            try
            {
                bStopListening = true;
                while (oListener.IsOnline)
                    Thread.Sleep(100);
                Console.WriteLine("\t\t\tListener OffLine...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception catched : " + ex.Message);
                throw (ex);
            }
            return bRet;

        }
        private  async Task RunAsync()
        {
            cts = new CancellationTokenSource();            

            // Subscribe to the status events.
            oListener.Connecting += (o, e) => { Console.WriteLine("\t\t\tService Relay listener Connecting"); };
            oListener.Offline += (o, e) => { Console.WriteLine("\t\t\tService Relay listener Offline"); };
            oListener.Online += (o, e) => { Console.WriteLine("\t\t\tService Relay listener Online"); };

            await oListener.OpenAsync(cts.Token);
            Console.WriteLine("\t\t\tServer listening Relay");


            cts.Token.Register(() =>   oListener.CloseAsync(CancellationToken.None));

            Action<Object> action = (Object oObj) =>
            {
               while(!((ServiceRelayServer)oObj).canStop())
                    Thread.Sleep(100);
            };

            new Task(action, this).Start();
            while (true)
            {
                var relayConnection = await oListener.AcceptConnectionAsync();
                if (relayConnection == null)
                {
                    break;
                }

                ProcessMessagesOnConnection(relayConnection, cts);
            }


            await oListener.CloseAsync(cts.Token);
        }
        private async void ProcessMessagesOnConnection(HybridConnectionStream relayConnection, CancellationTokenSource cts)
        {
            String sRet = "";
           

            reader = new StreamReader(relayConnection);
            writer = new StreamWriter(relayConnection) { AutoFlush = true };
            while (!cts.IsCancellationRequested)
            {
                try
                {

                    sRet = await reader.ReadLineAsync();                    

                    await writer.WriteLineAsync($"Echo: {sRet}");
                    if (string.IsNullOrEmpty(sRet))
                    {
                        await relayConnection.ShutdownAsync(cts.Token);
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Client closed connection");
                    break;
                }
            }
           
           

            await relayConnection.CloseAsync(cts.Token);
            Console.WriteLine("\t\t\tService Relay Listener End session");
           
        }

    }
}
