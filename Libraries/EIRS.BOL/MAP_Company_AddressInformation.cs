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
    
    public partial class MAP_Company_AddressInformation
    {
        public int CAIID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<int> AddressTypeID { get; set; }
        public Nullable<int> BuildingID { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual Address_Types Address_Types { get; set; }
        public virtual Building Building { get; set; }
        public virtual Company Company { get; set; }
    }
}