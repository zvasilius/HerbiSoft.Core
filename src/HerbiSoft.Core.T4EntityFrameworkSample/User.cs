//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HerbiSoft.Core.T4EntityFrameworkSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.RoleAssignment = new HashSet<RoleAssignment>();
        }
    
        public System.Guid ID { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual ICollection<RoleAssignment> RoleAssignment { get; set; }
    }
}
