namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FYC_TRAN_CauseDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public long? CauseID { get; set; }

        [StringLength(500)]
        public string Address1 { get; set; }

        [StringLength(500)]
        public string Address2 { get; set; }

        [StringLength(500)]
        public string Address3 { get; set; }

        [StringLength(50)]
        public string PANCardNumber { get; set; }

        [StringLength(150)]
        public string BankName { get; set; }

        [StringLength(150)]
        public string BranchName { get; set; }

        [StringLength(150)]
        public string BankIFSCCode { get; set; }

        [StringLength(150)]
        public string BankAccountNumber { get; set; }

        [StringLength(150)]
        public string BankAccountHolder { get; set; }

        [StringLength(50)]
        public string AadhaarNumber { get; set; }

        [StringLength(150)]
        public string VoterID { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual FYC_TRAN_Cause FYC_TRAN_Cause { get; set; }
    }
}
