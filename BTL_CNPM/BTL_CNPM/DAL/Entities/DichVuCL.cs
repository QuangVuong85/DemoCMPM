namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVuCLS")]
    public partial class DichVuCL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVuCL()
        {
            ChiTietChiDinhCLS = new HashSet<ChiTietChiDinhCL>();
        }

        [Key]
        [StringLength(10)]
        public string MaDichVu { get; set; }

        [StringLength(100)]
        public string TenDichVu { get; set; }

        public int? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietChiDinhCL> ChiTietChiDinhCLS { get; set; }
    }
}
