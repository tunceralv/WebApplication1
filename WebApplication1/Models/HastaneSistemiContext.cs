using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class HastaneSistemiContext : DbContext
    {
        public HastaneSistemiContext()
        {
        }

        public HastaneSistemiContext(DbContextOptions<HastaneSistemiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminTable> AdminTables { get; set; } = null!;
        public virtual DbSet<BolumTable> BolumTables { get; set; } = null!;
        public virtual DbSet<DoktorTable> DoktorTables { get; set; } = null!;
        public virtual DbSet<Hasta> Hasta { get; set; } = null!;
        public virtual DbSet<RandevuTable> RandevuTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=HastaneSistemi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminTable>(entity =>
            {
                entity.HasKey(e => e.Adminid);

                entity.ToTable("AdminTable");

                entity.Property(e => e.AdminEmail).HasMaxLength(50);

                entity.Property(e => e.Adminsifre).HasMaxLength(50);
            });

            modelBuilder.Entity<BolumTable>(entity =>
            {
                entity.HasKey(e => e.Bolumid);

                entity.ToTable("bolumTable");

                entity.Property(e => e.Bolumisim)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DoktorTable>(entity =>
            {
                entity.HasKey(e => e.Doktorid);

                entity.ToTable("DoktorTable");

                entity.Property(e => e.CalismaGunleri)
                    .HasMaxLength(50)
                    .HasColumnName("calismaGunleri");

                entity.Property(e => e.CalismaSaatleri)
                    .HasMaxLength(50)
                    .HasColumnName("calismaSaatleri");

                entity.Property(e => e.DoktorAd).HasMaxLength(50);

                entity.Property(e => e.DoktorSoyad).HasMaxLength(50);

                entity.Property(e => e.DoktorUnvan).HasMaxLength(50);
            });

            modelBuilder.Entity<Hasta>(entity =>
            {
                entity.HasKey(e => e.Hastaid);

                entity.Property(e => e.HastaAd).HasMaxLength(50);

                entity.Property(e => e.HastaEmail).HasMaxLength(50);

                entity.Property(e => e.HastaSoyad).HasMaxLength(50);

                entity.Property(e => e.HastaTc).HasMaxLength(50);

                entity.Property(e => e.HastaTel).HasMaxLength(50);
            });

            modelBuilder.Entity<RandevuTable>(entity =>
            {
                entity.HasKey(e => e.Randevuid);

                entity.ToTable("RandevuTable");

                entity.Property(e => e.Bolum).HasMaxLength(50);

                entity.Property(e => e.DoktorAd).HasMaxLength(50);

                entity.Property(e => e.DoktorSoyad).HasMaxLength(50);

                entity.Property(e => e.HastaAd).HasMaxLength(50);

                entity.Property(e => e.HastaSoyad).HasMaxLength(50);

                entity.Property(e => e.HastaTc).HasMaxLength(50);

                entity.Property(e => e.HastaTel).HasMaxLength(50);

                entity.Property(e => e.RandevuGunu).HasMaxLength(50);

                entity.Property(e => e.RandevuSaati).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
