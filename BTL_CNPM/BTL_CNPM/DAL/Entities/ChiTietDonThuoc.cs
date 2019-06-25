namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonThuoc")]
    public partial class ChiTietDonThuoc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDonThuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [StringLength(50)]
        public string LieuDung { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(150)]
        public string ChiDinh { get; set; }

        public virtual DonThuoc DonThuoc { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
