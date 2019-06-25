namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHoaDon { get; set; }

        public DateTime? NgayLap { get; set; }

        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [StringLength(10)]
        public string MaPhieuKhamBenh { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual PhieuKhamBenh PhieuKhamBenh { get; set; }
    }
}
