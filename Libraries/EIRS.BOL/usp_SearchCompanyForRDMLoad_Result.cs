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
    
    public partial class usp_SearchCompanyForRDMLoad_Result
    {
        public Nullable<int> CompanyID { get; set; }
        public string CompanyRIN { get; set; }
        public string CompanyName { get; set; }
        public string TIN { get; set; }
        public string MobileNumber1 { get; set; }
        public string MobileNumber2 { get; set; }
        public string EmailAddress1 { get; set; }
        public string EmailAddress2 { get; set; }
        public Nullable<int> TaxOfficeID { get; set; }
        public string TaxOfficeName { get; set; }
        public Nullable<int> TaxPayerTypeID { get; set; }
        public string TaxPayerTypeName { get; set; }
        public Nullable<int> EconomicActivitiesID { get; set; }
        public string EconomicActivitiesName { get; set; }
        public Nullable<int> NotificationMethodID { get; set; }
        public string NotificationMethodName { get; set; }
        public string ContactAddress { get; set; }
        public Nullable<int> RegisterationStatusID { get; set; }
        public string RegisterationStatusName { get; set; }
        public Nullable<System.DateTime> RegisterationDate { get; set; }
        public Nullable<bool> Active { get; set; }
        public string ActiveText { get; set; }
        public string CACRegistrationNumber { get; set; }
    }
}