namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietChiDinhCLS")]
    public partial class ChiTietChiDinhCL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhieuKhamBenh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaDichVu { get; set; }

        public DateTime? NgayCoKetQua { get; set; }

        [StringLength(100)]
        public string KetQua { get; set; }

        public virtual DichVuCL DichVuCL { get; set; }

        public virtual PhieuKhamBenh PhieuKhamBenh { get; set; }
    }
}
