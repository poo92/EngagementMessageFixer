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
    
    public partial class ApplicationAccess
    {
        public int ApplicationAccessId { get; set; }
        public string ApplicationUri { get; set; }
        public int AppUniqueId { get; set; }
    
        public virtual SamlSpConfig SamlSpConfig { get; set; }
    }
}
