namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fyc_Def_Beneficiary
    {
        [Key]
        public long BeneficiaryID { get; set; }

        [StringLength(250)]
        public string BeneficiaryName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        public long? ContactNumber { get; set; }

        [StringLength(50)]
        public string EmailID { get; set; }

        [StringLength(250)]
        public string BeneficiaryType { get; set; }

        [StringLength(30)]
        public string IDCard { get; set; }

        [StringLength(100)]
        public string ProfilePicture { get; set; }

        [StringLength(100)]
        public string Attachment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(10)]
        public string Extra { get; set; }

        [StringLength(10)]
        public string Extra2 { get; set; }
    }
}
