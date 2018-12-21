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
    
    public partial class T_PO
    {
        public int AUTOCODE { get; set; }
        public string ORDER_TYPE { get; set; }
        public Nullable<System.DateTime> PO_DOC_DATE { get; set; }
        public string PO_DOC_NO { get; set; }
        public int ITEM_NO_OF_PODOC { get; set; }
        public Nullable<int> VENDOR_CODE { get; set; }
        public string VENDOR_NAME { get; set; }
        public string CITY_FOR_LBT { get; set; }
        public string ACCOUNT_ASSIGNMENT_CATEGORY { get; set; }
        public string ITEM_CATEGORY_IN_PODOC { get; set; }
        public string MATERIAL_NO { get; set; }
        public string MATERIAL_DESCRIPTION { get; set; }
        public int MinRemainingShelfLife { get; set; }
        public string MATERIAL_GROUP { get; set; }
        public string MATERIAL_GROUP_NAME { get; set; }
        public string UNIT_OF_ENTRY { get; set; }
        public Nullable<decimal> PO_QTY { get; set; }
        public Nullable<decimal> NET_PRICE { get; set; }
        public string PLANT { get; set; }
        public string PLANT_NAME { get; set; }
        public string STORAGE_LOCATION { get; set; }
        public string STORAGE_LOCATION_DESC { get; set; }
        public string PO_INFO_RECORD_NO { get; set; }
        public string TAX_CODE { get; set; }
        public string TAX_CODE_NAME { get; set; }
        public string PURCHASING_GROUP { get; set; }
        public string PURCHASING_GROUP_NAME { get; set; }
        public string DELETE_INDICATOR { get; set; }
        public string RELEASE_INDICATOR { get; set; }
        public Nullable<int> RELEASE_GROUP { get; set; }
        public string RELEASE_STATUS { get; set; }
        public string RELEASE_Strategy { get; set; }
        public Nullable<int> CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATED_ON { get; set; }
        public string CREATED_IP { get; set; }
        public Nullable<int> MODIFIED_BY { get; set; }
        public Nullable<System.DateTime> MODIFIED_ON { get; set; }
        public string MODIFIED_IP { get; set; }
        public string F_HSNControlCode { get; set; }
        public string TaxInd_F_Material { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
    }
}
