namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuTiepNhan")]
    public partial class PhieuTiepNhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieuTiepNhan { get; set; }

        public DateTime? NgayNhan { get; set; }

        [StringLength(10)]
        public string MaBenhNhan { get; set; }

        [StringLength(10)]
        public string MaNhanVien { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
