using Microsoft.Reporting.WinForms;
using QUANLYNGOCMINH.Models;
using QUANLYNGOCMINH.Reportings;
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
    public partial class SoChiTietVatLieu : Form
    {
        QuanLyNgocMinh_Context context = new QuanLyNgocMinh_Context();

        public SoChiTietVatLieu()
        {
            InitializeComponent();
        }


        private void HienThiChiTiet6So()
        {
            List<ThongTinSoChiTiet> listthongtin6so = new List<ThongTinSoChiTiet>();
            ThongTinSoChiTiet thongtin6so = new ThongTinSoChiTiet();
            thongtin6so.TenHoKinhDoanh = context.HOKINHDOANHs.FirstOrDefault().TENHOKINHDOANH.ToUpper();
            thongtin6so.DiaChi = context.HOKINHDOANHs.FirstOrDefault().DIACHI;
            thongtin6so.Nam = null;
            thongtin6so.TenSanPham = null;
            listthongtin6so.Add(thongtin6so);

            var reportDataSource = new ReportDataSource("ThongTin", listthongtin6so);


            this.rpvS1.LocalReport.ReportPath = "../../SoChiTietDoanhThu.rdlc";
            this.rpvS1.LocalReport.DataSources.Clear();
            this.rpvS1.LocalReport.DataSources.Add(reportDataSource);
            this.rpvS1.RefreshReport();
            this.rpvS3.LocalReport.ReportPath = "../../SoChiPhiSanXuat.rdlc";
            this.rpvS3.LocalReport.DataSources.Clear();
            this.rpvS3.LocalReport.DataSources.Add(reportDataSource);
            this.rpvS3.RefreshReport();
            this.rpvS4.LocalReport.ReportPath = "../../SoTheoDoiNghiaVuThue.rdlc";
            this.rpvS4.LocalReport.DataSources.Clear();
            this.rpvS4.LocalReport.DataSources.Add(reportDataSource);
            this.rpvS4.RefreshReport();
            this.rpvS5.LocalReport.ReportPath = "../../SoTheoDoiThanhToanTienLuong.rdlc";
            this.rpvS5.LocalReport.DataSources.Clear();
            this.rpvS5.LocalReport.DataSources.Add(reportDataSource);
            this.rpvS5.RefreshReport();
            this.rpvS6.LocalReport.ReportPath = "../../SoQuyTienMat.rdlc";
            this.rpvS6.LocalReport.DataSources.Clear();
            this.rpvS6.LocalReport.DataSources.Add(reportDataSource);
            this.rpvS6.RefreshReport();
            this.rpvS7.LocalReport.ReportPath = "../../SoTienGuiNganHang.rdlc";
            this.rpvS7.LocalReport.DataSources.Clear();
            this.rpvS7.LocalReport.DataSources.Add(reportDataSource);
            this.rpvS7.RefreshReport();
        }



        private void HienThiChiTietSoS2()
        {
            List<ThongTinSoChiTiet> listthongtinso = new List<ThongTinSoChiTiet>();
            ThongTinSoChiTiet thongtinso = new ThongTinSoChiTiet();
            thongtinso.TenHoKinhDoanh = context.HOKINHDOANHs.FirstOrDefault().TENHOKINHDOANH.ToUpper();
            thongtinso.DiaChi = context.HOKINHDOANHs.FirstOrDefault().DIACHI;
            thongtinso.Nam = cmbNam.Text;
            thongtinso.TenSanPham = txtSanPham.Text;
            listthongtinso.Add(thongtinso);
            

            if(cmbThang.Text.Trim().Equals(""))
            {
                using (var _dbcontext = new QuanLyNgocMinh_Context())
                {
                    String truyVanSQLNhap = "SELECT TENHOKINHDOANH, HKD.DIACHI, HDN.MAHDNHAP, HDN.NGUOIBAN, NGAYLAP, SP.MASP, TENSP, SP.DONVI, SOLUONG, DONGIA, CTHDN.DONVI as TIENTE FROM CHITIETHOADONNHAP CTHDN, SANPHAM SP, HOADONNHAP HDN, HOKINHDOANH HKD WHERE CTHDN.MASP = SP.MASP and HDN.MAHDNHAP = CTHDN.MAHDNHAP";

                    List<CTHDNhap> danhsachnhap = _dbcontext.Database.SqlQuery<CTHDNhap>(truyVanSQLNhap).ToList();
                    danhsachnhap = danhsachnhap.Where(cthd => cthd.MaSP == txtMaSP.Text && cthd.NgayLap.Year.ToString().Equals(cmbNam.Text)).OrderBy(p => p.NgayLap).ToList();

                    string truyVanSQLXuat = "SELECT TENHOKINHDOANH, HKD.DIACHI, HDX.MAHDXUAT, HDX.NGUOIMUA, LYDO, NGAYLAP, SP.MASP, TENSP, SP.DONVI, SOLUONG, DONGIA, CTHDX.DONVI as TIENTE FROM CHITIETHOADONXUAT CTHDX, SANPHAM SP, HOADONXUAT HDX, HOKINHDOANH HKD WHERE CTHDX.MASP = SP.MASP and HDX.MAHDXUAT = CTHDX.MAHDXUAT";


                    List<CTHDXuat> danhsachxuat = _dbcontext.Database.SqlQuery<CTHDXuat>(truyVanSQLXuat).ToList();
                    danhsachxuat = danhsachxuat.Where(cthd => cthd.MaSP == txtMaSP.Text && cthd.NgayLap.Year.ToString().Equals(cmbNam.Text)).OrderBy(p => p.NgayLap).ToList();



                    this.rpvS2.LocalReport.ReportPath = "../../SoChiTietVatLieu.rdlc";
                    var reportDataSource = new ReportDataSource("SoChiTietVatLieuNhap", danhsachnhap);
                    var reportDataSource1 = new ReportDataSource("SoChiTietVatLieuXuat", danhsachxuat);
                    var reportDataSource2 = new ReportDataSource("ThongTinSoChiTiet", listthongtinso);

                    this.rpvS2.LocalReport.DataSources.Clear();
                    this.rpvS2.LocalReport.DataSources.Add(reportDataSource);
                    this.rpvS2.LocalReport.DataSources.Add(reportDataSource1);
                    this.rpvS2.LocalReport.DataSources.Add(reportDataSource2);


                    this.rpvS2.RefreshReport();
                }
            }
            else
            {
                using (var _dbcontext = new QuanLyNgocMinh_Context())
                {
                    String truyVanSQLNhap = "SELECT TENHOKINHDOANH, HKD.DIACHI, HDN.MAHDNHAP, HDN.NGUOIBAN, NGAYLAP, SP.MASP, TENSP, SP.DONVI, SOLUONG, DONGIA, CTHDN.DONVI as TIENTE FROM CHITIETHOADONNHAP CTHDN, SANPHAM SP, HOADONNHAP HDN, HOKINHDOANH HKD WHERE CTHDN.MASP = SP.MASP and HDN.MAHDNHAP = CTHDN.MAHDNHAP";

                    List<CTHDNhap> danhsachnhap = _dbcontext.Database.SqlQuery<CTHDNhap>(truyVanSQLNhap).ToList();
                    danhsachnhap = danhsachnhap.Where(cthd => cthd.MaSP == txtMaSP.Text && cthd.NgayLap.Year.ToString().Equals(cmbNam.Text) && cthd.NgayLap.Month.ToString().Equals(cmbThang.Text)).OrderBy(p => p.NgayLap).ToList();

                    string truyVanSQLXuat = "SELECT TENHOKINHDOANH, HKD.DIACHI, HDX.MAHDXUAT, HDX.NGUOIMUA, LYDO, NGAYLAP, SP.MASP, TENSP, SP.DONVI, SOLUONG, DONGIA, CTHDX.DONVI as TIENTE FROM CHITIETHOADONXUAT CTHDX, SANPHAM SP, HOADONXUAT HDX, HOKINHDOANH HKD WHERE CTHDX.MASP = SP.MASP and HDX.MAHDXUAT = CTHDX.MAHDXUAT";


                    List<CTHDXuat> danhsachxuat = _dbcontext.Database.SqlQuery<CTHDXuat>(truyVanSQLXuat).ToList();
                    danhsachxuat = danhsachxuat.Where(cthd => cthd.MaSP == txtMaSP.Text && cthd.NgayLap.Year.ToString().Equals(cmbNam.Text) && cthd.NgayLap.Month.ToString().Equals(cmbThang.Text)).OrderBy(p => p.NgayLap).ToList();


                    this.rpvS2.LocalReport.ReportPath = "../../SoChiTietVatLieu.rdlc";
                    var reportDataSource = new ReportDataSource("SoChiTietVatLieuNhap", danhsachnhap);
                    var reportDataSource1 = new ReportDataSource("SoChiTietVatLieuXuat", danhsachxuat);
                    var reportDataSource2 = new ReportDataSource("ThongTinSoChiTiet", listthongtinso);


                    this.rpvS2.LocalReport.DataSources.Clear();
                    this.rpvS2.LocalReport.DataSources.Add(reportDataSource);
                    this.rpvS2.LocalReport.DataSources.Add(reportDataSource1);
                    this.rpvS2.LocalReport.DataSources.Add(reportDataSource2);


                    this.rpvS2.RefreshReport();
                }
            }    
            
        }



        private void SoChiTietVatLieu_Load(object sender, EventArgs e)
        {
            
            cmbThang.Text = DateTime.Now.Month.ToString();
            cmbNam.Text = DateTime.Now.Year.ToString();
            ChuyenDuLieu();
            HienThiChiTietSoS2();
            HienThiChiTiet6So();
            this.rpvS2.RefreshReport();
            this.rpvS1.RefreshReport();
        }



        public String ThayTheChu(String str)
        {

            str = str.ToLower();
            str = str.Replace("à", "a");
            str = str.Replace("á", "a");
            str = str.Replace("ạ", "a");
            str = str.Replace("ả", "a");
            str = str.Replace("ã", "a");
            str = str.Replace("â", "a");
            str = str.Replace("ầ", "a");
            str = str.Replace("ấ", "a");
            str = str.Replace("ậ", "a");
            str = str.Replace("ẩ", "a");
            str = str.Replace("ẫ", "a");
            str = str.Replace("ă", "a");
            str = str.Replace("ằ", "a");
            str = str.Replace("ắ", "a");
            str = str.Replace("ặ", "a");
            str = str.Replace("ẳ", "a");
            str = str.Replace("ẵ", "a");
            str = str.Replace("è", "e");
            str = str.Replace("é", "e");
            str = str.Replace("ẹ", "e");
            str = str.Replace("ẻ", "e");
            str = str.Replace("ẽ", "e");
            str = str.Replace("ê", "e");
            str = str.Replace("ề", "e");
            str = str.Replace("ế", "e");
            str = str.Replace("ệ", "e");
            str = str.Replace("ể", "e");
            str = str.Replace("ễ", "e");
            str = str.Replace("ì", "i");
            str = str.Replace("í", "i");
            str = str.Replace("ị", "i");
            str = str.Replace("ỉ", "i");
            str = str.Replace("ĩ", "i");
            str = str.Replace("ò", "o");
            str = str.Replace("ó", "o");
            str = str.Replace("ọ", "o");
            str = str.Replace("ỏ", "o");
            str = str.Replace("õ", "o");
            str = str.Replace("ô", "o");
            str = str.Replace("ồ", "o");
            str = str.Replace("ố", "o");
            str = str.Replace("ộ", "o");
            str = str.Replace("ổ", "o");
            str = str.Replace("ỗ", "o");
            str = str.Replace("ơ", "o");
            str = str.Replace("ờ", "o");
            str = str.Replace("ớ", "o");
            str = str.Replace("ợ", "o");
            str = str.Replace("ở", "o");
            str = str.Replace("ỡ", "o");
            str = str.Replace("ù", "u");
            str = str.Replace("ú", "u");
            str = str.Replace("ụ", "u");
            str = str.Replace("ủ", "u");
            str = str.Replace("ũ", "u");
            str = str.Replace("ư", "u");
            str = str.Replace("ừ", "u");
            str = str.Replace("ứ", "u");
            str = str.Replace("ự", "u");
            str = str.Replace("ử", "u");
            str = str.Replace("ữ", "u");
            str = str.Replace("ỳ", "y");
            str = str.Replace("ý", "y");
            str = str.Replace("ỵ", "y");
            str = str.Replace("ỷ", "y");
            str = str.Replace("ỹ", "y");
            str = str.Replace("đ", "d");

            return str;
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtTimKiem.Text.Trim().Equals(""))
            {
                dgvMH.Rows.Clear();
                List<SANPHAM> listMH = new List<SANPHAM>();

                listMH = context.SANPHAMs.OrderByDescending(o => o.MASP).ToList();

                foreach (SANPHAM item in listMH)
                {
                    int index = dgvMH.Rows.Add();
                    dgvMH.Rows[index].Cells[0].Value = (index + 1);
                    dgvMH.Rows[index].Cells[1].Value = item.MASP;
                    dgvMH.Rows[index].Cells[2].Value = item.TENSP;
                    dgvMH.Rows[index].Cells[3].Value = item.DONVI;
                    dgvMH.Rows[0].Selected = false;
                }
            }
            else
            {
                dgvMH.Rows.Clear();
                List<SANPHAM> list = new List<SANPHAM>();
                List<SANPHAM> listMH = new List<SANPHAM>();
                list = context.SANPHAMs.ToList();
                foreach (SANPHAM sanpham in list)
                {
                    if (ThayTheChu(sanpham.TENSP.Trim()).Contains(ThayTheChu(txtTimKiem.Text).Trim()))
                        listMH.Add(sanpham);
                }


                foreach (SANPHAM item in listMH)
                {
                    int index = dgvMH.Rows.Add();
                    dgvMH.Rows[index].Cells[0].Value = (index + 1);
                    dgvMH.Rows[index].Cells[1].Value = item.MASP;
                    dgvMH.Rows[index].Cells[2].Value = item.TENSP;
                    dgvMH.Rows[index].Cells[3].Value = item.DONVI;
                    dgvMH.Rows[0].Selected = false;
                }
            }

        }

        private void dgvMH_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtMaSP.Text = dgvMH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSanPham.Text = dgvMH.Rows[e.RowIndex].Cells[2].Value.ToString();
                HienThiChiTietSoS2();

            }
            catch (Exception ex)
            {
            }
        }
        private void ChuyenDuLieu()
        {

                dgvMH.Rows.Clear();
                List<SANPHAM> listMH = new List<SANPHAM>();

                listMH = context.SANPHAMs.OrderByDescending(o => o.MASP).ToList();

                foreach (SANPHAM item in listMH)
                {
                    int index = dgvMH.Rows.Add();
                    dgvMH.Rows[index].Cells[0].Value = (index + 1);
                    dgvMH.Rows[index].Cells[1].Value = item.MASP;
                    dgvMH.Rows[index].Cells[2].Value = item.TENSP;
                    dgvMH.Rows[index].Cells[3].Value = item.DONVI;
                    dgvMH.Rows[0].Selected = false;
                }

            
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiChiTietSoS2();
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiChiTietSoS2();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rpvS2_Load(object sender, EventArgs e)
        {

        }
    }
}
