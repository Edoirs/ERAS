//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIRS.BOL
{
    using System;
    
    public partial class usp_GetSettlementItemDetails_Result
    {
        public Nullable<long> SIID { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<int> ItemTypeID { get; set; }
        public string RuleName { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> AdjustmentAmount { get; set; }
        public Nullable<decimal> LateChargeAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<decimal> SettlementAmount { get; set; }
    }
}
