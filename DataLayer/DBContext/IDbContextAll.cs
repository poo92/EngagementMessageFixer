using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBContext
{
    public interface IDbContextAll : IContext
    {
        IDbSet<Application> Applications { get; set; }
        IDbSet<Engagement> Engagements { get; set; }
        IDbSet<EngagementApplication> EngagementApplications { get; set; }
        IDbSet<Operator> Operators { get; set; }
        IDbSet<OperatorCredential> OperatorCredentials { get; set; }
        IDbSet<OperatorEngagementApplicationRole> OperatorEngagementApplicationRoles { get; set; }
        IDbSet<Role> Roles { get; set; }
        IDbSet<SamlIdpConfig> SamlIdpConfigs { get; set; }
        IDbSet<SamlSpConfig> SamlSpConfigs { get; set; }
        IDbSet<ApplicationAccess> ApplicationAccesses { get; set; }
        IDbSet<OperatorEngagementRole> OperatorEngagementRoles { get; set; }
        IDbSet<OperatorEngagement> OperatorEngagements { get; set; }
        IDbSet<PasswordPolicy> PasswordPolicies { get; set; }
        IDbSet<Edition> Editions { get; set; }
        IDbSet<EditionFeature> EditionFeature { get; set; }
    }
}
