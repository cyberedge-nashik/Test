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
    
    public partial class UsrGet_BallancePOItemNOListFromVendorAndPO_GST_Result
    {
        public int ITEM_NO_OF_PODOC { get; set; }
        public string MATERIAL_NO { get; set; }
        public string MATERIAL_DESCRIPTION { get; set; }
        public string UOM { get; set; }
        public Nullable<decimal> PO_QTY { get; set; }
        public Nullable<decimal> Balance_Qty { get; set; }
        public string HSN_Code { get; set; }
        public string Tax_Description { get; set; }
        public decimal CGST { get; set; }
        public decimal SGST { get; set; }
        public decimal IGST { get; set; }
    }
}
