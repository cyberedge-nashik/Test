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
    
    public partial class T_InvoiceDetailDeleteByVendor
    {
        public int AUTOCODE { get; set; }
        public int FINVID { get; set; }
        public string PO_DOC_NO { get; set; }
        public int ITEM_NO_OF_PODOC { get; set; }
        public string MATERIAL_NO { get; set; }
        public string MATERIAL_DESCRIPTION { get; set; }
        public Nullable<decimal> QTY_IN_DELIVERY_NOTE { get; set; }
        public string UNIT_OF_ENTRY { get; set; }
        public Nullable<decimal> BASE_VALUE { get; set; }
        public decimal QTY_IN_UNIT_OF_ENTRY_RECEIVING { get; set; }
        public string PACKING { get; set; }
        public string ITEM_TEXT { get; set; }
        public int MIN_REMAINING_SHELF_LIFE { get; set; }
        public Nullable<System.DateTime> MANUFACTURING_DATE { get; set; }
        public string BATCH_OR_TC_NO { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string HSN_ControlCode { get; set; }
        public string HSN_Description { get; set; }
        public Nullable<decimal> CGST_Tax_Percent { get; set; }
        public Nullable<decimal> CGST_Tax_Value { get; set; }
        public Nullable<decimal> SGST_Tax_Percent { get; set; }
        public Nullable<decimal> SGST_Tax_Value { get; set; }
        public Nullable<decimal> IGST_Tax_Percent { get; set; }
        public Nullable<decimal> IGST_Tax_Value { get; set; }
    }
}
