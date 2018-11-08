namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FYC_DEF_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FYC_DEF_User()
        {
            FYC_DEF_Contact = new HashSet<FYC_DEF_Contact>();
            FYC_TRAN_Cause = new HashSet<FYC_TRAN_Cause>();
        }

        public long ID { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        public bool? IsActive { get; set; }

        public int? RoleID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FYC_DEF_Contact> FYC_DEF_Contact { get; set; }

        public virtual FYC_SYS_Role FYC_SYS_Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FYC_TRAN_Cause> FYC_TRAN_Cause { get; set; }
    }
}
