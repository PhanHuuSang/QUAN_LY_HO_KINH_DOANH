
namespace QUANLYNGOCMINH
{
    partial class XuatKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.rpvHDN = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoaDonXuat = new System.Windows.Forms.Label();
            this.btnHoaDonMoi = new System.Windows.Forms.Button();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMH = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.Label();
            this.txtTon = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNgay = new System.Windows.Forms.ComboBox();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMST = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.ComboBox();
            this.txtNguoiNhanHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(413, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 49);
            this.label1.TabIndex = 30;
            this.label1.Text = "QUẢN LÝ XUẤT KHO HÀNG";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.Location = new System.Drawing.Point(1344, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Người Giao Hàng";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.AutoSize = true;
            this.txtTenSanPham.Location = new System.Drawing.Point(37, 270);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(181, 23);
            this.txtTenSanPham.TabIndex = 30;
            this.txtTenSanPham.Text = "Tìm Kiếm Sản Phẩm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTimKiem.Location = new System.Drawing.Point(222, 263);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(354, 30);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnThemSP.Location = new System.Drawing.Point(38, 574);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(165, 61);
            this.btnThemSP.TabIndex = 8;
            this.btnThemSP.Text = "Thêm Sản Phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sản Phẩm";
            // 
            // txtSanPham
            // 
            this.txtSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSanPham.Location = new System.Drawing.Point(165, 443);
            this.txtSanPham.Multiline = true;
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.ReadOnly = true;
            this.txtSanPham.Size = new System.Drawing.Size(358, 38);
            this.txtSanPham.TabIndex = 30;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnXoaSP.Location = new System.Drawing.Point(236, 574);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(169, 61);
            this.btnXoaSP.TabIndex = 9;
            this.btnXoaSP.Text = "Xóa Sản Phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSoLuong.Location = new System.Drawing.Point(167, 490);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(116, 30);
            this.txtSoLuong.TabIndex = 6;
            // 
            // rpvHDN
            // 
            this.rpvHDN.Location = new System.Drawing.Point(625, 164);
            this.rpvHDN.Name = "rpvHDN";
            this.rpvHDN.ServerReport.BearerToken = null;
            this.rpvHDN.Size = new System.Drawing.Size(791, 426);
            this.rpvHDN.TabIndex = 30;
            this.rpvHDN.ZoomPercent = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "MÃ HÓA ĐƠN XUẤT: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtHoaDonXuat
            // 
            this.txtHoaDonXuat.AutoSize = true;
            this.txtHoaDonXuat.Location = new System.Drawing.Point(829, 130);
            this.txtHoaDonXuat.Name = "txtHoaDonXuat";
            this.txtHoaDonXuat.Size = new System.Drawing.Size(0, 23);
            this.txtHoaDonXuat.TabIndex = 47;
            // 
            // btnHoaDonMoi
            // 
            this.btnHoaDonMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHoaDonMoi.Location = new System.Drawing.Point(435, 574);
            this.btnHoaDonMoi.Name = "btnHoaDonMoi";
            this.btnHoaDonMoi.Size = new System.Drawing.Size(142, 61);
            this.btnHoaDonMoi.TabIndex = 10;
            this.btnHoaDonMoi.Text = "HÓA ĐƠN MỚI";
            this.btnHoaDonMoi.UseVisualStyleBackColor = false;
            this.btnHoaDonMoi.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dvt.HeaderText = "Đơn Vị";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 98;
            // 
            // tenMH
            // 
            this.tenMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenMH.HeaderText = "Tên Mặt Hàng";
            this.tenMH.MinimumWidth = 6;
            this.tenMH.Name = "tenMH";
            this.tenMH.ReadOnly = true;
            this.tenMH.Width = 161;
            // 
            // maMH
            // 
            this.maMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maMH.HeaderText = "Mã MH";
            this.maMH.MinimumWidth = 6;
            this.maMH.Name = "maMH";
            this.maMH.ReadOnly = true;
            this.maMH.Width = 105;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 76;
            // 
            // dgvMH
            // 
            this.dgvMH.AllowUserToAddRows = false;
            this.dgvMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maMH,
            this.tenMH,
            this.dvt});
            this.dgvMH.Location = new System.Drawing.Point(41, 299);
            this.dgvMH.Name = "dgvMH";
            this.dgvMH.ReadOnly = true;
            this.dgvMH.RowHeadersWidth = 51;
            this.dgvMH.RowTemplate.Height = 24;
            this.dgvMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMH.Size = new System.Drawing.Size(537, 138);
            this.dgvMH.TabIndex = 30;
            this.dgvMH.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMH_CellMouseDown);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDonGia.Location = new System.Drawing.Point(167, 526);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(116, 30);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDonGia_KeyUp);
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.AutoSize = true;
            this.txtSoLuongTon.Location = new System.Drawing.Point(450, 488);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(169, 23);
            this.txtSoLuongTon.TabIndex = 30;
            this.txtSoLuongTon.Text = "Số Lượng Tồn Kho";
            // 
            // txtTon
            // 
            this.txtTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtTon.Enabled = false;
            this.txtTon.Location = new System.Drawing.Point(488, 522);
            this.txtTon.Name = "txtTon";
            this.txtTon.Size = new System.Drawing.Size(88, 30);
            this.txtTon.TabIndex = 30;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMaHD.Location = new System.Drawing.Point(168, 72);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(214, 30);
            this.txtMaHD.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Mã Hóa Đơn";
            // 
            // cmbNgay
            // 
            this.cmbNgay.BackColor = System.Drawing.Color.White;
            this.cmbNgay.DisplayMember = "1";
            this.cmbNgay.FormattingEnabled = true;
            this.cmbNgay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbNgay.Location = new System.Drawing.Point(1158, 130);
            this.cmbNgay.Name = "cmbNgay";
            this.cmbNgay.Size = new System.Drawing.Size(42, 31);
            this.cmbNgay.TabIndex = 30;
            this.cmbNgay.Tag = "";
            this.cmbNgay.Visible = false;
            this.cmbNgay.SelectedIndexChanged += new System.EventHandler(this.Hien);
            // 
            // cmbNam
            // 
            this.cmbNam.BackColor = System.Drawing.Color.White;
            this.cmbNam.DisplayMember = "1";
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.cmbNam.Location = new System.Drawing.Point(1254, 130);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(74, 31);
            this.cmbNam.TabIndex = 30;
            this.cmbNam.Tag = "";
            this.cmbNam.Visible = false;
            this.cmbNam.SelectedIndexChanged += new System.EventHandler(this.Hien);
            // 
            // cmbThang
            // 
            this.cmbThang.BackColor = System.Drawing.Color.White;
            this.cmbThang.DisplayMember = "1";
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(1206, 130);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(42, 31);
            this.cmbThang.TabIndex = 30;
            this.cmbThang.Tag = "";
            this.cmbThang.Visible = false;
            this.cmbThang.SelectedIndexChanged += new System.EventHandler(this.Hien);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tên Đơn Vị";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDiaChi.Location = new System.Drawing.Point(224, 193);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(354, 30);
            this.txtDiaChi.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Mã Số Thuế";
            // 
            // txtMST
            // 
            this.txtMST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMST.Location = new System.Drawing.Point(224, 227);
            this.txtMST.Name = "txtMST";
            this.txtMST.Size = new System.Drawing.Size(354, 30);
            this.txtMST.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Địa Chỉ";
            // 
            // txtDonVi
            // 
            this.txtDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDonVi.FormattingEnabled = true;
            this.txtDonVi.Location = new System.Drawing.Point(222, 156);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(356, 31);
            this.txtDonVi.TabIndex = 2;
            this.txtDonVi.TextChanged += new System.EventHandler(this.txtDonVi_TextChanged);
            // 
            // txtNguoiNhanHang
            // 
            this.txtNguoiNhanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNguoiNhanHang.FormattingEnabled = true;
            this.txtNguoiNhanHang.Location = new System.Drawing.Point(220, 118);
            this.txtNguoiNhanHang.Name = "txtNguoiNhanHang";
            this.txtNguoiNhanHang.Size = new System.Drawing.Size(356, 31);
            this.txtNguoiNhanHang.TabIndex = 1;
            // 
            // XuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1431, 647);
            this.Controls.Add(this.txtNguoiNhanHang);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtMST);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbNgay);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTon);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.dgvMH);
            this.Controls.Add(this.btnHoaDonMoi);
            this.Controls.Add(this.txtHoaDonXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rpvHDN);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.txtSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XuatKho";
            this.Load += new System.EventHandler(this.XuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTenSanPham;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private Microsoft.Reporting.WinForms.ReportViewer rpvHDN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtHoaDonXuat;
        private System.Windows.Forms.Button btnHoaDonMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridView dgvMH;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label txtSoLuongTon;
        private System.Windows.Forms.TextBox txtTon;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNgay;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMST;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtDonVi;
        private System.Windows.Forms.ComboBox txtNguoiNhanHang;
    }
}