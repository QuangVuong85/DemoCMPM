namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuanDoan")]
    public partial class ChuanDoan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhieuKhamBenh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaICD { get; set; }

        [StringLength(50)]
        public string LoaiChanDoan { get; set; }

        public DateTime? NgayChuanDoan { get; set; }

        public virtual BangICD BangICD { get; set; }

        public virtual PhieuKhamBenh PhieuKhamBenh { get; set; }
    }
}
