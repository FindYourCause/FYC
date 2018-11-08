namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fyc_Def_Donors
    {
        [Key]
        public long DonorID { get; set; }

        [StringLength(250)]
        public string DonorName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        public long? ContactNumber { get; set; }

        [StringLength(50)]
        public string EmailID { get; set; }

        public bool? IsOrganization { get; set; }

        public bool? IsIndividual { get; set; }

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
