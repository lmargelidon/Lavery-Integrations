using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lavery.Wcf.Core
{
    [DataContract]
    public class Mandat
    {
        /* PROPRIÉTÉS */
        [DataMember]
        public string Departement { get; set; }
        [DataMember]
        public string Corgaty { get; set; }
        [DataMember]
        public string AvocatOriginateur { get; set; }
        [DataMember]
        public string AvocatSuperviseur { get; set; }
        [DataMember]
        public string Tkinit { get; set; }
        [DataMember]
        public string NoDossier { get; set; }
        [DataMember]
        public string NomClient { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string NatureMandat { get; set; }
        [DataMember]
        public string Pimplique { get; set; }
        [DataMember]
        public bool HasAutresNom { get; set; }
    }

}
