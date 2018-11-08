namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FYC_DEF_State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FYC_DEF_State()
        {
            FYC_DEF_City = new HashSet<FYC_DEF_City>();
        }

        public long ID { get; set; }

        public long? CountryID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FYC_DEF_City> FYC_DEF_City { get; set; }

        public virtual FYC_DEF_Country FYC_DEF_Country { get; set; }
    }
}
