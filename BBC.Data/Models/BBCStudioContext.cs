using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BBC.Data.Models
{
    public partial class BBCStudioContext : DbContext
    {
        public BBCStudioContext()
        {
        }

        public BBCStudioContext(DbContextOptions<BBCStudioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBrand> TblBrand { get; set; }
        public virtual DbSet<TblBrandSubscription> TblBrandSubscription { get; set; }
        public virtual DbSet<TblContributor> TblContributor { get; set; }
        public virtual DbSet<TblLog> TblLog { get; set; }
        public virtual DbSet<TblRole> TblRole { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BBCStudio;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBrand>(entity =>
            {
                entity.ToTable("tblBrand");

                entity.Property(e => e.BName)
                    .IsRequired()
                    .HasColumnName("B_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBrandSubscription>(entity =>
            {
                entity.ToTable("tblBrandSubscription");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EpisodeNameFormate)
                    .HasColumnName("Episode_Name_Formate")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfEpisod).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblContributor>(entity =>
            {
                entity.ToTable("tblContributor");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasColumnName("C_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblLog>(entity =>
            {
                entity.ToTable("tblLog");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.ToTable("tblRole");

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tblUser");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
