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
    public partial class ThongKeDoanhThu : Form
    {
        QuanLyNgocMinh_Context context = new QuanLyNgocMinh_Context();

        public ThongKeDoanhThu()
        {
            InitializeComponent();

        }

        private void ChuyenDuLieu()
        {
            try
            {
                if (checkNhap.Checked)
                {
                    dgvHoaDon.Rows.Clear();
                    List<HOADONNHAP> listHDB = new List<HOADONNHAP>();

                    if(txtTimKiem.Text.Trim().Equals(""))
                    {
                        if(cmbThang.Text.Equals(""))
                        {
                            listHDB = context.HOADONNHAPs.Where(o => o.NGAYLAP.Value.Year.ToString().Trim().Equals(cmbNam.Text.Trim())).OrderByDescending(o => o.MAHDNHAP).ToList();
                        }
                        else
                        {
                            listHDB = context.HOADONNHAPs.Where(o => o.NGAYLAP.Value.Year.ToString().Trim().Equals(cmbNam.Text.Trim()) &&  o.NGAYLAP.Value.Month.ToString().Equals(cmbThang.Text)).OrderByDescending(o => o.MAHDNHAP).ToList();
                        }
                    }
                    else
                    {
                        if (cmbThang.Text.Equals(""))
                        {
                            listHDB = context.HOADONNHAPs.Where(o => (o.MAHDNHAP.ToUpper().Trim().Contains(txtTimKiem.Text.ToUpper().Trim()) || o.NGUOIBAN.ToUpper().Contains(txtTimKiem.Text.ToUpper())) && o.NGAYLAP.Value.Year.ToString().Trim().Equals(cmbNam.Text.Trim())).OrderByDescending(o => o.MAHDNHAP).ToList();
                        }
                        else
                        {
                            listHDB = context.HOADONNHAPs.Where(o => (o.MAHDNHAP.ToUpper().Trim().Contains(txtTimKiem.Text.ToUpper().Trim()) || o.NGUOIBAN.ToUpper().Contains(txtTimKiem.Text.ToUpper())) && o.NGAYLAP.Value.Year.ToString().Trim().Equals(cmbNam.Text.Trim()) && o.NGAYLAP.Value.Month.ToString().Equals(cmbThang.Text)).OrderByDescending(o => o.MAHDNHAP).ToList();
                        }
                    }

                    foreach (HOADONNHAP item in listHDB)
                    {
                        int index = dgvHoaDon.Rows.Add();
                        dgvHoaDon.Rows[index].Cells[0].Value = (index + 1);
                        dgvHoaDon.Rows[index].Cells[1].Value = item.MAHDNHAP;
                        dgvHoaDon.Rows[index].Cells[2].Value = string.Format(item.NGAYLAP.Value.ToString("dd/MM/yyyy"));
                        dgvHoaDon.Rows[index].Cells[3].Value = item.LYDO;
                        dgvHoaDon.Rows[index].Cells[4].Value = int.Parse(item.THANHTIEN.ToString().Replace(".", "").
                    Replace(",", "").Replace(" ", "")).ToString("C").Trim();
                        dgvHoaDon.Rows[0].Selected = false;
                    }
                }
                else
                {
                    dgvHoaDon.Rows.Clear();
                    List<HOADONXUAT> listHDB = new List<HOADONXUAT>();

                    if (txtTimKiem.Text.Trim().Equals(""))
                    {
                        if (cmbThang.Text.Equals(""))
                        {
                            listHDB = context.HOADONXUATs.Where(o => o.NGAYLAP.Value.Year.ToString().Trim().Equals(cmbNam.Text.Trim())).OrderByDescending(o => o.MAHDXUAT).ToList();
                        }
                        else
                        {
                            listHDB = context.HOADONXUATs.Where(o => o.NGAYLAP.Value.Year.ToString().Trim().Equals(cmbNam.Text.Trim()) && o.NGAYLAP.Value.Month.ToString().Equals(cmbThang.Text)).OrderByDescending(o => o.MAHDXUAT).ToList();
                        }
                    }
                    else
                    {
                        if (cmbThang.Text.Equals(""))
                        {
                            listHDB = context.HOADONXUATs.Where(o => (o.MAHDXUAT.ToUpper().Trim().Contains(txtTimKiem.Text.ToUpper().Trim()) || o.NGUOIMUA.ToUpper().Contains(txtTimKiem.Text.ToUpper())) && o.NGAYLAP.Value.Year.ToString().Trim().Equals(cmbNam.Text.Trim())).OrderByDescending(o => o.MAHDXUAT).ToList();
                        }
                        else
                        {
                            listHDB = context.HOADONXUATs.Where(o => (o.MAHDXUAT.ToUpper().Trim().Contains(txtTimKiem.Text.ToUpper().Trim()) || o.NGUOIMUA.ToUpper().Contains(txtTimKiem.Text.ToUpper())) && o.NGAYLAP.Value.Year.ToString().Trim().Equals(cmbNam.Text.Trim()) && o.NGAYLAP.Value.Month.ToString().Equals(cmbThang.Text)).OrderByDescending(o => o.MAHDXUAT).ToList();
                        }
                    }

                    foreach (HOADONXUAT item in listHDB)
                    {
                        int index = dgvHoaDon.Rows.Add();
                        dgvHoaDon.Rows[index].Cells[0].Value = (index + 1);
                        dgvHoaDon.Rows[index].Cells[1].Value = item.MAHDXUAT;
                        dgvHoaDon.Rows[index].Cells[2].Value = string.Format(item.NGAYLAP.Value.ToString("dd/MM/yyyy"));
                        dgvHoaDon.Rows[index].Cells[3].Value = item.LYDO;
                        dgvHoaDon.Rows[index].Cells[4].Value = int.Parse(item.THANHTIEN.ToString().Replace(".", "").
                    Replace(",", "").Replace(" ", "")).ToString("C").Trim();
                        dgvHoaDon.Rows[0].Selected = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void ThongKeDTTHANG()
        {
            try
            {
                txtDoanhThuThang.Text = "DOANH THU THÁNG " + string.Format(DateTime.Now.ToString("MM/yyyy"));
                btnThuThang.Text = string.Format("{0:#,##0}", context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month == DateTime.Now.Month && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                if (btnThuThang.Text.Equals(" đ"))
                    btnThuThang.Text = "0 đ";
                btnChiThang.Text = string.Format("{0:#,##0}", context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month == DateTime.Now.Month && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                if (btnChiThang.Text.Equals(" đ"))
                    btnChiThang.Text = "0 đ";
                btnLaiThang.Text = string.Format("{0:#,##0}", (int.Parse(context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month == DateTime.Now.Month && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()) - int.Parse(context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month == DateTime.Now.Month && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()))).Replace(",",".") + " đ";

            }
            catch (Exception ex)
            {
                if (btnThuThang.Text.Equals("0 đ"))
                    btnLaiThang.Text = "-" + btnThuThang.Text;
                if (btnChiThang.Text.Equals("0 đ"))
                    btnLaiThang.Text = btnThuThang.Text;

            }

        }

        private void ThongKeDTNAM()
        {
            try
            {

                txtDoanhThuNam.Text = "DOANH THU NĂM " + string.Format(DateTime.Now.ToString("yyyy"));
                btnThuNam.Text = string.Format("{0:#,##0}", context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                if (btnThuNam.Text.Equals(" đ"))
                    btnThuNam.Text = "0 đ";
                btnChiNam.Text = string.Format("{0:#,##0}", context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                if (btnChiNam.Text.Equals(" đ"))
                    btnChiNam.Text = "0 đ";
                btnLaiNam.Text = string.Format("{0:#,##0}", (int.Parse(context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()) - int.Parse(context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()))).Replace(",",".") + " đ";

            }
            catch (Exception ex)
            {
                if (btnThuNam.Text.Equals("0 đ"))
                    btnLaiNam.Text = "-" + btnThuNam.Text;
                if (btnChiNam.Text.Equals("0 đ"))
                    btnLaiNam.Text = btnThuNam.Text;
            }
        }



        private void ThongKeDTQUY()
        {
            try
            {

                int thang = int.Parse(string.Format(DateTime.Now.ToString("MM")));
                if (thang <= 3)
                {
                    txtDoanhThuQuy.Text = "DOANH THU QUÝ (1->3)/" + string.Format(DateTime.Now.ToString("yyyy"));
                    btnThuQuy.Text = string.Format("{0:#,##0}", context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month <= 3 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                    if (btnThuQuy.Text.Equals(" đ"))
                        btnThuQuy.Text = "0 đ";
                    btnChiQuy.Text = string.Format("{0:#,##0}", context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month <= 3 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                    if (btnChiQuy.Text.Equals(" đ"))
                        btnChiQuy.Text = "0 đ";
                    btnLaiQuy.Text = string.Format("{0:#,##0}", (int.Parse(context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month <= 3 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()) - int.Parse(context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month <= 3 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()))).Replace(",",".") + " đ";
                }
                else if (thang <= 6)
                {
                    txtDoanhThuQuy.Text = "DOANH THU QUÝ (4->6)/" + string.Format(DateTime.Now.ToString("yyyy"));
                    btnThuQuy.Text = string.Format("{0:#,##0}", context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month >= 4 && mh.NGAYLAP.Value.Month <= 6 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                    if (btnThuQuy.Text.Equals(" đ"))
                        btnThuQuy.Text = "0 đ";
                    btnChiQuy.Text = string.Format("{0:#,##0}", context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month >= 4 && mh.NGAYLAP.Value.Month <= 6 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                    if (btnChiQuy.Text.Equals(" đ"))
                        btnChiQuy.Text = "0 đ";
                    btnLaiQuy.Text = string.Format("{0:#,##0}", (int.Parse(context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month >= 4 && mh.NGAYLAP.Value.Month <= 6 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()) - int.Parse(context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month >= 4 && mh.NGAYLAP.Value.Month <= 6 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()))).Replace(",",".") + " đ";
                }
                else if (thang <= 9)
                {
                    txtDoanhThuQuy.Text = "DOANH THU QUÝ (7->9)/" + string.Format(DateTime.Now.ToString("yyyy"));
                    btnThuQuy.Text = string.Format("{0:#,##0}", context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month >= 7 && mh.NGAYLAP.Value.Month <= 9 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                    if (btnThuQuy.Text.Equals(" đ"))
                        btnThuQuy.Text = "0 đ";
                    btnChiQuy.Text = string.Format("{0:#,##0}", context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month >= 7 && mh.NGAYLAP.Value.Month <= 9 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                    if (btnChiQuy.Text.Equals(" đ"))
                        btnChiQuy.Text = "0 đ";
                    btnLaiQuy.Text = string.Format("{0:#,##0}", (int.Parse(context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month >= 7 && mh.NGAYLAP.Value.Month <= 9 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()) - int.Parse(context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month >= 7 && mh.NGAYLAP.Value.Month <= 9 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()))).Replace(",",".") + " đ";
                }
                else
                {
                    txtDoanhThuQuy.Text = "DOANH THU QUÝ (10->12)/" + string.Format(DateTime.Now.ToString("yyyy"));
                    btnThuQuy.Text = string.Format("{0:#,##0}", context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month >= 10 && mh.NGAYLAP.Value.Month <= 12 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                    if (btnThuQuy.Text.Equals(" đ"))
                        btnThuQuy.Text = "0 đ";
                    btnChiQuy.Text = string.Format("{0:#,##0}", context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month >= 10 && mh.NGAYLAP.Value.Month <= 12 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN)).Replace(",",".") + " đ";
                    if (btnChiQuy.Text.Equals(" đ"))
                        btnChiQuy.Text = "0 đ";
                    btnLaiQuy.Text = string.Format("{0:#,##0}", (int.Parse(context.HOADONXUATs.Where(mh => mh.NGAYLAP.Value.Month >= 10 && mh.NGAYLAP.Value.Month <= 12 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()) - int.Parse(context.HOADONNHAPs.Where(mh => mh.NGAYLAP.Value.Month >= 10 && mh.NGAYLAP.Value.Month <= 12 && mh.NGAYLAP.Value.Year == DateTime.Now.Year).Sum(mh => mh.THANHTIEN).ToString()))).Replace(",",".") + " đ";
                }
            }
            catch (Exception ex)
            {
                if (btnThuQuy.Text.Equals("0 đ"))
                    btnLaiQuy.Text = "-" + btnThuQuy.Text;
                if (btnChiQuy.Text.Equals("0 đ"))
                    btnLaiQuy.Text = btnThuQuy.Text;
            }

        }

        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            cmbNam.Text = DateTime.Now.Year.ToString();
            cmbThang.Text = "";
            ThongKeDTTHANG();
            ThongKeDTQUY();
            ThongKeDTNAM();
            checkNhap.Checked = true;
            ChuyenDuLieu();
            this.rpvThongKeCTHD.RefreshReport();
            try
            {

                List<HOADONNHAP> listHDN = context.HOADONNHAPs.Where(hd => hd.THANHTIEN == null).ToList();

                foreach(HOADONNHAP hd in listHDN)
                {
                    List<CHITIETHOADONNHAP> CTHDN = context.CHITIETHOADONNHAPs.Where(p => p.MAHDNHAP == hd.MAHDNHAP).ToList();
                    foreach (CHITIETHOADONNHAP cthd in CTHDN)
                    {
                        context.CHITIETHOADONNHAPs.Remove(cthd);
                        context.SaveChanges();
                    }
                    HOADONNHAP hdn = context.HOADONNHAPs.Where(p => p.MAHDNHAP == hd.MAHDNHAP).FirstOrDefault();
                    context.HOADONNHAPs.Remove(hdn);
                    context.SaveChanges();
                    txtMaHoaDon.Text = "";
                    ChuyenDuLieu();
                }    

                List<HOADONXUAT> listHDX = context.HOADONXUATs.Where(hd => hd.THANHTIEN == null).ToList();


                foreach(HOADONXUAT hd in listHDX)
                {
                    List<CHITIETHOADONXUAT> CTHDX = context.CHITIETHOADONXUATs.Where(p => p.MAHDXUAT == hd.MAHDXUAT).ToList();
                    foreach (CHITIETHOADONXUAT cthd in CTHDX)
                    {
                        context.CHITIETHOADONXUATs.Remove(cthd);
                        context.SaveChanges();
                    }
                    HOADONXUAT hdx = context.HOADONXUATs.Where(p => p.MAHDXUAT == hd.MAHDXUAT).FirstOrDefault();
                    context.HOADONXUATs.Remove(hdx);
                    context.SaveChanges();
                    ChuyenDuLieu();
                }    

                ThongKeDTTHANG();
                ThongKeDTQUY();
                ThongKeDTNAM();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void checkNhap_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Text = "";
                txtMaHoaDon.Text = "";
                checkXuat.Checked = false;
                checkNhap.Checked = true;
                ChuyenDuLieu();
                HienThiChiTietHoaDonNhap();
            }
            catch
            {

            }
            
        }

        private void checkXuat_Click(object sender, EventArgs e)
        {
            try
            {
                txtTimKiem.Text = "";
                txtMaHoaDon.Text = "";
                checkNhap.Checked = false;
                checkXuat.Checked = true;
                ChuyenDuLieu();
                HienThiChiTietHoaDonXuat();
            }
            catch
            {

            }
            
        }

        private void dgvHoaDon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtMaHoaDon.Text = dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (checkNhap.Checked)
                {
                    HienThiChiTietHoaDonNhap();
                }
                else
                {
                    HienThiChiTietHoaDonXuat();

                }

            }
            catch (Exception ex)
            {
            }
        }

        private void HienThiChiTietHoaDonNhap()
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


               

                List<CTHDNhap> danhsach = _dbcontext.Database.SqlQuery<CTHDNhap>(truyVanSQL).ToList();

                danhsach = danhsach.Where(cthd => cthd.MaHDNhap == txtMaHoaDon.Text).ToList();
                ;

                List<NGAYTHANGNAM> dateTime = new List<NGAYTHANGNAM>();
                NGAYTHANGNAM date = new NGAYTHANGNAM();
                date.dateTime = context.HOADONNHAPs.Where(hd => hd.MAHDNHAP == txtMaHoaDon.Text).FirstOrDefault().NGAYLAP.Value;
                try
                {
                    date.TienTe = Tien.Utils.NumberToText(double.Parse(context.HOADONNHAPs.Where(hd => hd.MAHDNHAP.Equals(txtMaHoaDon.Text)).FirstOrDefault().THANHTIEN.ToString()));
                    dateTime.Add(date);
                }
                catch
                {

                }
                dateTime.Add(date);


                this.rpvThongKeCTHD.LocalReport.ReportPath = "../../ChiTietHDNhapReport.rdlc";
                var reportDataSource = new ReportDataSource("CTHDNhapDataSet", danhsach);
                var reportDataSource1 = new ReportDataSource("NgayThangNam", dateTime);
                var reportDataSource2 = new ReportDataSource("HoKinhDoanh", hOKINHDOANHs);


                this.rpvThongKeCTHD.LocalReport.DataSources.Clear();
                this.rpvThongKeCTHD.LocalReport.DataSources.Add(reportDataSource);
                this.rpvThongKeCTHD.LocalReport.DataSources.Add(reportDataSource1);
                this.rpvThongKeCTHD.LocalReport.DataSources.Add(reportDataSource2);
                this.rpvThongKeCTHD.RefreshReport();

            }
        }

        private void HienThiChiTietHoaDonXuat()
        {
            using (var _dbcontext = new QuanLyNgocMinh_Context())
            {
                string truyVanSQL = "SELECT HDX.MAHDXUAT, HDX.NGUOIMUA, HDX.TENDONVI, HDX.MST, DIACHI, LYDO, NGAYLAP, SP.MASP, TENSP, SP.DONVI, SOLUONG, DONGIA, CTHDX.DONVI as TIENTE FROM CHITIETHOADONXUAT CTHDX, SANPHAM SP, HOADONXUAT HDX WHERE CTHDX.MASP = SP.MASP and HDX.MAHDXUAT = CTHDX.MAHDXUAT";

                List<HOKINHDOANH> hOKINHDOANHs = new List<HOKINHDOANH>();
                HOKINHDOANH hkd = new HOKINHDOANH();
                hkd.TENHOKINHDOANH = _dbcontext.HOKINHDOANHs.FirstOrDefault().TENHOKINHDOANH.ToUpper();
                hkd.DIACHI = _dbcontext.HOKINHDOANHs.FirstOrDefault().DIACHI;
                hkd.MASOTHUE = _dbcontext.HOKINHDOANHs.FirstOrDefault().MASOTHUE;

                hOKINHDOANHs.Add(hkd);

                List<CTHDXuat> danhsach = _dbcontext.Database.SqlQuery<CTHDXuat>(truyVanSQL).ToList();

                danhsach = danhsach.Where(cthd => cthd.MaHDXuat == txtMaHoaDon.Text).ToList();
                ;
                List<NGAYTHANGNAM> dateTime = new List<NGAYTHANGNAM>();
                NGAYTHANGNAM date = new NGAYTHANGNAM();
                date.dateTime = context.HOADONXUATs.Where(hd => hd.MAHDXUAT == txtMaHoaDon.Text).FirstOrDefault().NGAYLAP.Value;
                try
                {
                    date.TienTe = Tien.Utils.NumberToText(double.Parse(context.HOADONXUATs.Where(hd => hd.MAHDXUAT.Equals(txtMaHoaDon.Text)).FirstOrDefault().THANHTIEN.ToString()));
                    dateTime.Add(date);
                }
                catch
                {

                }
                dateTime.Add(date);

                this.rpvThongKeCTHD.LocalReport.ReportPath = "../../ChiTietHDXuatReport.rdlc";
                var reportDataSource = new ReportDataSource("CTHDXuatDataSet", danhsach);
                var reportDataSource1 = new ReportDataSource("NgayThangNam", dateTime);
                var reportDataSource2 = new ReportDataSource("HoKinhDoanh", hOKINHDOANHs);


                this.rpvThongKeCTHD.LocalReport.DataSources.Clear();
                this.rpvThongKeCTHD.LocalReport.DataSources.Add(reportDataSource);
                this.rpvThongKeCTHD.LocalReport.DataSources.Add(reportDataSource1);
                this.rpvThongKeCTHD.LocalReport.DataSources.Add(reportDataSource2);
                this.rpvThongKeCTHD.RefreshReport();

            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            ChuyenDuLieu();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChuyenDuLieu();
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChuyenDuLieu();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtMaHoaDon.Text.Equals(""))
                {
                    if(checkNhap.Checked)
                    {
                            List<CHITIETHOADONNHAP> CTHDN = context.CHITIETHOADONNHAPs.Where(p => p.MAHDNHAP == txtMaHoaDon.Text).ToList();
                            foreach(CHITIETHOADONNHAP cthd in CTHDN)
                            {
                               context.CHITIETHOADONNHAPs.Remove(cthd);
                               context.SaveChanges();
                            }
                             HOADONNHAP hdn = context.HOADONNHAPs.Where(p => p.MAHDNHAP == txtMaHoaDon.Text).FirstOrDefault();
                            context.HOADONNHAPs.Remove(hdn);
                            context.SaveChanges();


                             MessageBox.Show("Đã Xóa Hóa Đơn Nhập Kho: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.OK);
                             txtMaHoaDon.Text = "";
                             ChuyenDuLieu();

                    }    
                    else
                    {
                        List<CHITIETHOADONXUAT> CTHDX = context.CHITIETHOADONXUATs.Where(p => p.MAHDXUAT == txtMaHoaDon.Text).ToList();
                        foreach (CHITIETHOADONXUAT cthd in CTHDX)
                        {
                            context.CHITIETHOADONXUATs.Remove(cthd);
                            context.SaveChanges();
                        }
                        HOADONXUAT hdx = context.HOADONXUATs.Where(p => p.MAHDXUAT == txtMaHoaDon.Text).FirstOrDefault();
                        context.HOADONXUATs.Remove(hdx);
                        context.SaveChanges();


                        MessageBox.Show("Đã Xóa Hóa Đơn Xuất Kho: " + txtMaHoaDon.Text, "Thông Báo", MessageBoxButtons.OK);
                        txtMaHoaDon.Text = "";
                        ChuyenDuLieu();
                    }
                    ThongKeDTTHANG();
                    ThongKeDTQUY();
                    ThongKeDTNAM();
                }    

            }
            catch(Exception ex)
            {

            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if(!txtMaHoaDon.Text.Equals(""))
            {
                if(checkNhap.Checked == true)
                {
                    NhapKho nhapkho = new NhapKho(txtMaHoaDon.Text);
                    nhapkho.Show();
                    this.Hide();
                }   
                if(checkXuat.Checked == true)
                {
                    XuatKho xuatkho = new XuatKho(txtMaHoaDon.Text);
                    xuatkho.Show();
                    this.Hide();
                }    

            }    


        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(btnXoaHD.Visible == true)
            {
                btnXoaHD.Visible = false;
                btnSuaHD.Visible = false;
            }    
            else
            {
                btnXoaHD.Visible = true;
                btnSuaHD.Visible = true;
            }    
        }
    }
}
