//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Education_Programs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Education_Programs()
        {
            this.Groups = new HashSet<Groups>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Groups> Groups { get; set; }
    }
}
