using System;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Lavery.Tools
{
    public class LaveryReflection
    {
        public static int getHashCode( Object oObj)
        {
            int iHah = 0;
            unchecked // Overflow is fine, just wrap
            {
                
                iHah = (int)2166136261;
                // Using reflection.  
                Type t = oObj.GetType();
                PropertyInfo[] attrs = t.GetProperties();
                //Field[] fields = oObj.getClass().getDeclaredFields();
                // Displaying output.  
                if (t == typeof(String))
                    iHah = (iHah * 16777619) ^ oObj.GetHashCode();
                else
                    foreach (PropertyInfo prop in attrs)
                    {
                        //System.Console.WriteLine("Name {0} Value{1} Hash{2}", prop.Name, prop.GetValue(oObj), prop.GetValue(oObj).GetHashCode());

                        iHah = (iHah * 16777619) ^ prop.GetValue(oObj).GetHashCode();
                    }
                //System.Console.WriteLine("Hashing:{0}", iHah);
            }
            return iHah;
        }
        public static Object getProperty(String sPropertyName, Object oObj)
        {
            return oObj.GetType().GetProperty(sPropertyName).GetValue(oObj, null);
        }

    }

}
