namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FYC_DEF_Contact
    {
        public long ID { get; set; }

        [StringLength(150)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(150)]
        public string MiddleName { get; set; }

        [StringLength(500)]
        public string Address1 { get; set; }

        [StringLength(500)]
        public string Address2 { get; set; }

        public long? CityID { get; set; }

        public long? UserID { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public DateTime? CreatedDate { get; set; }

        public virtual FYC_DEF_City FYC_DEF_City { get; set; }

        public virtual FYC_DEF_User FYC_DEF_User { get; set; }
    }
}
