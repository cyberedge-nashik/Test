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
    
    public partial class uspGetUserByUserCode_Result
    {
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
    }
}
