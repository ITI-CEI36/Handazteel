//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HANDAZ.PEB.WebUI.EFW
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserModel()
        {
            this.Results = new HashSet<Result>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public int MemberID { get; set; }
        public string Path { get; set; }
    
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
    }
}
