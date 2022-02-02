using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavery.Tools.Configuration.Management;
using Org.OpenAPITools.Model;
using Lavery.Tools;
using Lavery.Constants;
using Lavery.Client.E3;

namespace Lavery.ClassResponse.Generator
{
    public class recursiveInformation<T>
    {
        public Composite recursOrganizeInformation(T oType, String sClassId = default(String))
        {
            Composite oComposite = default(Composite);
            
            Dictionary<String, E3EAPIDataModelsAttribute> lAttributes;
            if ((lAttributes = (Dictionary<String, E3EAPIDataModelsAttribute>)LaveryReflection.getProperty("Attributes", oType)) != default(Dictionary<String, E3EAPIDataModelsAttribute>))
            {
                List<String> lDef = new List<String>();
                foreach (KeyValuePair<String, E3EAPIDataModelsAttribute> pair in lAttributes)
                    lDef.Add(pair.Key.Replace("1", ""));

                oComposite = organizeClassesInformations(sClassId != default(String)? sClassId : oType.ToString(), lDef);
            }
            else
                oComposite = new Composite(oType.ToString());

            List<E3EAPIDataObjectModelsDataObjectLiteCollection> lChildObjects;
                
            if ((lChildObjects =(List<E3EAPIDataObjectModelsDataObjectLiteCollection>)LaveryReflection.getProperty("ChildObjects", oType)) != default(List<E3EAPIDataObjectModelsDataObjectLiteCollection>))
            {
                List<String> lDef = new List<String>();
                foreach (E3EAPIDataObjectModelsDataObjectLiteCollection oVal in lChildObjects)
                {
                    recursiveInformation<E3EAPIDataObjectModelsDataObjectLite> oRecINfo = new recursiveInformation<E3EAPIDataObjectModelsDataObjectLite>();

                    foreach (E3EAPIDataObjectModelsDataObjectLite eElt in oVal.Rows)
                    {
                        /*
                         * Monter inclusion de l'object recursivement
                         */

                        List<String> lDefObjectRelation = new List<String>();
                        lDefObjectRelation.Add(String.Format(reflectionGeneration.sStartStructure, eElt.SubclassId));

                        oComposite.add( oRecINfo.recursOrganizeInformation(eElt, eElt.SubclassId));              

                    }
                }
            }
            
            return oComposite;
        }
        public Composite organizeClassesInformations(String sBaseTable, List<String> lField)
        {
            Composite oRet = new Composite(sBaseTable);
            foreach (String oElt in lField)
            {   
                String sField = oElt;
                fieldDef oFI = new fieldDef(oElt);
                oRet.add(oFI);
            }
            return oRet;
        }
        public Composite  addComposit(Composite oCompositeBase, Composite oComposite)
        {
            oCompositeBase.add(oComposite);
            return oCompositeBase;
        }


    }
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
