//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROG6212POE
{
    using System;
    using System.Collections.Generic;
    
    public partial class question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public question()
        {
            this.stests = new HashSet<stest>();
        }
    
        public int questID { get; set; }
        public Nullable<int> questNum { get; set; }
        public string questText { get; set; }
        public string questChoice1 { get; set; }
        public string questChoice2 { get; set; }
        public string questChoice3 { get; set; }
        public string questCorrectChoice { get; set; }
        public Nullable<int> testID { get; set; }
    
        public virtual test test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stest> stests { get; set; }
    }
}