using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Reflection;

using Lavery.Events.Listeners;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;
using Lavery.Tools;
using Lavery.Tools.Runtime;
using Lavery.Client.E3;
using Org.OpenAPITools.Model;

using Lavery.Wcf.Core;


namespace Lavery.Wcf.Api.E3
{
    
    public class WcfApiMattersToE3 : WcfBaseApi
    {
        MatterApiFacade oFacadeMatter;
        
        public WcfApiMattersToE3(connectionFactory oCF, String sPrefix, Guid oGuid) :base(oCF, sPrefix, oGuid)
        {
            try
            {                
               
                oFacadeMatter = new MatterApiFacade(OCF);                

                //TracePending.Trace("WcfServiceSlaDispatchRequest Object created");
            }
            catch
            {

            }
            persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerInboundService.ToString(),
                                                LaveryBusinessFunctions.eBusinessFunction.Start.ToString(),
                                                OCF.getKeyValueString("Environment"), "WcfServiceSlaParsingApi object Instance created Succesfully", oGuid.ToString());

        }

        public override MattersGetResponse postListOfMatter(MatterGetMattersRequest dataE3)//MattersGetInformations data)
        {
            MattersGetResponse oRet = new MattersGetResponse();
            try
            {

                if (dataE3 != default(MatterGetMattersRequest))
                {/*
                    MatterGetMattersRequest dataE3 = new MatterGetMattersRequest();
                    Type myType = data.GetType();


                    foreach (var PropertyInfo in myType.GetProperties())
                    {
                        try
                        {
                            PropertyInfo prop = dataE3.GetType().GetProperty(PropertyInfo.Name);
                            object oObj = PropertyInfo.GetValue(data);
                            if(oObj != null)
                                prop.SetValue(dataE3, oObj);
                        }
                        catch (Exception ex)
                        { }
                    }
                    */
                    E3EAPIMatterModelsMatterGetResponse oRetE3 = default(E3EAPIMatterModelsMatterGetResponse);
                    Console.WriteLine("\t\t\tListener Wcf to E3 called ...");
                    oRetE3 = oFacadeMatter.MatterGetMatters(dataE3);
                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                       LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                       OCF.getKeyValueString("Environment"),
                                                       "Call E3 MatterGetMatters()...",
                                                       OGuid.ToString(), SPrefix);




                    foreach (E3EAPIMatterModelsMatter oElt in oRetE3.Matters)
                    {
                        parseAttributes(oRet, new MatterGetResponseDetail(), oElt.Attributes);
                    }

                    
                    oRet.Success = oRetE3.Success;
                    oRet.Message = oRetE3.Message;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t\t\tCall E3 MatterGetMatters()->Exception Thrown : {0}", ex.Message);
                persistEventManager.logError(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                   LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                   OCF.getKeyValueString("Environment"),
                                                   String.Format("Excetion catched : {0}\n{1}", "Listen on the Wcf to E3...", ex.Message),
                                                   OGuid.ToString(), SPrefix);
                oRet.Success = false;
                oRet.Message = ex.Message;
            }
            return oRet;
        }

    }
}
