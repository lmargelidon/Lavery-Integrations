using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Lavery.Tools.Interfaces
{

     [DataContractAttribute]
    public class LsaFaultEXception
    {
        private string report;

        public LsaFaultEXception(string message)
        {
            this.report = message;
        }

        [DataMemberAttribute]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }
    }

     [DataContract]
     public class LsaServiceStatus
     {
         Guid eGuid = Guid.NewGuid();
         eServiceStatus eStatus = eServiceStatus.Pending;
         List<String> lErrorInformations = new List<string>();


         [DataMember]
         public List<String> LErrorInformations
         {
             get { return lErrorInformations; }
             set { lErrorInformations = value; }
         }

         [DataMember]
         public eServiceStatus EStatus
         {
             get { return eStatus; }
             set { eStatus = value; }
         }
         [DataMember]
         public Guid EGuid
         {
             get { return eGuid; }
         }
     }

}
