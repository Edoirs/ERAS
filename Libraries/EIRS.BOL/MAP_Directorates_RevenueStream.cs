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
    
    public partial class MAP_Directorates_RevenueStream
    {
        public int DRSID { get; set; }
        public Nullable<int> DirectorateID { get; set; }
        public Nullable<int> RevenueStreamID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual Directorate Directorate { get; set; }
        public virtual Revenue_Stream Revenue_Stream { get; set; }
    }
}