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
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.MAP_Company_AddressInformation = new HashSet<MAP_Company_AddressInformation>();
        }
    
        public int CompanyID { get; set; }
        public string CompanyRIN { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string TIN { get; set; }
        public string MobileNumber1 { get; set; }
        public string MobileNumber2 { get; set; }
        public string EmailAddress1 { get; set; }
        public string EmailAddress2 { get; set; }
        public Nullable<int> TaxOfficeID { get; set; }
        public Nullable<int> TaxPayerTypeID { get; set; }
        public Nullable<int> EconomicActivitiesID { get; set; }
        public Nullable<int> NotificationMethodID { get; set; }
        public string ContactAddress { get; set; }
        public string CACRegistrationNumber { get; set; }
        public Nullable<int> RegisterationStatusID { get; set; }
        public Nullable<System.DateTime> RegisterationDate { get; set; }
        public Nullable<int> VerificationOTP { get; set; }
        public Nullable<int> TaxOfficerID { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> DataSourceID { get; set; }
        public Nullable<long> DSRefID { get; set; }
        public string CAC { get; set; }
    
        public virtual Economic_Activities Economic_Activities { get; set; }
        public virtual Notification_Method Notification_Method { get; set; }
        public virtual Tax_Offices Tax_Offices { get; set; }
        public virtual TaxPayer_Types TaxPayer_Types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_Company_AddressInformation> MAP_Company_AddressInformation { get; set; }
        public virtual MST_RegisterationStatus MST_RegisterationStatus { get; set; }
    }
}