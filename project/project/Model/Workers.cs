//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Workers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workers()
        {
            this.StaffandCertificates = new HashSet<StaffandCertificates>();
        }
    
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> SpecialtyId { get; set; }
        public string Salary { get; set; }
        public string ImgFile { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Specialties Specialties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffandCertificates> StaffandCertificates { get; set; }
    }
}
