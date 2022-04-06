namespace QUANLYNGOCMINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONNHAP")]
    public partial class HOADONNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONNHAP()
        {
            CHITIETHOADONNHAPs = new HashSet<CHITIETHOADONNHAP>();
        }

        [Key]
        [StringLength(30)]
        public string MAHDNHAP { get; set; }

        public DateTime? NGAYLAP { get; set; }

        [StringLength(255)]
        public string LYDO { get; set; }

        [StringLength(255)]
        public string NGUOIBAN { get; set; }

        [StringLength(255)]
        public string TENDONVI { get; set; }

        [StringLength(255)]
        public string DIACHI { get; set; }

        [StringLength(255)]
        public string MST { get; set; }

        [StringLength(255)]
        public string DIADIEMNHAPKHO { get; set; }

        public int? THANHTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONNHAP> CHITIETHOADONNHAPs { get; set; }
    }
}
