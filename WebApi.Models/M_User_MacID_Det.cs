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
    
    public partial class M_User_MacID_Det
    {
        public int AutoNumber { get; set; }
        public int FAutocode { get; set; }
        public int FUserid { get; set; }
        public string MacID { get; set; }
    
        public virtual M_User_MacID M_User_MacID { get; set; }
    }
}
