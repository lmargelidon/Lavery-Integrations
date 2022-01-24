using System;
using System.Reflection;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public abstract class WcfBaseApi
    {
        connectionFactory oCF;               
        String sPrefix;
        Guid oGuid;
        public WcfBaseApi(connectionFactory oCF, String sPrefix, Guid oGuid)
        {
            this.oCF = oCF;
            this.oGuid = oGuid;
            this.sPrefix = sPrefix;
        }

        public connectionFactory OCF { get => oCF; }
        public string SPrefix { get => sPrefix; }
        public Guid OGuid { get => oGuid; }

        public abstract MattersGetResponse postListOfMatter(MatterGetMattersRequest data);


        protected void parseAttributes(genericResponse oResp, responseBase myObject, Dictionary<String, E3EAPIDataModelsAttribute> attributes)
        {
                        
            oResp.Add(myObject);

            foreach (KeyValuePair<String, E3EAPIDataModelsAttribute> pair in attributes)
            {
                try
                {
                    if(pair.Value.Value != null)
                        setPropertyValue(myObject, pair.Key, pair.Value.Value);
                }
                catch (Exception ex)
                { 
                }

            }
        }
        protected void setPropertyValue(Object myObject, String sFieldName,String oValue)
        {
            
            Type myType = myObject.GetType();            
            
            PropertyInfo prop = myType.GetProperty(sFieldName);            
            if (prop != default(PropertyInfo))
                switch (prop.PropertyType)
                {
                    case Type GuidType when GuidType == typeof(Guid):
                        prop.SetValue(myObject, Guid.Parse(oValue));
                        break;
                    case Type Int32Type when Int32Type == typeof(Int32):
                        prop.SetValue(myObject, Int32.Parse(oValue));
                        break;
                    case Type DateTimeType when DateTimeType == typeof(DateTime):
                        try
                        {
                            prop.SetValue(myObject, DateTime.Parse(oValue)); ;
                        }
                        catch (Exception ex)
                        {
                            prop.SetValue(myObject, null);
                        }
                        
                        break;
                    case Type BooleanType when BooleanType == typeof(Boolean):
                        try
                        {
                            prop.SetValue(myObject, Boolean.Parse(oValue));
                        }
                        catch (Exception ex)
                        {
                            prop.SetValue(myObject, !oValue.Equals("0"));
                        }
                        break;                   
                    default:
                        prop.SetValue(myObject, oValue);
                        break;
                }
                
        }
        
    }
}
