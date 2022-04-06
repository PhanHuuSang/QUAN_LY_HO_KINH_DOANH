namespace QUANLYNGOCMINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETHOADONNHAPs = new HashSet<CHITIETHOADONNHAP>();
            CHITIETHOADONXUATs = new HashSet<CHITIETHOADONXUAT>();
        }

        [Key]
        [StringLength(30)]
        public string MASP { get; set; }

        [StringLength(50)]
        public string TENSP { get; set; }

        [StringLength(50)]
        public string DONVI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONNHAP> CHITIETHOADONNHAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONXUAT> CHITIETHOADONXUATs { get; set; }
    }
}
