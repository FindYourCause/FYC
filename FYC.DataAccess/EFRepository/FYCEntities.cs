namespace FYC.DataAccess.EFRepository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FYCEntities : DbContext
    {
        public FYCEntities()
            : base("name=FYCEntities")
        {
        }

        public virtual DbSet<Fyc_Def_Beneficiary> Fyc_Def_Beneficiary { get; set; }
        public virtual DbSet<Fyc_Def_Category> Fyc_Def_Category { get; set; }
        public virtual DbSet<Fyc_Def_Donors> Fyc_Def_Donors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fyc_Def_Beneficiary>()
                .Property(e => e.Extra)
                .IsFixedLength();

            modelBuilder.Entity<Fyc_Def_Beneficiary>()
                .Property(e => e.Extra2)
                .IsFixedLength();

            modelBuilder.Entity<Fyc_Def_Donors>()
                .Property(e => e.Extra)
                .IsFixedLength();

            modelBuilder.Entity<Fyc_Def_Donors>()
                .Property(e => e.Extra2)
                .IsFixedLength();
        }
    }
}
