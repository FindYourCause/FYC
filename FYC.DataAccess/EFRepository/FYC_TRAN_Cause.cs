namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FYC_TRAN_Cause
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FYC_TRAN_Cause()
        {
            FYC_TRAN_CauseAttachment = new HashSet<FYC_TRAN_CauseAttachment>();
            FYC_TRAN_CauseDetails = new HashSet<FYC_TRAN_CauseDetails>();
        }

        public long ID { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public bool? IsOrganization { get; set; }

        [StringLength(150)]
        public string OrganizationName { get; set; }

        [StringLength(150)]
        public string Webiste { get; set; }

        public long? CategoryID { get; set; }

        public long? UserID { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? IsActive { get; set; }

        public virtual FYC_DEF_Category FYC_DEF_Category { get; set; }

        public virtual FYC_DEF_User FYC_DEF_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FYC_TRAN_CauseAttachment> FYC_TRAN_CauseAttachment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FYC_TRAN_CauseDetails> FYC_TRAN_CauseDetails { get; set; }
    }
}
