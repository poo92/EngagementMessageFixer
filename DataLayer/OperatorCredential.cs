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
    
    public partial class OperatorCredential
    {
        public int OperatorCredentialId { get; set; }
        public int OperatorId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public System.DateTime ChangedDateTime { get; set; }
        public bool Active { get; set; }
        public Nullable<System.Guid> OperatorGuid { get; set; }
    
        public virtual Operator Operator { get; set; }
    }
}
