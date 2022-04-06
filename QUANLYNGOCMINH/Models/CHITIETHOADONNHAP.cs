namespace QUANLYNGOCMINH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADONNHAP")]
    public partial class CHITIETHOADONNHAP
    {
        [Key]
        public int STT { get; set; }

        [StringLength(30)]
        public string MASP { get; set; }

        [StringLength(30)]
        public string MAHDNHAP { get; set; }

        public int? SOLUONG { get; set; }

        [StringLength(20)]
        public string DONVI { get; set; }

        public int? DONGIA { get; set; }

        public virtual HOADONNHAP HOADONNHAP { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
