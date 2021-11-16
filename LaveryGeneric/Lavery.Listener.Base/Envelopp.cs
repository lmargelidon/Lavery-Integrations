using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Listeners
{
    
    [Serializable()]
    public class Envelopp<T>
    {
        public enum typeEnvelopp { None, Insert, Delete, Update }
        typeEnvelopp etypeEnvelopp = typeEnvelopp.None;
        T oObject;

        public T OObject { get => oObject; set => oObject = value; }
       
        public typeEnvelopp EtypeEnvelopp { get => etypeEnvelopp; set => etypeEnvelopp = value; }
    }
}
