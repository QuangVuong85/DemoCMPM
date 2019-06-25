namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanNhan")]
    public partial class ThanNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanNhan()
        {
            BenhNhans = new HashSet<BenhNhan>();
        }

        [Key]
        [StringLength(10)]
        public string MaThanNhan { get; set; }

        [StringLength(100)]
        public string TenThanNhan { get; set; }

        [StringLength(15)]
        public string CMND { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenhNhan> BenhNhans { get; set; }
    }
}
