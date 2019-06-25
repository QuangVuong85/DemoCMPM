namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelQLKhamBenh : DbContext
    {
        public ModelQLKhamBenh()
            : base("name=ModelQLKhamBenh")
        {
        }

        public virtual DbSet<BangICD> BangICDs { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<ChiTietChiDinhCL> ChiTietChiDinhCLS { get; set; }
        public virtual DbSet<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
        public virtual DbSet<ChiTietKhamBenh> ChiTietKhamBenhs { get; set; }
        public virtual DbSet<ChuanDoan> ChuanDoans { get; set; }
        public virtual DbSet<DichVuCL> DichVuCLS { get; set; }
        public virtual DbSet<DonThuoc> DonThuocs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuKhamBenh> PhieuKhamBenhs { get; set; }
        public virtual DbSet<PhieuTiepNhan> PhieuTiepNhans { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThanNhan> ThanNhans { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangICD>()
                .Property(e => e.MaICD)
                .IsUnicode(false);

            modelBuilder.Entity<BangICD>()
                .HasMany(e => e.ChuanDoans)
                .WithRequired(e => e.BangICD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaBenhNhan)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaThanNhan)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietChiDinhCL>()
                .Property(e => e.MaPhieuKhamBenh)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietChiDinhCL>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonThuoc>()
                .Property(e => e.MaDonThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonThuoc>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietKhamBenh>()
                .Property(e => e.HuyetAp)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietKhamBenh>()
                .Property(e => e.MaPhieuKhamBenh)
                .IsUnicode(false);

            modelBuilder.Entity<ChuanDoan>()
                .Property(e => e.MaPhieuKhamBenh)
                .IsUnicode(false);

            modelBuilder.Entity<ChuanDoan>()
                .Property(e => e.MaICD)
                .IsUnicode(false);

            modelBuilder.Entity<DichVuCL>()
                .Property(e => e.MaDichVu)
                .IsUnicode(false);

            modelBuilder.Entity<DichVuCL>()
                .HasMany(e => e.ChiTietChiDinhCLS)
                .WithRequired(e => e.DichVuCL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MaDonThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MaPhieuKhamBenh)
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<DonThuoc>()
                .HasMany(e => e.ChiTietDonThuocs)
                .WithRequired(e => e.DonThuoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPhieuKhamBenh)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.MaPhieuKhamBenh)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .Property(e => e.MaBenhNhan)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .HasMany(e => e.ChiTietChiDinhCLS)
                .WithRequired(e => e.PhieuKhamBenh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuKhamBenh>()
                .HasMany(e => e.ChuanDoans)
                .WithRequired(e => e.PhieuKhamBenh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuTiepNhan>()
                .Property(e => e.MaBenhNhan)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuTiepNhan>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<ThanNhan>()
                .Property(e => e.MaThanNhan)
                .IsUnicode(false);

            modelBuilder.Entity<ThanNhan>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<ThanNhan>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.TenThuoc)
                .IsFixedLength();

            modelBuilder.Entity<Thuoc>()
                .HasMany(e => e.ChiTietDonThuocs)
                .WithRequired(e => e.Thuoc)
                .WillCascadeOnDelete(false);
        }
    }
}
