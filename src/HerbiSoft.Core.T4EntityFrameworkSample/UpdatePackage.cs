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
    
    public partial class UpdatePackage
    {
        public System.Guid ID { get; set; }
        public System.Guid UpdateID { get; set; }
        public int Type { get; set; }
        public string Version { get; set; }
        public System.DateTime Modified { get; set; }
    
        public virtual Update Update { get; set; }
    }
}
