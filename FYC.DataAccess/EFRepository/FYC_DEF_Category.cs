namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fyc_Def_Category
    {
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
    }
}
