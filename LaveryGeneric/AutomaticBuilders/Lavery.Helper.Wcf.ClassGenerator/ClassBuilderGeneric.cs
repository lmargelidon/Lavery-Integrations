using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools;
using Lavery.Tools.Configuration.Management;


namespace Lavery.ClassResponse.Generator
{
    public abstract class classBuilderGeneric : Object
    {
        protected connectionFactory OCF;
        String sFinaleClassName;
        String sBaseTableName;


        public classBuilderGeneric(connectionFactory OCF, string sFinaleClassName, String sBaseTableName)
        {
            OCF = new connectionFactory();
            this.sFinaleClassName = sFinaleClassName;
            this.sBaseTableName = sBaseTableName;
        }

        public string SFinaleClassName { get => sFinaleClassName; }
        public string SBaseTableName { get => sBaseTableName; }

        abstract public Composite getInformations();


        /*
         public Dictionary<String, tableDS> organizeClassesInformations(String sBaseTable, List<String> lField)
         {
             Dictionary<String, tableDS> oRet = new Dictionary<String, tableDS>();
             foreach (String oElt in lField)
             {


                 String sSchema = "dbo";
                 String sField = oElt;

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
        */
    }
}
