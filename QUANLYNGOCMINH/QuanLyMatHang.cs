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
    public partial class QuanLyMatHang : Form
    {
        QuanLyNgocMinh_Context context = new QuanLyNgocMinh_Context();

        public QuanLyMatHang()
        {
            InitializeComponent();
        }

        private void QuanLyMatHang_Load(object sender, EventArgs e)
        {
            ChuyenDuLieu();

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

        public String ChuyenDoiDau(String str)
        {
            try
            {
                str = str.ToLower();
                String chuoimoi = "";
                String[] a = str.Split();
                for (int i = 0; i < a.Length; i++)
                    chuoimoi += ThayTheChu(a[i]);
                return chuoimoi;
            }
            catch
            {
                return "";
            }


        }


        private void ChuyenDuLieu()
        {
            gdvMH.Rows.Clear();
            List<SANPHAM> listMH = new List<SANPHAM>();

            listMH = context.SANPHAMs.OrderByDescending(o => o.MASP).ToList();

            foreach (SANPHAM item in listMH)
            {
                int index = gdvMH.Rows.Add();
                gdvMH.Rows[index].Cells[0].Value = (index + 1);
                gdvMH.Rows[index].Cells[1].Value = item.MASP;
                gdvMH.Rows[index].Cells[2].Value = item.TENSP;
                gdvMH.Rows[index].Cells[3].Value = item.DONVI;
                gdvMH.Rows[0].Selected = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    String tontai = context.SANPHAMs.Where(sp => sp.TENSP == txtTenMatHang.Text.Trim()).FirstOrDefault().MASP;
                    if (tontai != null)
                    {
                        MessageBox.Show("ĐÃ TỒN TẠI MẶT HÀNG NÀY", "CHÚ Ý", MessageBoxButtons.OK);

                    }

                }
                catch (Exception ex)
                {
                    if (!txtTenMatHang.Text.Trim().Equals("") && !txtDVT.Text.Trim().Equals(""))
                    {
                        String i = "01";
                        if (context.SANPHAMs.Count() > 0)
                        {
                            List<SANPHAM> sANPHAMs = context.SANPHAMs.OrderBy(p => p.MASP).ToList();
      
                            foreach(SANPHAM sp in sANPHAMs)
                            {
                                if (int.Parse(sp.MASP.ToString().Replace("MH_", "")) >= int.Parse(i))
                                    i = sp.MASP.ToString().Replace("MH_", "");
                            }    
                            int y = int.Parse(i) + 1;
                            if (y < 10)
                                i = "0" + y;
                            else
                                i = y.ToString();

                        }
                        SANPHAM sanpham = new SANPHAM();
                        sanpham.MASP = "MH_" + i;
                        sanpham.TENSP = DinhDangChu(txtTenMatHang.Text);
                        sanpham.DONVI = DinhDangChu(txtDVT.Text);
                        context.SANPHAMs.Add(sanpham);
                        context.SaveChanges();
                        MessageBox.Show("THÊM THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK);
                        txtDVT.Text = "";
                        txtMH.Text = sanpham.MASP;
                        txtTenMatHang.Text = "";
                        txtTimKiem.Text = "";
                        ChuyenDuLieu();
                        gdvMH.Rows[0].Selected = true;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("THÊM THẤT BẠI", "THÔNG BÁO", MessageBoxButtons.OK);
            }

        }

        private void gdvMH_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtMH.Text = gdvMH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenMatHang.Text = gdvMH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDVT.Text = gdvMH.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtMH.Text.Trim().Equals(""))
                {
                    String tenSP = context.SANPHAMs.Where(ct => ct.MASP == txtMH.Text).FirstOrDefault().TENSP;
                    String DonVi = context.SANPHAMs.Where(ct => ct.MASP == txtMH.Text).FirstOrDefault().DONVI;
                    if (!tenSP.Trim().Equals(txtTenMatHang.Text.Trim()) || !DonVi.Trim().Equals(txtDVT.Text.Trim()))
                    {
                        context.SANPHAMs.Where(ct => ct.MASP == txtMH.Text).FirstOrDefault().TENSP = txtTenMatHang.Text;
                        context.SANPHAMs.Where(ct => ct.MASP == txtMH.Text).FirstOrDefault().DONVI = txtDVT.Text;
                        context.SaveChanges();
                        MessageBox.Show("ĐÃ SỬA", "THÔNG BÁO", MessageBoxButtons.OK);
                        int i = gdvMH.SelectedRows[0].Index;
                        ChuyenDuLieu();
                        gdvMH.Rows[i].Selected = true;
                        txtTimKiem.Text = "";

                    }

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("SỬA THẤT BẠI", "THÔNG BÁO", MessageBoxButtons.OK);

            }
        }

        private void txtDVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void gdvMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenMatHang_TextChanged(object sender, EventArgs e)
        {

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
                gdvMH.Rows.Clear();
                List<SANPHAM> listMH = new List<SANPHAM>();

                listMH = context.SANPHAMs.OrderByDescending(o => o.MASP).ToList();

                foreach (SANPHAM item in listMH)
                {
                    int index = gdvMH.Rows.Add();
                    gdvMH.Rows[index].Cells[0].Value = (index + 1);
                    gdvMH.Rows[index].Cells[1].Value = item.MASP;
                    gdvMH.Rows[index].Cells[2].Value = item.TENSP;
                    gdvMH.Rows[index].Cells[3].Value = item.DONVI;
                    gdvMH.Rows[0].Selected = false;
                }
            }
            else
            {
                gdvMH.Rows.Clear();
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
                    int index = gdvMH.Rows.Add();
                    gdvMH.Rows[index].Cells[0].Value = (index + 1);
                    gdvMH.Rows[index].Cells[1].Value = item.MASP;
                    gdvMH.Rows[index].Cells[2].Value = item.TENSP;
                    gdvMH.Rows[index].Cells[3].Value = item.DONVI;
                    gdvMH.Rows[0].Selected = false;
                }
            }

        }

    }
}