using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class EngagementModalDto
    {
        public int EngagementId { get; set; }
        public Guid EngagementGuid { get; set; }
        public string EngagementName { get; set; }
        public string EngagementKey { get; set; }
        public string CustomerId { get; set; }
        public int SamlIdpConfigId { get; set; }
        public bool BalEngAccess { get; set; }
        public bool TmEngAccess { get; set; }
        public bool BalLightUserAccess { get; set; }
        public bool TmLightUserAccess { get; set; }
    }
}
