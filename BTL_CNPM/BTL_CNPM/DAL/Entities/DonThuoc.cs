namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonThuoc")]
    public partial class DonThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonThuoc()
        {
            ChiTietDonThuocs = new HashSet<ChiTietDonThuoc>();
        }

        [Key]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        public DateTime? NgayKeDon { get; set; }

        [StringLength(10)]
        public string MaPhieuKhamBenh { get; set; }

        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual PhieuKhamBenh PhieuKhamBenh { get; set; }
    }
}
