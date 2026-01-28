using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agility.OPSX.Api.PowerBIClient.Models
{
    public class PowerBI
    {

        // Workspace Id for which Embed token needs to be generated
        public string WorkspaceId { get; set; }

        // Report Id for which Embed token needs to be generated
        public string ReportId { get; set; }
    }
}
