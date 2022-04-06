using QUANLYNGOCMINH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNGOCMINH
{
    public partial class frmGiaoDien : Form
    {
        QuanLyNgocMinh_Context context = new QuanLyNgocMinh_Context();
        QuanLyMatHang quanLyMatHang = new QuanLyMatHang();
        NhapKho nhapHang = new NhapKho();
        XuatKho xuatHang = new XuatKho();
        ThongKeDoanhThu thongke = new ThongKeDoanhThu();
        SoChiTietVatLieu soChiTietVatLieu = new SoChiTietVatLieu();
        BaoCaoThue baoCaoThue = new BaoCaoThue();

        public frmGiaoDien()
        {
            InitializeComponent();
        }

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {

            ChuyenDuLieu();
        }

        private void ChuyenDuLieu()
        {
            try
            {
                HOKINHDOANH HKD = context.HOKINHDOANHs.Where(tk => tk.IDHOKD == 1).FirstOrDefault();
                txtHoKinhDoanh.Text = HKD.TENHOKINHDOANH.ToUpper().ToString();
                txtDiaChi.Text = HKD.DIACHI.ToString();
                txtMaSoThue.Text = HKD.MASOTHUE.ToString();
                txtNamTaiChinh.Text = string.Format(DateTime.Now.ToString("yyyy")).ToUpper();
                txtSoDienThoai.Text = HKD.SODIENTHOAI.ToString();
            }
            catch (Exception ex) { }
            

        }


        private void btnQuanLyMatHang_Click(object sender, EventArgs e)
        {
                quanLyMatHang = new QuanLyMatHang();
                quanLyMatHang.Show();
                quanLyMatHang.Select();
                this.WindowState = FormWindowState.Minimized;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                HOKINHDOANH HKD = context.HOKINHDOANHs.Where(tk => tk.IDHOKD == 1).FirstOrDefault();
                HKD.MASOTHUE = txtMaSoThue.Text;
                HKD.SODIENTHOAI = txtSoDienThoai.Text;
                HKD.DIACHI = txtDiaChi.Text;
                HKD.TENHOKINHDOANH = txtHoKinhDoanh.Text;
                MessageBox.Show("Cập Nhập Thành Công");
                context.SaveChanges();
                frmGiaoDien_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cập Nhập Thất Bại");
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            nhapHang = new NhapKho();
            nhapHang.Show();
            nhapHang.Select();
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            xuatHang = new XuatKho();
            xuatHang.Show();
            xuatHang.Select();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            thongke = new ThongKeDoanhThu();
            thongke.Show();
            thongke.Select();
        }



        private void btnSoVatTu_Click(object sender, EventArgs e)
        {
            soChiTietVatLieu = new SoChiTietVatLieu();
            soChiTietVatLieu.Show();
            soChiTietVatLieu.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baoCaoThue = new BaoCaoThue();
            baoCaoThue.Show();
            baoCaoThue.Select();
        }
    }
}
