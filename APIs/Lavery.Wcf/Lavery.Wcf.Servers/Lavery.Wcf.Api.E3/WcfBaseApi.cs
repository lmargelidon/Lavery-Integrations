using System;
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
using Laverfy.Wcf.Schemas;
using Laverfy.Wcf.Schemas.Matters;
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

        public abstract MatterGetResponse postListOfMatter(MattersGet data);
        
    }
}
