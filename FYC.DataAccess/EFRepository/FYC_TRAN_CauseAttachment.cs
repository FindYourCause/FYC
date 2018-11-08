namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FYC_TRAN_CauseAttachment
    {
        public long ID { get; set; }

        [StringLength(150)]
        public string AttachmentName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public long? CauseID { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual FYC_TRAN_Cause FYC_TRAN_Cause { get; set; }
    }
}
