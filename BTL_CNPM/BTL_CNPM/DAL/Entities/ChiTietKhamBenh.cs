namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietKhamBenh")]
    public partial class ChiTietKhamBenh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCTKB { get; set; }

        public int? CanNang { get; set; }

        [StringLength(20)]
        public string HuyetAp { get; set; }

        public int? NhietDo { get; set; }

        public decimal? ChieuCao { get; set; }

        public int? Mach { get; set; }

        [StringLength(10)]
        public string MaPhieuKhamBenh { get; set; }

        public virtual PhieuKhamBenh PhieuKhamBenh { get; set; }
    }
}
