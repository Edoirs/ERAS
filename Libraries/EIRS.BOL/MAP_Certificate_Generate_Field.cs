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
    
    public partial class MAP_Certificate_Generate_Field
    {
        public long CGFID { get; set; }
        public Nullable<int> PFID { get; set; }
        public Nullable<long> CGID { get; set; }
        public Nullable<int> FieldID { get; set; }
        public string FieldValue { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual MAP_Certificate_Generate MAP_Certificate_Generate { get; set; }
    }
}
