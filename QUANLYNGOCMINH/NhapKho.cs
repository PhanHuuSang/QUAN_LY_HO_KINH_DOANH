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
    public partial class NhapKho : Form
    {
        QuanLyNgocMinh_Context context = new QuanLyNgocMinh_Context();
        String mamh = "";
        public NhapKho()
        {
            InitializeComponent();
            cmbNgay.Text = DateTime.Now.Day.ToString();
            cmbThang.Text = DateTime.Now.Month.ToString();
            cmbNam.Text = DateTime.Now.Year.ToString();
            txtMaHD.Text = "HDN_";
            txtMaHD.SelectionStart = txtMaHD.Text.Length;


        }
        public NhapKho (String mahd)
        {
            InitializeComponent();
            txtHoaDonNhap.Text = mahd.ToString();
            txtMaHD.Text = mahd.ToString();
            txtMaHD.Enabled = false;

            DateTime date = context.HOADONNHAPs.Where(nt => nt.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().NGAYLAP.Value;
            cmbNgay.Text = date.Day.ToString();
            cmbThang.Text = date.Month.ToString();
            cmbNam.Text = date.Year.ToString();

        }


        private void NhapHang_Load(object sender, EventArgs e)
        {
            string truyVan = "SELECT TENDONVI FROM HOADONNHAP GROUP BY TENDONVI";
            List<CTHDNhap> danhsach = context.Database.SqlQuery<CTHDNhap>(truyVan).ToList();
            txtDonVi.DataSource = danhsach;
            txtDonVi.DisplayMember = "TENDONVI";

            string truyVan1 = "SELECT NGUOIBAN FROM HOADONNHAP GROUP BY NGUOIBAN";
            List<CTHDNhap> danhsach1 = context.Database.SqlQuery<CTHDNhap>(truyVan1).ToList();
            txtNguoiGiaoHang.DataSource = danhsach1;
            txtNguoiGiaoHang.DisplayMember = "NGUOIBAN";

            if (txtMaHD.Text.Equals("HDN_"))
            {
                txtNguoiGiaoHang.Text = "";
                txtDonVi.Text = "";
            }
            else
            {
                txtNguoiGiaoHang.Text = context.HOADONNHAPs.Where(hd => hd.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().NGUOIBAN;
                txtDonVi.Text = context.HOADONNHAPs.Where(hd => hd.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().TENDONVI;
            }
            HienThiChiTietHoaDonNhap();
            this.rpvHDN.RefreshReport();
            ChuyenDuLieu();

        }

        private void HienThiChiTietHoaDonNhap()
        {
            txtSoLuong.Text = "";

            try
            {
                using (var _dbcontext = new QuanLyNgocMinh_Context())
                {
   
                    string truyVanSQL = "SELECT HDN.MAHDNHAP, HDN.NGUOIBAN, HDN.TENDONVI, HDN.MST, DIACHI, HDN.DIADIEMNHAPKHO, LYDO, NGAYLAP, SP.MASP, TENSP, SP.DONVI, SOLUONG, DONGIA, CTHDN.DONVI as TIENTE FROM CHITIETHOADONNHAP CTHDN, SANPHAM SP, HOADONNHAP HDN WHERE CTHDN.MASP = SP.MASP and HDN.MAHDNHAP = CTHDN.MAHDNHAP";

                    List<HOKINHDOANH> hOKINHDOANHs = new List<HOKINHDOANH>();
                    HOKINHDOANH hkd = new HOKINHDOANH();
                    hkd.TENHOKINHDOANH = _dbcontext.HOKINHDOANHs.FirstOrDefault().TENHOKINHDOANH.ToUpper();
                    hkd.DIACHI = _dbcontext.HOKINHDOANHs.FirstOrDefault().DIACHI;
                    hkd.MASOTHUE = _dbcontext.HOKINHDOANHs.FirstOrDefault().MASOTHUE;
                    hOKINHDOANHs.Add(hkd);
   

                    List<NGAYTHANGNAM> dateTime = new List<NGAYTHANGNAM>();

                    NGAYTHANGNAM date = new NGAYTHANGNAM();
                    date.dateTime = new DateTime(int.Parse(cmbNam.Text.Trim()), int.Parse(cmbThang.Text.Trim()), int.Parse(cmbNgay.Text.Trim()), DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    try
                    {
                        date.TienTe = Tien.Utils.NumberToText(double.Parse(context.HOADONNHAPs.Where(hd => hd.MAHDNHAP.Equals(txtHoaDonNhap.Text)).FirstOrDefault().THANHTIEN.ToString()));
                    }
                    catch
                    {

                    }
                    dateTime.Add(date);

                    if (!txtHoaDonNhap.Text.Trim().Equals(""))
                    {
                        context.HOADONNHAPs.Where(hd => hd.MAHDNHAP.Equals(txtHoaDonNhap.Text)).FirstOrDefault().NGAYLAP = date.dateTime;
                    }

                    List<CTHDNhap> danhsach = _dbcontext.Database.SqlQuery<CTHDNhap>(truyVanSQL).ToList();

                    danhsach = danhsach.Where(cthd => cthd.MaHDNhap == txtHoaDonNhap.Text).ToList();
                    this.rpvHDN.LocalReport.ReportPath = "../../ChiTietHDNhapReport.rdlc";
                    var reportDataSource = new ReportDataSource("CTHDNhapDataSet", danhsach);
                    var reportDataSource1 = new ReportDataSource("NgayThangNam", dateTime);
                    var reportDataSource2 = new ReportDataSource("HoKinhDoanh", hOKINHDOANHs);


                    this.rpvHDN.LocalReport.DataSources.Clear();
                    this.rpvHDN.LocalReport.DataSources.Add(reportDataSource);
                    this.rpvHDN.LocalReport.DataSources.Add(reportDataSource1);
                    this.rpvHDN.LocalReport.DataSources.Add(reportDataSource2);
                    this.rpvHDN.RefreshReport();

                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("VUI LÒNG CHỌN ĐÚNG NGÀY THÁNG", "THÔNG BÁO", MessageBoxButtons.OK);

            }
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            txtTon.Text = "";
            txtMST.Text = "";
            txtDiaChi.Text = "";
            txtSanPham.Text = "";
            txtHoaDonNhap.Text = "";
            txtTimKiem.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtMaHD.Text = "HDN_";
            string truyVan = "SELECT TENDONVI FROM HOADONNHAP GROUP BY TENDONVI";
            List<CTHDNhap> danhsach = context.Database.SqlQuery<CTHDNhap>(truyVan).ToList();
            txtDonVi.DataSource = danhsach;
            txtDonVi.DisplayMember = "TENDONVI";
            txtDonVi.Text = "";
            string truyVan1 = "SELECT NGUOIBAN FROM HOADONNHAP GROUP BY NGUOIBAN";
            List<CTHDNhap> danhsach1 = context.Database.SqlQuery<CTHDNhap>(truyVan1).ToList();
            txtNguoiGiaoHang.DataSource = danhsach1;
            txtNguoiGiaoHang.DisplayMember = "NGUOIBAN";
            txtNguoiGiaoHang.Text = "";
            txtMaHD.Enabled = true;
            cmbNgay.Text = DateTime.Now.Day.ToString();
            cmbThang.Text = DateTime.Now.Month.ToString();
            cmbNam.Text = DateTime.Now.Year.ToString();
            HienThiChiTietHoaDonNhap();
            txtMaHD.SelectionStart = txtMaHD.Text.Length;


        }

        private void dgvMH_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtSanPham.Text = dgvMH.Rows[e.RowIndex].Cells[2].Value.ToString();
                mamh = dgvMH.Rows[e.RowIndex].Cells[1].Value.ToString();
                HienDonGia();
                KTSLTON();

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

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void HienDonGia()
        {
            try
            {
                txtDonGia.Text = context.CHITIETHOADONNHAPs.Where(sp => sp.MASP.Equals(mamh)).OrderByDescending(ng => ng.MAHDNHAP).FirstOrDefault().DONGIA.ToString();
                txtDonGia.Text = txtDonGia.Text = int.Parse(txtDonGia.Text.Replace(".", "").
                    Replace(",", "").Replace(" ", "")).ToString("C").Trim();
            }
            catch
            {
                txtDonGia.Text = "";
            }
        }
        private void KTSLTON()
        {
            int i = 0;
            int nhap = 0;
            int xuat = 0;
            try
            {

                i = 0;
                xuat = context.CHITIETHOADONXUATs.Where(mh => mh.MASP == mamh).Sum(mh => mh.SOLUONG).Value;
                i = 1;
                nhap = context.CHITIETHOADONNHAPs.Where(mh => mh.MASP == mamh).Sum(mh => mh.SOLUONG).Value;
                i = 2;
                txtTon.Text = (nhap - xuat).ToString();

            }
            catch
            {
                if(i == 0)
                {
                    txtTon.Text = context.CHITIETHOADONNHAPs.Where(mh => mh.MASP == mamh).Sum(mh => mh.SOLUONG).ToString();
                    if(txtTon.Text.Trim().Equals(""))
                    {
                        txtTon.Text = "0";
                    }    
                }    
                if(i == 1)
                {
                    txtTon.Text = (0 - xuat).ToString();
                }    
            }

        }

        private String DinhDangChu(String chuoi)
        {
            string[] a = chuoi.Trim().Split(' ');
            String dinhdang = a[0].ToString()[0].ToString().ToUpper() + a[0].Substring(1, a[0].Length - 1).ToLower();
            for (int i = 1; i <= a.Length - 1; i++)
            {
                dinhdang += " " + a[i].ToString()[0].ToString().ToUpper() + a[i].Substring(1, a[i].Length - 1).ToLower();
            }

            return dinhdang;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            int check = 0;

            try
            {
                if (txtMaHD.Text.Trim().Equals("HDN_"))
                {
                    MessageBox.Show("VUI LÒNG NHẬP MÃ HÓA ĐƠN ", "THÔNG BÁO", MessageBoxButtons.OK);
                    txtMaHD.Select();
                    return;
                }

                HOADONNHAP hdtt = context.HOADONNHAPs.Where(hd => hd.MAHDNHAP.Trim().Equals(txtMaHD.Text.Trim())).FirstOrDefault();
                if (hdtt != null && txtHoaDonNhap.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã Hóa Đơn " + txtMaHD.Text + " Đã Tồn Tại", "Chú Ý", MessageBoxButtons.OK);
                    txtMaHD.Select();
                    return;
                }

                if (!txtMaHD.Text.Trim().Equals("") && !txtDonVi.Text.Trim().Equals("") && !txtNguoiGiaoHang.Text.Trim().Equals("") && txtHoaDonNhap.Text.Equals(""))
                {

                        HOADONNHAP hOADONNHAP = new HOADONNHAP();
                        hOADONNHAP.MAHDNHAP = txtMaHD.Text;
                        hOADONNHAP.NGAYLAP = new DateTime(int.Parse(cmbNam.Text.Trim()), int.Parse(cmbThang.Text.Trim()), int.Parse(cmbNgay.Text.Trim()), DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                        hOADONNHAP.NGUOIBAN = DinhDangChu(txtNguoiGiaoHang.Text);
                        hOADONNHAP.TENDONVI = DinhDangChu(txtDonVi.Text);
                        hOADONNHAP.LYDO = "Mua Hàng Từ " + hOADONNHAP.NGUOIBAN.ToUpper();
                        hOADONNHAP.MST = txtMST.Text;
                        hOADONNHAP.DIACHI = DinhDangChu(txtDiaChi.Text);
                        hOADONNHAP.DIADIEMNHAPKHO = DinhDangChu(txtDiaDiemNhapKho.Text);
                        context.HOADONNHAPs.Add(hOADONNHAP);
                        txtHoaDonNhap.Text = hOADONNHAP.MAHDNHAP;
                        txtMaHD.Enabled = false;

                    }
                    else
                    {
                    if (txtNguoiGiaoHang.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("VUI LÒNG NHẬP NGƯỜI GIAO HÀNG", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtNguoiGiaoHang.Select();

                    }
                    if (txtMaHD.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("VUI LÒNG NHẬP MÃ HÓA ĐƠN ", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtMaHD.Select();
                    }
                    if (txtDonVi.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("VUI LÒNG NHẬP TÊN ĐƠN VỊ ", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtDonVi.Select();
                    }

                }
                    check = 3;
                    if (int.Parse(txtDonGia.Text.Replace(".", "").
                    Replace(",", "").Replace(" ", "").Trim()) > 0 && int.Parse(txtSoLuong.Text.Trim()) > 0)
                    {
                    check = 4;
                        if (!txtHoaDonNhap.Text.Equals(""))
                        {
                            CHITIETHOADONNHAP CTHDN = context.CHITIETHOADONNHAPs.Where(p => p.MAHDNHAP == txtHoaDonNhap.Text && p.MASP == mamh).FirstOrDefault();
                        if (CTHDN != null)
                        {

                            CTHDN.SOLUONG += int.Parse(txtSoLuong.Text);
                            CTHDN.DONGIA = int.Parse(txtDonGia.Text.Replace(".", "").
                            Replace(",", "").Replace(" ", "").Trim());

                            context.HOADONNHAPs.Where(p => p.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().NGUOIBAN = DinhDangChu(txtNguoiGiaoHang.Text);
                            context.HOADONNHAPs.Where(p => p.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().LYDO = "Bán Hàng Cho " + DinhDangChu(txtDonVi.Text);
                            context.HOADONNHAPs.Where(p => p.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().TENDONVI = DinhDangChu(txtDonVi.Text);
                            context.HOADONNHAPs.Where(p => p.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().DIACHI = DinhDangChu(txtDiaChi.Text);
                            context.HOADONNHAPs.Where(p => p.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().MST = txtMST.Text;
                            context.HOADONNHAPs.Where(p => p.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().DIADIEMNHAPKHO = DinhDangChu(txtDiaDiemNhapKho.Text);

                            context.SaveChanges();
                            String thongbao = context.CHITIETHOADONNHAPs.Where(mh => mh.MASP == mamh && mh.MAHDNHAP == txtHoaDonNhap.Text).Sum(mh => mh.SOLUONG).ToString();
                            if (thongbao.Equals(""))
                                thongbao = "0";
                            MessageBox.Show("SẢN PHẨM: \n" + txtSanPham.Text + "\n" + "Vừa Thêm: " + txtSoLuong.Text + "\n" + "Hiện Có: " + thongbao, "Thông Báo", MessageBoxButtons.OK);
                            KTSLTON();
                        }
                        else
                        {
                            CHITIETHOADONNHAP CTHDNM = new CHITIETHOADONNHAP();
                            CTHDNM.MASP = mamh;
                            CTHDNM.MAHDNHAP = txtHoaDonNhap.Text;
                            CTHDNM.SOLUONG = int.Parse(txtSoLuong.Text);
                            CTHDNM.DONGIA = int.Parse(txtDonGia.Text.Replace(".", "").
                            Replace(",", "").Replace(" ", ""));
                            CTHDNM.DONVI = "VND";
                            context.CHITIETHOADONNHAPs.Add(CTHDNM);
                            String thongbao = context.CHITIETHOADONNHAPs.Where(mh => mh.MASP == mamh && mh.MAHDNHAP == txtHoaDonNhap.Text).Sum(mh => mh.SOLUONG).ToString();
                            context.SaveChanges();
                            if (thongbao.Equals(""))
                                thongbao = "0";
                            MessageBox.Show("SẢN PHẨM: \n" + txtSanPham.Text + "\n" + "Vừa Thêm: " + txtSoLuong.Text + "\n" + "Hóa Đơn Hiện Có: " + thongbao, "Thông Báo", MessageBoxButtons.OK);
                            KTSLTON();


                        }
                        }

                    check = 4;

                    if (!txtHoaDonNhap.Text.Equals(""))
                        {
                            context.HOADONNHAPs.Where(hd => hd.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().THANHTIEN =
                            context.CHITIETHOADONNHAPs.Where(mh => mh.MAHDNHAP == txtHoaDonNhap.Text).Sum(mh => mh.SOLUONG * mh.DONGIA);
                            context.SaveChanges();
                        }
                        HienThiChiTietHoaDonNhap();
                    txtTimKiem.Select();


                }
                else
                    {
                        MessageBox.Show("Vui Lòng Nhập Số Lượng Và Đơn Giá > 0", "Chú Ý", MessageBoxButtons.OK);
                        txtDonGia.Select();
                    }

             





            }
            catch
            {
                HienThiChiTietHoaDonNhap();
                if (check == 3)
                {
                    MessageBox.Show("Kiểm Tra Số Lượng Và Đơn Giá", "Chú Ý", MessageBoxButtons.OK);
                    txtSoLuong.Select();
                }



            }

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                CHITIETHOADONNHAP CTHDN = context.CHITIETHOADONNHAPs.Where(p => p.MAHDNHAP == txtHoaDonNhap.Text && p.MASP == mamh).FirstOrDefault();
                context.CHITIETHOADONNHAPs.Remove(CTHDN);
                context.SaveChanges();
                MessageBox.Show("Đã Xóa Mặt Hàng: \n" + txtSanPham.Text, "Thông Báo", MessageBoxButtons.OK);
                KTSLTON();
                HienThiChiTietHoaDonNhap();
                if (!txtHoaDonNhap.Text.Equals(""))
                {
                    context.HOADONNHAPs.Where(hd => hd.MAHDNHAP == txtHoaDonNhap.Text).FirstOrDefault().THANHTIEN =
                    context.CHITIETHOADONNHAPs.Where(mh => mh.MAHDNHAP == txtHoaDonNhap.Text).Sum(mh => mh.SOLUONG * mh.DONGIA);
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
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


        private void txtDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtDonGia.Text = int.Parse(txtDonGia.Text.Replace(".","").
                    Replace(",", "").Replace(" ","")).ToString("C").Trim();
                txtDonGia.SelectionStart = txtDonGia.Text.Length;
            }
            catch (Exception ex)
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (cmbNam.Visible == false)
            {
                cmbNgay.Visible = true;
                cmbThang.Visible = true;
                cmbNam.Visible = true;
            }
            else
            {
                cmbNgay.Visible = false;
                cmbThang.Visible = false;
                cmbNam.Visible = false;
            }
        }

        private void Hien(object sender, EventArgs e)
        {
            try
            {
                if (!cmbNam.Text.Trim().Equals(""))
                    HienThiChiTietHoaDonNhap();
                if (!txtHoaDonNhap.Text.Trim().Equals(""))
                {
                    context.HOADONNHAPs.Where(mh => mh.MAHDNHAP.Equals(txtHoaDonNhap.Text)).FirstOrDefault().NGAYLAP = new DateTime(int.Parse(cmbNam.Text.Trim()), int.Parse(cmbThang.Text.Trim()), int.Parse(cmbNgay.Text.Trim()), DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Kiểm Tra Lại Ngày Tháng", "Chú Ý", MessageBoxButtons.OK);
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDonVi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HOADONNHAP hOADONNHAP = context.HOADONNHAPs.Where(p => p.TENDONVI.Equals(txtDonVi.Text)).FirstOrDefault();
                txtDiaChi.Text = hOADONNHAP.DIACHI;
                txtMST.Text = hOADONNHAP.MST;
                txtDiaDiemNhapKho.Text = hOADONNHAP.DIADIEMNHAPKHO;
                if (txtMaHD.Text.Trim().Equals("HDN_"))
                    txtMaHD.Select();
                else
                    txtTimKiem.Select();
            }
            catch
            {
                txtDiaChi.Text = "";
                txtMST.Text = "";
                txtDiaDiemNhapKho.Text = "";
            }
        }
    }
}
