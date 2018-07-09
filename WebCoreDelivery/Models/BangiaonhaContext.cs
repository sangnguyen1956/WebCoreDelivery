using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebCoreDelivery.Models
{
    public partial class BangiaonhaContext : DbContext
    {
        public BangiaonhaContext()
        {
        }

        public BangiaonhaContext(DbContextOptions<BangiaonhaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<Info> Info { get; set; }
        public virtual DbSet<Lichgiao> Lichgiao { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Rule> Rule { get; set; }
        public virtual DbSet<User> User { get; set; }

        // Unable to generate entity type for table 'dbo.User_Role'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Role_Rule'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_Info'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Info_LichGiao'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MinhSangPC;Database=Bangiaonha;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>(entity =>
            {
                entity.Property(e => e.Chucvu).HasMaxLength(50);

                entity.Property(e => e.Email1)
                    .HasColumnName("Email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Hoten).HasMaxLength(50);
            });

            modelBuilder.Entity<Info>(entity =>
            {
                entity.Property(e => e.InfoId).ValueGeneratedNever();

                entity.Property(e => e.Denngay).HasColumnType("datetime");

                entity.Property(e => e.Diachi).HasMaxLength(150);

                entity.Property(e => e.Duan).HasMaxLength(100);

                entity.Property(e => e.GiatriHd).HasColumnName("GiatriHD");

                entity.Property(e => e.Hoten).HasMaxLength(50);

                entity.Property(e => e.NgaykyHd)
                    .HasColumnName("NgaykyHD")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phantramdadong).HasMaxLength(10);

                entity.Property(e => e.SoHd).HasColumnName("SoHD");

                entity.Property(e => e.Solo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Stt)
                    .IsRequired()
                    .HasColumnName("STT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Thoigiangiao).HasColumnType("datetime");
            });

            modelBuilder.Entity<Lichgiao>(entity =>
            {
                entity.HasKey(e => e.Lgid);

                entity.Property(e => e.Lgid).HasColumnName("LGId");

                entity.Property(e => e.Ngaygiao).HasColumnType("date");

                entity.Property(e => e.SoHd).HasColumnName("SoHD");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Rule>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(10);

                entity.Property(e => e.Rulename).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password).HasMaxLength(150);

                entity.Property(e => e.Username).HasMaxLength(50);
            });
        }
    }
}
