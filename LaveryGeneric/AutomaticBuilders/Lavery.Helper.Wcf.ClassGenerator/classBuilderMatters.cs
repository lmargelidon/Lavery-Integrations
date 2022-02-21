using System;
using System.Collections.Generic;
using Lavery.Tools.Configuration.Management;
using Lavery.Constants;
using Lavery.Tools;
using Lavery.Tools.Runtime;
using Org.OpenAPITools.Model;
using Lavery.Helper.ClassGenerator;
using Lavery.Client.E3;


namespace Lavery.ClassResponse.Generator
{
    public class classBuilderMatters: classBuilderGeneric
    {
        
        MatterApiFacade oFacadeMatter;        

        public classBuilderMatters(connectionFactory OCF, String sFinalClassName, String sBaseTableName) : base(OCF, sFinalClassName, sBaseTableName)
        {
            try
            {        
                oFacadeMatter = new MatterApiFacade(OCF);                
            }
            catch
            {

            }
        }

        public override Composite getInformations()
        {
            Composite oComposite = default(Composite); 
            try
            {
                MatterGetMattersRequest dataE3 = new MatterGetMattersRequest();

                dataE3.matterId = null;
                dataE3.mattIndex = 467;
                dataE3.number = null;
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

                recursiveInformation<E3EAPIMatterModelsMatter> oRecINfo = new recursiveInformation<E3EAPIMatterModelsMatter>();

                
                foreach (E3EAPIMatterModelsMatter oElt in oRetE3.Matters)
                {
                    List<String> lDef = new List<String>();
                    foreach (KeyValuePair<String, E3EAPIDataModelsAttribute> pair in oElt.Attributes)                    
                        lDef.Add(pair.Key.Replace("1",""));

                    //oDico = organizeClassesInformations("Matter", lDef);

                    oComposite = oRecINfo.recursOrganizeInformation(oElt, this.SBaseTableName);

                } 
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("\t\t\tCall E3 MatterGetMatters()->Exception Thrown : {0}", ex.Message);
               
            }
            return oComposite;
        }
    }
}
