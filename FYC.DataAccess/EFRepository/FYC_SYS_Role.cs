namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FYC_SYS_Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FYC_SYS_Role()
        {
            FYC_DEF_User = new HashSet<FYC_DEF_User>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Role { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FYC_DEF_User> FYC_DEF_User { get; set; }
    }
}
