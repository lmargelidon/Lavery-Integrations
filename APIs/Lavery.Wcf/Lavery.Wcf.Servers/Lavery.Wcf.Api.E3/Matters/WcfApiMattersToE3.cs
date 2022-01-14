using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using Lavery.Events.Listeners;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;
using Lavery.Tools;
using Lavery.Tools.Runtime;
using Lavery.Client.E3;
using Org.OpenAPITools.Model;
using Laverfy.Wcf.Schemas;
using Laverfy.Wcf.Schemas.Matters;
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

        public override MatterGetResponse postListOfMatter(MattersGet data)
        {
            MatterGetResponse oRet = new MatterGetResponse();
            try
            {

                if (data != default(MattersGet))
                {
                    MatterGetMattersRequest dataE3 = new MatterGetMattersRequest();

                    dataE3.matterId = data.matterId;
                    dataE3.mattIndex = data.mattIndex;
                    dataE3.number = data.number;
                    dataE3.advancedFilterChildObjectsToInclude = null;
                    dataE3.advancedFilterAttributesToInclude = null;
                    dataE3.advancedFilterFilterXOQL = null;
                    dataE3.advancedFilterFilterPredicates = null;
                    dataE3.advancedFilterFilterOperator = null;
                    dataE3.advancedFilterFilterGroups = null;
                    dataE3.x3ESessionId = null;
                    dataE3.x3EUserId = null;
                    dataE3.acceptLanguage = null;
                    E3EAPIMatterModelsMatterGetResponse oRetE3 = default(E3EAPIMatterModelsMatterGetResponse);
                    Console.WriteLine("\t\t\tListener Wcf to E3 called ...");
                    oRetE3 = oFacadeMatter.MatterGetMatters(dataE3);
                    persistEventManager.logInformation(LaveryBusinessFunctions.eCategory.ListenerAssiduityMsMq.ToString(),
                                                       LaveryBusinessFunctions.eBusinessFunction.Initialize.ToString(),
                                                       OCF.getKeyValueString("Environment"),
                                                       "Call E3 MatterGetMatters()...",
                                                       OGuid.ToString(), SPrefix);

                    /*
                    oRet.Attributes = new Dictionary<string, KeyValuePair<String, Type>>();

                    foreach (E3EAPIMatterModelsMatter oElt in oRetE3.Matters)
                    {
                        foreach (KeyValuePair<String,E3EAPIDataModelsAttribute> pair in oElt.Attributes)
                        {
                            Console.WriteLine("{2} {0} = {1}",pair.Key, pair.Value.Value, pair.Value.DataType);
                            //oRet.Attributes.Add(pair.Key, new KeyValuePair<String, Type>(pair.Value.Value, pair.Value.DataType.GetType()));
                            
                        }
                    }
                    */
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
