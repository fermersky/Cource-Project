//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaffandCertificates
    {
        public int Id { get; set; }
        public Nullable<int> WorkerId { get; set; }
        public Nullable<int> CertificateId { get; set; }
    
        public virtual Certificates Certificates { get; set; }
        public virtual Workers Workers { get; set; }
    }
}