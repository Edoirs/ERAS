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
    
    public partial class usp_SearchAssessment_Result
    {
        public Nullable<long> AssessmentID { get; set; }
        public string AssessmentRefNo { get; set; }
        public Nullable<System.DateTime> AssessmentDate { get; set; }
        public Nullable<decimal> AssessmentAmount { get; set; }
        public Nullable<System.DateTime> SettlementDueDate { get; set; }
        public Nullable<int> SettlementStatusID { get; set; }
        public string SettlementStatusName { get; set; }
        public Nullable<System.DateTime> SettlementDate { get; set; }
        public Nullable<int> TaxPayerTypeID { get; set; }
        public string TaxPayerTypeName { get; set; }
        public Nullable<int> TaxPayerID { get; set; }
        public string TaxPayerName { get; set; }
        public string TaxPayerRIN { get; set; }
        public string AssessmentNotes { get; set; }
        public Nullable<bool> Active { get; set; }
        public string ActiveText { get; set; }
    }
}