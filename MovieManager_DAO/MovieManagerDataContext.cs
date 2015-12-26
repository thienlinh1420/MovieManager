namespace MovieManager_DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieManagerDataContext : DbContext
    {
        public MovieManagerDataContext()
            : base("name=MovieManagerDataContext")
        {
        }

        public virtual DbSet<CUM_RAP_CHIEU_PHIM> CUM_RAP_CHIEU_PHIM { get; set; }
        public virtual DbSet<DANH_GIA_VA_BINH_LUAN> DANH_GIA_VA_BINH_LUAN { get; set; }
        public virtual DbSet<DANH_SACH_PHIM> DANH_SACH_PHIM { get; set; }
        public virtual DbSet<GHE> GHE { get; set; }
        public virtual DbSet<KHUYEN_MAI> KHUYEN_MAI { get; set; }
        public virtual DbSet<LOAI_NGUOI_DUNG> LOAI_NGUOI_DUNG { get; set; }
        public virtual DbSet<NGUOI_DUNG> NGUOI_DUNG { get; set; }
        public virtual DbSet<PHIM> PHIM { get; set; }
        public virtual DbSet<RAP_CHIEU_PHIM> RAP_CHIEU_PHIM { get; set; }
        public virtual DbSet<SUAT_CHIEU> SUAT_CHIEU { get; set; }
        public virtual DbSet<VE> VE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CUM_RAP_CHIEU_PHIM>()
                .HasMany(e => e.RAP_CHIEU_PHIM)
                .WithOptional(e => e.CUM_RAP_CHIEU_PHIM)
                .HasForeignKey(e => e.ID_CUM_RAP_CHIEU_PHIM);

            modelBuilder.Entity<DANH_GIA_VA_BINH_LUAN>()
                .Property(e => e.ID_NGUOI_DUNG)
                .IsUnicode(false);

            modelBuilder.Entity<DANH_SACH_PHIM>()
                .Property(e => e.ID_SUAT_CHIEU)
                .IsUnicode(false);

            modelBuilder.Entity<GHE>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<GHE>()
                .Property(e => e.Vi_tri_ghe)
                .IsUnicode(false);

            modelBuilder.Entity<GHE>()
                .Property(e => e.Phong)
                .IsUnicode(false);

            modelBuilder.Entity<GHE>()
                .HasMany(e => e.VE)
                .WithOptional(e => e.GHE)
                .HasForeignKey(e => e.ID_GHE);

            modelBuilder.Entity<LOAI_NGUOI_DUNG>()
                .HasMany(e => e.NGUOI_DUNG)
                .WithOptional(e => e.LOAI_NGUOI_DUNG)
                .HasForeignKey(e => e.ID_LOAI_NGUOI_DUNG);

            modelBuilder.Entity<NGUOI_DUNG>()
                .Property(e => e.Tai_khoan)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOI_DUNG>()
                .Property(e => e.Mat_khau)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOI_DUNG>()
                .Property(e => e.So_dien_thoai)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOI_DUNG>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOI_DUNG>()
                .HasMany(e => e.DANH_GIA_VA_BINH_LUAN)
                .WithOptional(e => e.NGUOI_DUNG)
                .HasForeignKey(e => e.ID_NGUOI_DUNG);

            modelBuilder.Entity<PHIM>()
                .Property(e => e.Duong_dan_Poster)
                .IsUnicode(false);

            modelBuilder.Entity<PHIM>()
                .Property(e => e.Trailer)
                .IsUnicode(false);

            modelBuilder.Entity<PHIM>()
                .HasMany(e => e.DANH_GIA_VA_BINH_LUAN)
                .WithOptional(e => e.PHIM)
                .HasForeignKey(e => e.ID_PHIM);

            modelBuilder.Entity<PHIM>()
                .HasMany(e => e.DANH_SACH_PHIM)
                .WithRequired(e => e.PHIM)
                .HasForeignKey(e => e.ID_PHIM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RAP_CHIEU_PHIM>()
                .HasMany(e => e.DANH_SACH_PHIM)
                .WithRequired(e => e.RAP_CHIEU_PHIM)
                .HasForeignKey(e => e.ID_RAP_CHIEU_PHIM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RAP_CHIEU_PHIM>()
                .HasOptional(e => e.KHUYEN_MAI)
                .WithRequired(e => e.RAP_CHIEU_PHIM);

            modelBuilder.Entity<SUAT_CHIEU>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SUAT_CHIEU>()
                .HasMany(e => e.DANH_SACH_PHIM)
                .WithRequired(e => e.SUAT_CHIEU)
                .HasForeignKey(e => e.ID_SUAT_CHIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUAT_CHIEU>()
                .HasMany(e => e.VE)
                .WithMany(e => e.SUAT_CHIEU)
                .Map(m => m.ToTable("DANH_SACH_VE").MapLeftKey("ID_SUAT_CHIEU").MapRightKey("ID_VE"));

            modelBuilder.Entity<VE>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<VE>()
                .Property(e => e.ID_GHE)
                .IsUnicode(false);
        }
    }
}
