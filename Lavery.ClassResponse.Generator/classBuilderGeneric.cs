using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools.Configuration.Management;

namespace Lavery.ClassResponse.Generator
{
    public abstract class classBuilderGeneric: Object
    {
        protected connectionFactory OCF;
        String sFinaleClassName;


        public classBuilderGeneric(connectionFactory OCF, string sFinaleClassName)
        {
            OCF = new connectionFactory();
            this.sFinaleClassName = sFinaleClassName;
        }

        public string SFinaleClassName { get => sFinaleClassName;  }

        abstract public Dictionary<String, tableDS> getInformations();
       
        public Dictionary<String, tableDS> organizeClassesInformations(String sBaseTable, List<String> lField)
        {
            Dictionary<String, tableDS> oRet = new Dictionary<String, tableDS>();
            foreach (String oElt in lField)
            {
                

                String sSchema = "dbo";
                String sField = oElt;
                /*
                String[] aVal = oElt.Split('.');
                int iBase = 0;
                if (aVal.Length > 1)
                {
                    sBaseTable = aVal[0];
                    iBase = 1;
                }
                
                for (int i = iBase; i < aVal.Length; i++)
                    sField += ((sField.Length > 0 ? "-":"") + aVal[i]);
                */

                tableDS otableDS;
                if (oRet.ContainsKey(sBaseTable))
                    otableDS = oRet[sBaseTable];
                else
                {
                    otableDS = new tableDS(sSchema, sBaseTable);
                    oRet.Add(sBaseTable, otableDS);
                }
                otableDS.addField(sField);
            }
            return oRet;
        }
    }
}
