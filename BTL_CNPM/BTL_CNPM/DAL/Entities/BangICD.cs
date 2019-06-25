namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangICD")]
    public partial class BangICD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BangICD()
        {
            ChuanDoans = new HashSet<ChuanDoan>();
        }

        [Key]
        [StringLength(10)]
        public string MaICD { get; set; }

        [StringLength(100)]
        public string TenBenh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuanDoan> ChuanDoans { get; set; }
    }
}
