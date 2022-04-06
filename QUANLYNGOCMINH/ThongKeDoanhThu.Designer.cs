
namespace QUANLYNGOCMINH
{
    partial class ThongKeDoanhThu
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiMuaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpvThongKeCTHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.Label();
            this.txtDoanhThuThang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDoanhThuQuy = new System.Windows.Forms.Label();
            this.txtDoanhThuNam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnThuThang = new System.Windows.Forms.TextBox();
            this.btnChiThang = new System.Windows.Forms.TextBox();
            this.btnLaiThang = new System.Windows.Forms.TextBox();
            this.btnThuQuy = new System.Windows.Forms.TextBox();
            this.btnChiQuy = new System.Windows.Forms.TextBox();
            this.btnLaiQuy = new System.Windows.Forms.TextBox();
            this.btnLaiNam = new System.Windows.Forms.TextBox();
            this.btnChiNam = new System.Windows.Forms.TextBox();
            this.btnThuNam = new System.Windows.Forms.TextBox();
            this.checkNhap = new System.Windows.Forms.CheckBox();
            this.checkXuat = new System.Windows.Forms.CheckBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(389, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 49);
            this.label1.TabIndex = 30;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(15, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maHD,
            this.ngayLap,
            this.nguoiMuaHang,
            this.tongTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(35, 191);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(661, 355);
            this.dgvHoaDon.TabIndex = 30;
            this.dgvHoaDon.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoaDon_CellMouseDown);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // maHD
            // 
            this.maHD.HeaderText = "Mã Hóa Đơn";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            this.maHD.ReadOnly = true;
            this.maHD.Width = 125;
            // 
            // ngayLap
            // 
            this.ngayLap.HeaderText = "Ngày Lập";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.ReadOnly = true;
            this.ngayLap.Width = 125;
            // 
            // nguoiMuaHang
            // 
            this.nguoiMuaHang.HeaderText = "Lý Do";
            this.nguoiMuaHang.MinimumWidth = 6;
            this.nguoiMuaHang.Name = "nguoiMuaHang";
            this.nguoiMuaHang.ReadOnly = true;
            this.nguoiMuaHang.Width = 200;
            // 
            // tongTien
            // 
            this.tongTien.HeaderText = "Tổng Tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            this.tongTien.Width = 125;
            // 
            // rpvThongKeCTHD
            // 
            this.rpvThongKeCTHD.Location = new System.Drawing.Point(702, 158);
            this.rpvThongKeCTHD.Name = "rpvThongKeCTHD";
            this.rpvThongKeCTHD.ServerReport.BearerToken = null;
            this.rpvThongKeCTHD.Size = new System.Drawing.Size(471, 388);
            this.rpvThongKeCTHD.TabIndex = 30;
            this.rpvThongKeCTHD.ZoomPercent = 90;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Location = new System.Drawing.Point(134, 157);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(434, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(702, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Chi Tiết Hóa Đơn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.AutoSize = true;
            this.txtMaHoaDon.Location = new System.Drawing.Point(877, 121);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(0, 23);
            this.txtMaHoaDon.TabIndex = 45;
            // 
            // txtDoanhThuThang
            // 
            this.txtDoanhThuThang.AutoSize = true;
            this.txtDoanhThuThang.Location = new System.Drawing.Point(1186, 125);
            this.txtDoanhThuThang.Name = "txtDoanhThuThang";
            this.txtDoanhThuThang.Size = new System.Drawing.Size(160, 23);
            this.txtDoanhThuThang.TabIndex = 30;
            this.txtDoanhThuThang.Text = "Doanh Thu Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1183, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1183, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Chi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1186, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Lời:";
            // 
            // txtDoanhThuQuy
            // 
            this.txtDoanhThuQuy.AutoSize = true;
            this.txtDoanhThuQuy.Location = new System.Drawing.Point(1186, 269);
            this.txtDoanhThuQuy.Name = "txtDoanhThuQuy";
            this.txtDoanhThuQuy.Size = new System.Drawing.Size(143, 23);
            this.txtDoanhThuQuy.TabIndex = 30;
            this.txtDoanhThuQuy.Text = "Doanh Thu Quý";
            // 
            // txtDoanhThuNam
            // 
            this.txtDoanhThuNam.AutoSize = true;
            this.txtDoanhThuNam.Location = new System.Drawing.Point(1186, 423);
            this.txtDoanhThuNam.Name = "txtDoanhThuNam";
            this.txtDoanhThuNam.Size = new System.Drawing.Size(146, 23);
            this.txtDoanhThuNam.TabIndex = 55;
            this.txtDoanhThuNam.Text = "Doanh Thu Năm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1186, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Lời:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1183, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Chi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1183, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Thu:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1187, 523);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 23);
            this.label17.TabIndex = 30;
            this.label17.Text = "Lời:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1187, 453);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 23);
            this.label18.TabIndex = 30;
            this.label18.Text = "Chi:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1187, 493);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 23);
            this.label19.TabIndex = 30;
            this.label19.Text = "Thu:";
            // 
            // btnThuThang
            // 
            this.btnThuThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThuThang.Location = new System.Drawing.Point(1239, 190);
            this.btnThuThang.Name = "btnThuThang";
            this.btnThuThang.ReadOnly = true;
            this.btnThuThang.Size = new System.Drawing.Size(145, 30);
            this.btnThuThang.TabIndex = 30;
            // 
            // btnChiThang
            // 
            this.btnChiThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChiThang.Location = new System.Drawing.Point(1239, 158);
            this.btnChiThang.Name = "btnChiThang";
            this.btnChiThang.ReadOnly = true;
            this.btnChiThang.Size = new System.Drawing.Size(145, 30);
            this.btnChiThang.TabIndex = 30;
            // 
            // btnLaiThang
            // 
            this.btnLaiThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLaiThang.Location = new System.Drawing.Point(1242, 222);
            this.btnLaiThang.Name = "btnLaiThang";
            this.btnLaiThang.ReadOnly = true;
            this.btnLaiThang.Size = new System.Drawing.Size(145, 30);
            this.btnLaiThang.TabIndex = 30;
            // 
            // btnThuQuy
            // 
            this.btnThuQuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThuQuy.Location = new System.Drawing.Point(1239, 332);
            this.btnThuQuy.Name = "btnThuQuy";
            this.btnThuQuy.ReadOnly = true;
            this.btnThuQuy.Size = new System.Drawing.Size(145, 30);
            this.btnThuQuy.TabIndex = 30;
            // 
            // btnChiQuy
            // 
            this.btnChiQuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChiQuy.Location = new System.Drawing.Point(1239, 300);
            this.btnChiQuy.Name = "btnChiQuy";
            this.btnChiQuy.ReadOnly = true;
            this.btnChiQuy.Size = new System.Drawing.Size(145, 30);
            this.btnChiQuy.TabIndex = 30;
            // 
            // btnLaiQuy
            // 
            this.btnLaiQuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLaiQuy.Location = new System.Drawing.Point(1242, 372);
            this.btnLaiQuy.Name = "btnLaiQuy";
            this.btnLaiQuy.ReadOnly = true;
            this.btnLaiQuy.Size = new System.Drawing.Size(145, 30);
            this.btnLaiQuy.TabIndex = 30;
            // 
            // btnLaiNam
            // 
            this.btnLaiNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLaiNam.Location = new System.Drawing.Point(1239, 520);
            this.btnLaiNam.Name = "btnLaiNam";
            this.btnLaiNam.ReadOnly = true;
            this.btnLaiNam.Size = new System.Drawing.Size(145, 30);
            this.btnLaiNam.TabIndex = 30;
            // 
            // btnChiNam
            // 
            this.btnChiNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnChiNam.Location = new System.Drawing.Point(1239, 450);
            this.btnChiNam.Name = "btnChiNam";
            this.btnChiNam.ReadOnly = true;
            this.btnChiNam.Size = new System.Drawing.Size(145, 30);
            this.btnChiNam.TabIndex = 30;
            // 
            // btnThuNam
            // 
            this.btnThuNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThuNam.Location = new System.Drawing.Point(1239, 486);
            this.btnThuNam.Name = "btnThuNam";
            this.btnThuNam.ReadOnly = true;
            this.btnThuNam.Size = new System.Drawing.Size(145, 30);
            this.btnThuNam.TabIndex = 30;
            // 
            // checkNhap
            // 
            this.checkNhap.AutoSize = true;
            this.checkNhap.Location = new System.Drawing.Point(266, 121);
            this.checkNhap.Name = "checkNhap";
            this.checkNhap.Size = new System.Drawing.Size(149, 27);
            this.checkNhap.TabIndex = 0;
            this.checkNhap.Text = "HD Nhập Kho";
            this.checkNhap.UseVisualStyleBackColor = true;
            this.checkNhap.Click += new System.EventHandler(this.checkNhap_Click);
            // 
            // checkXuat
            // 
            this.checkXuat.AutoSize = true;
            this.checkXuat.Location = new System.Drawing.Point(457, 120);
            this.checkXuat.Name = "checkXuat";
            this.checkXuat.Size = new System.Drawing.Size(145, 27);
            this.checkXuat.TabIndex = 1;
            this.checkXuat.Text = "HD Xuất Kho";
            this.checkXuat.UseVisualStyleBackColor = true;
            this.checkXuat.Click += new System.EventHandler(this.checkXuat_Click);
            // 
            // cmbThang
            // 
            this.cmbThang.BackColor = System.Drawing.Color.White;
            this.cmbThang.DisplayMember = "1";
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "",
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
            this.cmbThang.Location = new System.Drawing.Point(574, 156);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(42, 31);
            this.cmbThang.TabIndex = 2;
            this.cmbThang.Tag = "";
            this.cmbThang.SelectedIndexChanged += new System.EventHandler(this.cmbThang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tìm Kiếm";
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
            this.cmbNam.Location = new System.Drawing.Point(622, 156);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(74, 31);
            this.cmbNam.TabIndex = 3;
            this.cmbNam.Tag = "";
            this.cmbNam.SelectedIndexChanged += new System.EventHandler(this.cmbNam_SelectedIndexChanged);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.Red;
            this.btnXoaHD.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoaHD.Location = new System.Drawing.Point(1012, 552);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(161, 36);
            this.btnXoaHD.TabIndex = 56;
            this.btnXoaHD.Text = "Xóa Hóa Đơn";
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Visible = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BackColor = System.Drawing.Color.Red;
            this.btnSuaHD.ForeColor = System.Drawing.Color.Transparent;
            this.btnSuaHD.Location = new System.Drawing.Point(702, 552);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(161, 36);
            this.btnSuaHD.TabIndex = 57;
            this.btnSuaHD.Text = "Sửa Hóa Đơn";
            this.btnSuaHD.UseVisualStyleBackColor = false;
            this.btnSuaHD.Visible = false;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1413, 600);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.cmbNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.checkXuat);
            this.Controls.Add(this.checkNhap);
            this.Controls.Add(this.btnLaiNam);
            this.Controls.Add(this.btnChiNam);
            this.Controls.Add(this.btnThuNam);
            this.Controls.Add(this.btnLaiQuy);
            this.Controls.Add(this.btnChiQuy);
            this.Controls.Add(this.btnThuQuy);
            this.Controls.Add(this.btnLaiThang);
            this.Controls.Add(this.btnChiThang);
            this.Controls.Add(this.btnThuThang);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDoanhThuNam);
            this.Controls.Add(this.txtDoanhThuQuy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDoanhThuThang);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.rpvThongKeCTHD);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeDoanhThu";
            this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeCTHD;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMaHoaDon;
        private System.Windows.Forms.Label txtDoanhThuThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtDoanhThuQuy;
        private System.Windows.Forms.Label txtDoanhThuNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox btnThuThang;
        private System.Windows.Forms.TextBox btnChiThang;
        private System.Windows.Forms.TextBox btnLaiThang;
        private System.Windows.Forms.TextBox btnThuQuy;
        private System.Windows.Forms.TextBox btnChiQuy;
        private System.Windows.Forms.TextBox btnLaiQuy;
        private System.Windows.Forms.TextBox btnLaiNam;
        private System.Windows.Forms.TextBox btnChiNam;
        private System.Windows.Forms.TextBox btnThuNam;
        private System.Windows.Forms.CheckBox checkNhap;
        private System.Windows.Forms.CheckBox checkXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiMuaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSuaHD;
    }
}