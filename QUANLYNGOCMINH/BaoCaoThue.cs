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
    public partial class BaoCaoThue : Form
    {
        QuanLyNgocMinh_Context context = new QuanLyNgocMinh_Context();

        public BaoCaoThue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BaoCaoThue_Load(object sender, EventArgs e)
        {
            cmbNam.Text = DateTime.Now.Year.ToString();
            switch (DateTime.Now.Month)
            {
                case 1:
                case 2:
                case 3:
                    cmbQuy.Text = "QUÝ 1";
                    break;
                case 4:
                case 5:
                case 6:
                    cmbQuy.Text = "QUÝ 2";
                    break;
                case 7:
                case 8:
                case 9:
                    cmbQuy.Text = "QUÝ 3";
                    break;
                case 10:
                case 11:
                case 12:
                    cmbQuy.Text = "QUÝ 4";
                    break;
            }
            HienThiChiTiet3So();
            this.rpvMS1.RefreshReport();

        }

        private void HienThiChiTiet3So()
        {
            List<ThongTinSoChiTiet> listthongtin6so = new List<ThongTinSoChiTiet>();
            ThongTinSoChiTiet thongtin6so = new ThongTinSoChiTiet();
            thongtin6so.TenHoKinhDoanh = context.HOKINHDOANHs.FirstOrDefault().TENHOKINHDOANH.ToUpper();
            thongtin6so.DiaChi = context.HOKINHDOANHs.FirstOrDefault().DIACHI;
            thongtin6so.Nam = null;
            thongtin6so.TenSanPham = null;
            listthongtin6so.Add(thongtin6so);
            DateTime dauki = new DateTime();
            DateTime cuoiki = new DateTime();
            String quy = "";

            switch (cmbQuy.SelectedIndex)
            {
                case 0:
                     dauki = new DateTime(int.Parse(cmbNam.Text.Trim()), 1, 1, 0, 0, 0);
                     cuoiki = new DateTime(int.Parse(cmbNam.Text.Trim()), 4, 1, 0, 0, 0);
                     quy = "( TỪ 1/1/" + cmbNam.Text.Trim() + " ĐẾN 31/3/" + cmbNam.Text.Trim() + ")";
                    break;
                case 1:
                    dauki = new DateTime(int.Parse(cmbNam.Text.Trim()), 4, 1, 0, 0, 0);
                    cuoiki = new DateTime(int.Parse(cmbNam.Text.Trim()), 7, 1, 0, 0, 0);
                     quy = "( TỪ 1/4/" + cmbNam.Text.Trim() + " ĐẾN 30/6/" + cmbNam.Text.Trim() + ")";

                    break;
                case 2:
                    dauki = new DateTime(int.Parse(cmbNam.Text.Trim()), 7, 1, 0, 0, 0);
                    cuoiki = new DateTime(int.Parse(cmbNam.Text.Trim()), 10, 1, 0, 0, 0);
                    quy = "( TỪ 1/7/" + cmbNam.Text.Trim() + " ĐẾN 30/9/" + cmbNam.Text.Trim() + ")";
                    break;
                case 3:
                    dauki = new DateTime(int.Parse(cmbNam.Text.Trim()), 10, 1, 0, 0, 0);
                    cuoiki = new DateTime(int.Parse(cmbNam.Text.Trim()) + 1, 1, 1, 0, 0, 0);
                    quy = "( TỪ 1/10/" +cmbNam.Text.Trim()+ " ĐẾN 31/12/" + cmbNam.Text.Trim() + ")";
                    break;
            }

            string truyVan = "SELECT * FROM SANPHAM";
            List<BaoCaoBoSung> listsanpham = context.Database.SqlQuery<BaoCaoBoSung>(truyVan).ToList();

            List<NGAYTHANGNAM> dateTime = new List<NGAYTHANGNAM>();

            NGAYTHANGNAM date = new NGAYTHANGNAM();
            date.TienTe = quy;
            dateTime.Add(date);

            foreach (BaoCaoBoSung bc in listsanpham)
                {
                try
                {

                    bc.TonDauKy = ((context.CHITIETHOADONNHAPs.Where(p => p.MASP.Equals(bc.MASP) && p.HOADONNHAP.NGAYLAP.Value < dauki).Sum(p1 => p1.SOLUONG))
                        - context.CHITIETHOADONXUATs.Where(p => p.MASP.Equals(bc.MASP) && p.HOADONXUAT.NGAYLAP.Value < dauki).Sum(p1 => p1.SOLUONG)).ToString();
                    if (bc.TonDauKy.Equals(""))
                        bc.TonDauKy = "0";
                    bc.NhapTrongKy = context.CHITIETHOADONNHAPs.Where(p => p.MASP.Equals(bc.MASP) && p.HOADONNHAP.NGAYLAP >= dauki && p.HOADONNHAP.NGAYLAP < cuoiki).Sum(p1 => p1.SOLUONG).ToString();
                    if (bc.NhapTrongKy.Equals(""))
                        bc.NhapTrongKy = "0";
                    bc.XuatTrongKy = context.CHITIETHOADONXUATs.Where(p => p.MASP.Equals(bc.MASP) && p.HOADONXUAT.NGAYLAP >= dauki && p.HOADONXUAT.NGAYLAP < cuoiki).Sum(p1 => p1.SOLUONG).ToString();
                    if (bc.XuatTrongKy.Equals(""))
                        bc.XuatTrongKy = "0";

                    bc.TonCuoiKy = ((double.Parse(bc.TonDauKy) + double.Parse(bc.NhapTrongKy)) - double.Parse(bc.XuatTrongKy)).ToString();
                }
                catch
                {
                }

            }


            
            var reportDataSource = new ReportDataSource("ThongTin", listthongtin6so);
            var reportDataSource1 = new ReportDataSource("ThongKe", listsanpham);
            var reportDataSource2 = new ReportDataSource("NgayThangNam", dateTime);



            this.rpvMS1.LocalReport.ReportPath = "../../ToKhaiThue.rdlc";
            this.rpvMS1.LocalReport.DataSources.Clear();
            this.rpvMS1.LocalReport.DataSources.Add(reportDataSource);
            this.rpvMS1.RefreshReport();

            this.rpvMS2.LocalReport.ReportPath = "../../BangKe.rdlc";
            this.rpvMS2.LocalReport.DataSources.Clear();
            this.rpvMS2.LocalReport.DataSources.Add(reportDataSource);
            this.rpvMS2.RefreshReport();

            this.rpvMS3.LocalReport.ReportPath = "../../SoTheoDoiNhapXuat.rdlc";
            this.rpvMS3.LocalReport.DataSources.Clear();
            this.rpvMS3.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvMS3.LocalReport.DataSources.Add(reportDataSource2);

            this.rpvMS3.RefreshReport();
                      
        }

        private void cmbQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiChiTiet3So();
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiChiTiet3So();

        }
    }
}
