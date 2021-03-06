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
    
    public partial class PasswordPolicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PasswordPolicy()
        {
            this.Engagements = new HashSet<Engagement>();
            this.Operators = new HashSet<Operator>();
        }
    
        public int PasswordPolicyId { get; set; }
        public int MinLength { get; set; }
        public int UpperCaseLength { get; set; }
        public int LowerCaseLength { get; set; }
        public int SpecialCharLength { get; set; }
        public int NumericLength { get; set; }
        public int ExpirationAgeDays { get; set; }
        public int PasswordHistory { get; set; }
        public string PasswordPolicyName { get; set; }
        public string Description { get; set; }
        public Nullable<int> EngagementId { get; set; }
        public Nullable<int> OperatorId { get; set; }
        public int LockoutThreshold { get; set; }
        public System.TimeSpan LockoutDuration { get; set; }
        public System.TimeSpan LockoutResetCounterWindow { get; set; }
        public Nullable<System.Guid> EngagementGuid { get; set; }
        public Nullable<System.Guid> OperatorGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Engagement> Engagements { get; set; }
        public virtual Engagement Engagement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operator> Operators { get; set; }
        public virtual Operator Operator { get; set; }
    }
}
