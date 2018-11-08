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

        public virtual DbSet<FYC_DEF_Category> FYC_DEF_Category { get; set; }
        public virtual DbSet<FYC_DEF_City> FYC_DEF_City { get; set; }
        public virtual DbSet<FYC_DEF_Contact> FYC_DEF_Contact { get; set; }
        public virtual DbSet<FYC_DEF_Country> FYC_DEF_Country { get; set; }
        public virtual DbSet<FYC_DEF_State> FYC_DEF_State { get; set; }
        public virtual DbSet<FYC_DEF_User> FYC_DEF_User { get; set; }
        public virtual DbSet<FYC_SYS_Role> FYC_SYS_Role { get; set; }
        public virtual DbSet<FYC_TRAN_Cause> FYC_TRAN_Cause { get; set; }
        public virtual DbSet<FYC_TRAN_CauseAttachment> FYC_TRAN_CauseAttachment { get; set; }
        public virtual DbSet<FYC_TRAN_CauseDetails> FYC_TRAN_CauseDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FYC_DEF_City>()
                .HasMany(e => e.FYC_DEF_Contact)
                .WithOptional(e => e.FYC_DEF_City)
                .HasForeignKey(e => e.CityID);

            modelBuilder.Entity<FYC_DEF_Country>()
                .HasMany(e => e.FYC_DEF_State)
                .WithOptional(e => e.FYC_DEF_Country)
                .HasForeignKey(e => e.CountryID);

            modelBuilder.Entity<FYC_DEF_State>()
                .HasMany(e => e.FYC_DEF_City)
                .WithOptional(e => e.FYC_DEF_State)
                .HasForeignKey(e => e.StateID);

            modelBuilder.Entity<FYC_DEF_User>()
                .HasMany(e => e.FYC_DEF_Contact)
                .WithOptional(e => e.FYC_DEF_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<FYC_DEF_User>()
                .HasMany(e => e.FYC_TRAN_Cause)
                .WithOptional(e => e.FYC_DEF_User)
                .HasForeignKey(e => e.UserID);

            modelBuilder.Entity<FYC_SYS_Role>()
                .HasMany(e => e.FYC_DEF_User)
                .WithOptional(e => e.FYC_SYS_Role)
                .HasForeignKey(e => e.RoleID);

            modelBuilder.Entity<FYC_TRAN_Cause>()
                .HasMany(e => e.FYC_TRAN_CauseAttachment)
                .WithOptional(e => e.FYC_TRAN_Cause)
                .HasForeignKey(e => e.CauseID);

            modelBuilder.Entity<FYC_TRAN_Cause>()
                .HasMany(e => e.FYC_TRAN_CauseDetails)
                .WithOptional(e => e.FYC_TRAN_Cause)
                .HasForeignKey(e => e.CauseID);
        }
    }
}
