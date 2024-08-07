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
    
    public partial class MAP_Assessment_AssessmentItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAP_Assessment_AssessmentItem()
        {
            this.MAP_Settlement_SettlementItem = new HashSet<MAP_Settlement_SettlementItem>();
            this.MAP_Assessment_LateCharge = new HashSet<MAP_Assessment_LateCharge>();
            this.MAP_Assessment_Adjustment = new HashSet<MAP_Assessment_Adjustment>();
        }
    
        public long AAIID { get; set; }
        public Nullable<long> AARID { get; set; }
        public Nullable<int> AssessmentItemID { get; set; }
        public Nullable<decimal> TaxBaseAmount { get; set; }
        public Nullable<decimal> Percentage { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<int> PaymentStatusID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Assessment_Items Assessment_Items { get; set; }
        public virtual MST_PaymentStatus MST_PaymentStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_Settlement_SettlementItem> MAP_Settlement_SettlementItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_Assessment_LateCharge> MAP_Assessment_LateCharge { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAP_Assessment_Adjustment> MAP_Assessment_Adjustment { get; set; }
        public virtual MAP_Assessment_AssessmentRule MAP_Assessment_AssessmentRule { get; set; }
    }
}
