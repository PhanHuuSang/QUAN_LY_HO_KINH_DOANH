using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QUANLYNGOCMINH.Models
{
    public partial class QuanLyNgocMinh_Context : DbContext
    {
        public QuanLyNgocMinh_Context()
            : base("name=QuanLyNgocMinh_Context")
        {
        }

        public virtual DbSet<CHITIETHOADONNHAP> CHITIETHOADONNHAPs { get; set; }
        public virtual DbSet<CHITIETHOADONXUAT> CHITIETHOADONXUATs { get; set; }
        public virtual DbSet<HOADONNHAP> HOADONNHAPs { get; set; }
        public virtual DbSet<HOADONXUAT> HOADONXUATs { get; set; }
        public virtual DbSet<HOKINHDOANH> HOKINHDOANHs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETHOADONNHAP>()
                .Property(e => e.MASP)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADONNHAP>()
                .Property(e => e.MAHDNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADONXUAT>()
                .Property(e => e.MASP)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADONXUAT>()
                .Property(e => e.MAHDXUAT)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONNHAP>()
                .Property(e => e.MAHDNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONNHAP>()
                .Property(e => e.MST)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONXUAT>()
                .Property(e => e.MAHDXUAT)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONXUAT>()
                .Property(e => e.MST)
                .IsUnicode(false);

            modelBuilder.Entity<HOKINHDOANH>()
                .Property(e => e.MASOTHUE)
                .IsUnicode(false);

            modelBuilder.Entity<HOKINHDOANH>()
                .Property(e => e.SODIENTHOAI)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MASP)
                .IsUnicode(false);
        }
    }
}
