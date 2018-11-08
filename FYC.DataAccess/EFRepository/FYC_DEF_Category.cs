namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FYC_DEF_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FYC_DEF_Category()
        {
            FYC_TRAN_Cause = new HashSet<FYC_TRAN_Cause>();
        }

        [Key]
        public long CategoryID { get; set; }

        [StringLength(250)]
        public string CategoryName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        public long? CreatedBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FYC_TRAN_Cause> FYC_TRAN_Cause { get; set; }
    }
}
