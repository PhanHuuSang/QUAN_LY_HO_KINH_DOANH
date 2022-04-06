namespace QUANLYNGOCMINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOKINHDOANH")]
    public partial class HOKINHDOANH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDHOKD { get; set; }

        [StringLength(50)]
        public string TENHOKINHDOANH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string MASOTHUE { get; set; }

        [StringLength(20)]
        public string SODIENTHOAI { get; set; }
    }
}
