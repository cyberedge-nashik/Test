//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCTestWebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class M_TAX
    {
        public string Tax_Code { get; set; }
        public string Tax_Description { get; set; }
        public Nullable<decimal> ExciseORServiceTax_Percent { get; set; }
        public Nullable<decimal> VATORCST_Percent { get; set; }
        public string VATORCST_Calculation { get; set; }
    }
}
