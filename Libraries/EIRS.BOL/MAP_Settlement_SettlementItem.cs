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
    using System.Collections.Generic;
    
    public partial class MAP_Settlement_SettlementItem
    {
        public long SIID { get; set; }
        public Nullable<int> SettlementID { get; set; }
        public Nullable<long> AAIID { get; set; }
        public Nullable<long> SBSIID { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> SettlementAmount { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual MAP_Assessment_AssessmentItem MAP_Assessment_AssessmentItem { get; set; }
        public virtual MAP_ServiceBill_MDAServiceItem MAP_ServiceBill_MDAServiceItem { get; set; }
        public virtual Settlement Settlement { get; set; }
    }
}