//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.M_User_MacID = new HashSet<M_User_MacID>();
            this.M_UserFormMapping = new HashSet<M_UserFormMapping>();
        }
    
        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string FullName { get; set; }
        public string Designation { get; set; }
        public byte[] ImageBytes { get; set; }
        public string Extension { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string USER_TYPE { get; set; }
        public bool PLANT1_RIGHT { get; set; }
        public bool PLANT2_RIGHT { get; set; }
        public bool PLANT3_RIGHT { get; set; }
        public bool PLANT4_RIGHT { get; set; }
        public bool PLANT5_RIGHT { get; set; }
        public string LoginType { get; set; }
        public string MACPassword { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_User_MacID> M_User_MacID { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_UserFormMapping> M_UserFormMapping { get; set; }
    }
}
