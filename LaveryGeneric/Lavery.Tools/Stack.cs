using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Tools
{
    public class Stack : Object
    {
        List<Object> oListChange = new List<Object>();
        Object oLock = new Object();
        public void push(Object oEnvelop)
        {
            lock(oLock)
            { 
                oListChange.Add(oEnvelop);
            }
        }
        public Object pop()
        {
            Object oRet = default(Object);
            lock (oLock)
            {
                if (oListChange.Count > 0)
                {
                    oRet = oListChange[0];
                    oListChange.RemoveAt(0);
                }
            }
            return oRet;
        }

    }
}
