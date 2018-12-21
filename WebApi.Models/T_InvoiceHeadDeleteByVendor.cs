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
    
    public partial class T_InvoiceHeadDeleteByVendor
    {
        public int PINVID { get; set; }
        public Nullable<int> VEND_CODE { get; set; }
        public string DOC_NO { get; set; }
        public Nullable<System.DateTime> DOC_DATE { get; set; }
        public string INVOICE_NO { get; set; }
        public Nullable<System.DateTime> INVOICE_DATE { get; set; }
        public string PO_DOC_NO { get; set; }
        public string PLANT { get; set; }
        public string PLANT_NAME { get; set; }
        public string STORAGE_LOCATION { get; set; }
        public string STORAGE_LOCATION_DESC { get; set; }
        public string TRANSPORT_NAME { get; set; }
        public string VEHICAL_NO { get; set; }
        public string CITY_FOR_LBT { get; set; }
        public string BARCODE_NO { get; set; }
        public Nullable<System.DateTime> BARCODE_DATE { get; set; }
        public Nullable<System.TimeSpan> BARCODE_TIME { get; set; }
        public bool GATE_Entry_YN { get; set; }
        public string GATE_ENTRY_NO { get; set; }
        public Nullable<System.DateTime> GATE_ENTRY_DATE { get; set; }
        public Nullable<System.TimeSpan> GATE_ENTRY_TIME { get; set; }
        public string HEADER_TEXT { get; set; }
        public bool QTY_VERIFY_YN { get; set; }
        public Nullable<System.DateTime> QTY_VERIFY_DT { get; set; }
        public bool AutoERPGRN_YN { get; set; }
        public string AutoERPGRN_NO { get; set; }
        public Nullable<System.DateTime> AutoERPGRN_DATE { get; set; }
        public Nullable<int> AutoERPGRN_CREATED_BY { get; set; }
        public Nullable<System.DateTime> AutoERPGRN_CREATED_ON { get; set; }
        public Nullable<int> AutoERPGRN_MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> AutoERPGRN_MODIFIED_ON { get; set; }
        public Nullable<int> INV_CREATED_BY { get; set; }
        public Nullable<System.DateTime> INV_CREATED_ON { get; set; }
        public Nullable<int> INV_MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> INV_MODIFIED_ON { get; set; }
        public Nullable<int> QTY_VERIFY_CREATED_BY { get; set; }
        public Nullable<System.DateTime> QTY_VERIFY_CREADTED_ON { get; set; }
        public Nullable<int> QTY_VERIFY_MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> QTY_VERIFY_MODIFIED_ON { get; set; }
        public Nullable<int> GATE_ENTRY_CREATED_BY { get; set; }
        public Nullable<System.DateTime> GATE_ENTRY_CREATED_ON { get; set; }
        public Nullable<int> GATE_ENTRY_MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> GATE_ENTRY_MODIFIED_ON { get; set; }
        public string Tax_Code { get; set; }
        public string Tax_Description { get; set; }
        public Nullable<decimal> NetValue { get; set; }
        public Nullable<decimal> ExciseORServiceTax_Percent { get; set; }
        public Nullable<decimal> ExciseORServiceTax_Value { get; set; }
        public Nullable<decimal> VATORCST_Percent { get; set; }
        public Nullable<decimal> VATORCST_Tax_Value { get; set; }
        public string HSN_ControlCode { get; set; }
        public string HSN_Description { get; set; }
        public Nullable<decimal> CGST_Tax_Percent { get; set; }
        public Nullable<decimal> CGST_Tax_Value { get; set; }
        public Nullable<decimal> SGST_Tax_Percent { get; set; }
        public Nullable<decimal> SGST_Tax_Value { get; set; }
        public Nullable<decimal> IGST_Tax_Percent { get; set; }
        public Nullable<decimal> IGST_Tax_Value { get; set; }
        public Nullable<decimal> GROSS_INVOICE_VALUE { get; set; }
        public string DownloadYN { get; set; }
        public Nullable<System.DateTime> DownloadDate { get; set; }
        public Nullable<System.DateTime> DELETED_ON { get; set; }
    }
}
