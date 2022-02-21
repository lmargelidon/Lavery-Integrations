using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;
using Lavery.Helper.ClassGenerator;

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
            lGeneric.Add(new classBuilderMatters(OCF, "MatterGetResponseDetail", "Matters"));
            
            classBuilderFromTableDefinition oDef = new classBuilderFromTableDefinition(OCF,sConnectionStringName);
            
            foreach (classBuilderGeneric oObj in lGeneric)
            {
                Composite oGeneric = oObj.getInformations();
                oDef.genereAllClasses(oGeneric, sNameSpace, OCF.getKeyValueString(sKeyConfigPath), oObj.SFinaleClassName, oObj.SBaseTableName);
            }
        }
       
    }
}
