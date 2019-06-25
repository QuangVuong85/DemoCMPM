namespace BTL_CNPM.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BenhNhan")]
    public partial class BenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BenhNhan()
        {
            PhieuKhamBenhs = new HashSet<PhieuKhamBenh>();
            PhieuTiepNhans = new HashSet<PhieuTiepNhan>();
        }

        [Key]
        [StringLength(10)]
        public string MaBenhNhan { get; set; }

        [StringLength(100)]
        public string TenBenhNhan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string GioiTinh { get; set; }

        [StringLength(15)]
        public string CMND { get; set; }

        [StringLength(10)]
        public string MaThanNhan { get; set; }

        public virtual ThanNhan ThanNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKhamBenh> PhieuKhamBenhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTiepNhan> PhieuTiepNhans { get; set; }
    }
}
