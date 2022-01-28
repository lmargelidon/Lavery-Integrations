using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools.Configuration.Management;

namespace Lavery.ClassResponse.Generator
{
    public class genereAllResponsesClasses : Object
    {
        protected connectionFactory OCF;
        String sKeyConfigPath;

        public genereAllResponsesClasses(connectionFactory OCF, String sKeyConfigPath)
        {
            this.OCF = OCF;
            this.sKeyConfigPath = sKeyConfigPath;
        }
        public void doJob(String sConnectionStringName, String sNameSpace)
        {
            List<classBuilderGeneric> lGeneric = new List<classBuilderGeneric>();
            lGeneric.Add(new classBuilderMatters(OCF, "MatterGetResponse"));
            
            classBuilderFromTableDefinition oDef = new classBuilderFromTableDefinition(OCF,sConnectionStringName);
            
            foreach (classBuilderGeneric oObj in lGeneric)
            {                
                Dictionary<String, tableDS> oGeneric = oObj.getInformations();
                oDef.genereAllClasses(oGeneric, sNameSpace, OCF.getKeyValueString(sKeyConfigPath), oObj.SFinaleClassName);
            }
        }
    }
}
