//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class EngagementApplication
    {
        public int EngagementId { get; set; }
        public int ApplicationId { get; set; }
        public int EditionType { get; set; }
        public int EditionId { get; set; }
        public bool LightUser { get; set; }
        public Nullable<System.DateTime> SubscriptionEndDate { get; set; }
        public System.Guid EngagementGuid { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual Edition Edition { get; set; }
        public virtual Engagement Engagement { get; set; }
    }
}
