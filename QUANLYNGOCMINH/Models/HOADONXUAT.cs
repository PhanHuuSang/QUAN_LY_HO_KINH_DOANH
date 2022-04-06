namespace QUANLYNGOCMINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONXUAT")]
    public partial class HOADONXUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONXUAT()
        {
            CHITIETHOADONXUATs = new HashSet<CHITIETHOADONXUAT>();
        }

        [Key]
        [StringLength(30)]
        public string MAHDXUAT { get; set; }

        public DateTime? NGAYLAP { get; set; }

        [StringLength(255)]
        public string LYDO { get; set; }

        [StringLength(255)]
        public string NGUOIMUA { get; set; }

        [StringLength(255)]
        public string TENDONVI { get; set; }

        [StringLength(255)]
        public string DIACHI { get; set; }

        [StringLength(255)]
        public string MST { get; set; }

        public int? THANHTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADONXUAT> CHITIETHOADONXUATs { get; set; }
    }
}
