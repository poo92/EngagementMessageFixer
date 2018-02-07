using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adra.Common.IdentitySync.Contracts;

namespace Services.Contracts.Util
{
    public interface IIntegrationService
    {
        void NotifyApplications(EntityChangeMessage entityChangeMessage);

    }
}
