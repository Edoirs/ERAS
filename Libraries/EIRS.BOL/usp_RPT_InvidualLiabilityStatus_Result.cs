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
    
    public partial class usp_RPT_InvidualLiabilityStatus_Result
    {
        public Nullable<int> TaxPayerID { get; set; }
        public string TaxPayerRIN { get; set; }
        public string TaxPayerName { get; set; }
        public Nullable<int> TaxPayerTypeID { get; set; }
        public string MobileNumber { get; set; }
        public Nullable<decimal> TotalAssessmentAmount { get; set; }
        public Nullable<decimal> TotalPaymentAmount { get; set; }
        public Nullable<decimal> Balance { get; set; }
    }
}
