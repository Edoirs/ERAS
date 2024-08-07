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
    
    public partial class Profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profile()
        {
            this.Assessment_Rules = new HashSet<Assessment_Rules>();
            this.MAP_TaxPayer_Asset_Profile = new HashSet<MAP_TaxPayer_Asset_Profile>();
            this.ProfileAttributes = new HashSet<ProfileAttribute>();
            this.ProfileGroups = new HashSet<ProfileGroup>();
            this.ProfileSectors = new HashSet<ProfileSector>();
            this.ProfileSectorElements = new HashSet<ProfileSectorElement>();
            this.ProfileSectorSubElements = new HashSet<ProfileSectorSubElement>();
            this.ProfileSubAttributes = new HashSet<ProfileSubAttribute>();
            this.ProfileSubGroups = new HashSet<ProfileSubGroup>();
            this.ProfileSubSectors = new HashSet<ProfileSubSector>();
            this.ProfileTaxPayerRoles = new HashSet<ProfileTaxPayerRole>();
            this.ProfileTaxPayerTypes = new HashSet<ProfileTaxPayerType>();
        }
    
        public int ProfileID { get; set; }
        public string ProfileReferenceNo { get; set; }
        public string ProfileDescription { get; set; }
        public Nullable<int> AssetTypeStatus { get; set; }
        public Nullable<int> AssetTypeID { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ProfileTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assessment_Rules> Assessment_Rules { get; set; }
        public virtual Asset_Types Asset_Types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_TaxPayer_Asset_Profile> MAP_TaxPayer_Asset_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileAttribute> ProfileAttributes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileGroup> ProfileGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileSector> ProfileSectors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileSectorElement> ProfileSectorElements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileSectorSubElement> ProfileSectorSubElements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileSubAttribute> ProfileSubAttributes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileSubGroup> ProfileSubGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileSubSector> ProfileSubSectors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileTaxPayerRole> ProfileTaxPayerRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProfileTaxPayerType> ProfileTaxPayerTypes { get; set; }
    }
}
