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
    
    public partial class Update
    {
        public Update()
        {
            this.UpdatePackage = new HashSet<UpdatePackage>();
        }
    
        public System.Guid ID { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Modified { get; set; }
    
        public virtual ICollection<UpdatePackage> UpdatePackage { get; set; }
    }
}
