namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            DonThuocs = new HashSet<DonThuoc>();
            HoaDons = new HashSet<HoaDon>();
            PhieuTiepNhans = new HashSet<PhieuTiepNhan>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [StringLength(100)]
        public string TenNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(20)]
        public string GioiTinh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string HocHam { get; set; }

        [StringLength(50)]
        public string HocVi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonThuoc> DonThuocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTiepNhan> PhieuTiepNhans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
