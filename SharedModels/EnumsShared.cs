using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public static class EnumsShared
    {
        public enum AppId
        {
            Balancer = 1,
            TaskManager = 2,
            IntegrationHub = 3,
            Setup = 4,
            Support = 5,
            ScreenSteps = 6
        }

        public enum Roles
        {
            EngagementAdmin = 1,
            User = 2,
            ApplicationAdmin = 3,
            ApplicationUser = 4,
            Auditor = 5,
            ApplicationLightUser = 6
        }

        public enum OperatorStatus
        {
            NotVerified = 1,
            ActivationPending = 2,
            Active = 3,
            Deactivated = 4,
            Deleted = 5
        }

        public enum Applications
        {
            Balancer,
            Setup,
            TaskManager,
            Support,
            ScreenSteps
        }

        public enum EditionType
        {
            Trial,
            Production
        }

        public enum SessionTimeoutSetting
        {
            Default,
            Custom,
            None
        }

        public static class ClaimNames
        {
            public static readonly string OperatorId = "operatorId";
            public static readonly string OperatorGuid = "operatorGuid";
            public static readonly string OperatorEngagementGuid = "operatorEngagementGuid";
            public static readonly string UserName = "userName";
            public static readonly string FirstName = "firstName";
            public static readonly string LastName = "lastName";
            public static readonly string Language = "language";
            public static readonly string Culture = "culture";
            public static readonly string OperatorTimeZone = "operatorTimeZone";
            public static readonly string OperatorTzId = "operatorTzId";
            public static readonly string EngagementId = "engagementId";
            public static readonly string EngagementGuid = "engagementGuid";
            public static readonly string EngagementName = "engagementName";
            public static readonly string Application = "applications";
            public static readonly string EngagementLogoUrl = "engagementLogoUrl";
            public static readonly string EngagementTimeZone = "engagementTimeZone";
            public static readonly string EngagementTzId = "engagementTzId";
            public static readonly string IssuedTimestamp = "issuedTimestamp";
            public static readonly string ExpiresTimestamp = "expiresTimestamp";
            public static readonly string EngagementApplicationRoles = "engagementApplicationRoles";
            public static readonly string RefreshEndPoint = "refreshEndPoint";
            public static readonly string Features = "features";
            public static readonly string BalancerEngId = "balEngId";
            public static readonly string TaskManagerEngId = "tmEngId";
            public static readonly string SessionTimeOut = "sessionTimeOut";
        }

        public static class ApplicationUrls
        {
            public static readonly string Setup = "https://setup.adra.com";
            public static readonly string Balancer = "https://balancer.adra.com";
            public static readonly string TaskManager = "https://taskmanager.adra.com";
            public static readonly string BalancerDev = "https://balancer{0}.adra.com";
            public static readonly string TaskManagerDev = "https://taskmanager{0}.adra.com";
            public static readonly string SetupDev = "https://setup{0}.adra.com";
        }

        public static class IdentityEmailTemplates
        {
            public static readonly string UsernameChange = "UsernameChange";
        }

        #region Logging

        public enum LogLevel
        {
            Info,
            Error
        }

        public enum Events
        {
            LoginSuccess,
            LoginFailure,
            Logout,
            ApplicationAuthenticationSuccess,
            ApplicationAuthenticationFailure,
            ConfigurationChange,
            EngagementSelection,
            UsernameChanged
        }

        public enum LogEntity
        {
            Application,
            ApplicationAccess,
            Editions,
            Engagement,
            EngagementApplication,
            Operator,
            OperatorCredential,
            OperatorEngagement,
            OperatorEngagementApplicationRole,
            OperatorEngagementRole,
            PasswordPolicy,
            Role,
            SamlIdpConfig,
            SamlSpConfig,
            OperatorUsername
        }

        public enum LogAction
        {
            Created,
            Updated,
            Deleted
        }

        public enum LogConstants
        {
            Application,
            AuthenticatedOperatorId,
            AuthenticatedOperatorUsername,
            AuthenticatedOperatorMasterEngagementId,
            AuthenticatedOperatorMasterEngagementName,
            UpdatedOperatorId,
            UpdatedOperatorUsername,
            UpdatedOperatorMasterEngagmentId,
            UpdatedOperatorMasterEngagmentName,
            UpdatedEngagementId,
            UpdatedEngagementName,
            SelectedEngagementId,
            SelectedEngagementName,
            IpAddress,
            LockedAccount,
            LoginAttempts,
            OldObjectState,
            NewObjectState,
            Timestamp,
            TraceId,
            Type,
            UserAgentString,
            Username,
            PreviousUsername
        }
        #endregion
    }
}
