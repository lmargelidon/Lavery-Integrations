using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Listeners
{
    public class TimeTypeMapping : Object
    {
        int iE3Type;
        String sNameE3;
        int iLaveryType;

        public int IE3Type { get => iE3Type; }
        public int LaveryType { get => iLaveryType; }

        public TimeTypeMapping(String sMapping)
        {
            String[] aValue = sMapping.Split(':');
            if (aValue.Length == 3)
            {
                iE3Type = int.Parse(aValue[0].Trim());
                sNameE3 = aValue[1].Trim();
                iLaveryType = int.Parse(aValue[2].Trim());
            }           
        }

        public Boolean isMe(int iType)
        {
            return iType == iE3Type;
        }
        public Boolean isMe(String sType)
        {
            return iE3Type == int.Parse(sType);
        }

    }
}
