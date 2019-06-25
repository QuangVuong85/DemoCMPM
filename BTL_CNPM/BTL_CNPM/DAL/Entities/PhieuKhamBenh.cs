namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuKhamBenh")]
    public partial class PhieuKhamBenh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuKhamBenh()
        {
            ChiTietChiDinhCLS = new HashSet<ChiTietChiDinhCL>();
            ChiTietKhamBenhs = new HashSet<ChiTietKhamBenh>();
            ChuanDoans = new HashSet<ChuanDoan>();
            DonThuocs = new HashSet<DonThuoc>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaPhieuKhamBenh { get; set; }

        public DateTime? NgayKham { get; set; }

        public string TrieuChung { get; set; }

        public string KetLuan { get; set; }

        public int? HenKham { get; set; }

        [StringLength(10)]
        public string MaBenhNhan { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietChiDinhCL> ChiTietChiDinhCLS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKhamBenh> ChiTietKhamBenhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuanDoan> ChuanDoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonThuoc> DonThuocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
