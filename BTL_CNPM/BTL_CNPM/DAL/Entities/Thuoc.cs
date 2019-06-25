namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuoc")]
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            ChiTietDonThuocs = new HashSet<ChiTietDonThuoc>();
        }

        [Key]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [StringLength(100)]
        public string TenThuoc { get; set; }

        [StringLength(50)]
        public string DuongDung { get; set; }

        [StringLength(50)]
        public string DVT { get; set; }

        public int? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonThuoc> ChiTietDonThuocs { get; set; }
    }
}
