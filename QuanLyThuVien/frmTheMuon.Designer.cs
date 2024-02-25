namespace QuanLyThuVien
{
    partial class frmTheMuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaDocGia = new System.Windows.Forms.ComboBox();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtTenThuThu = new System.Windows.Forms.TextBox();
            this.cboMaThuThu = new System.Windows.Forms.ComboBox();
            this.txtMaTheMuon = new System.Windows.Forms.TextBox();
            this.txtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaTheMuon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTheMuon = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDonGiaMuon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheMuon)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaDocGia);
            this.groupBox1.Controls.Add(this.mtbDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenDocGia);
            this.groupBox1.Controls.Add(this.txtTenThuThu);
            this.groupBox1.Controls.Add(this.cboMaThuThu);
            this.groupBox1.Controls.Add(this.txtMaTheMuon);
            this.groupBox1.Controls.Add(this.txtNgayMuon);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 180);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cboMaDocGia
            // 
            this.cboMaDocGia.FormattingEnabled = true;
            this.cboMaDocGia.Location = new System.Drawing.Point(467, 28);
            this.cboMaDocGia.Name = "cboMaDocGia";
            this.cboMaDocGia.Size = new System.Drawing.Size(213, 24);
            this.cboMaDocGia.TabIndex = 24;
            this.cboMaDocGia.SelectedIndexChanged += new System.EventHandler(this.cboMaDocGia_SelectedIndexChanged_1);
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(467, 132);
            this.mtbDienThoai.Mask = "(999) 000-0000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.ReadOnly = true;
            this.mtbDienThoai.Size = new System.Drawing.Size(213, 22);
            this.mtbDienThoai.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(467, 95);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(213, 22);
            this.txtDiaChi.TabIndex = 22;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(467, 64);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(213, 22);
            this.txtTenDocGia.TabIndex = 21;
            // 
            // txtTenThuThu
            // 
            this.txtTenThuThu.Location = new System.Drawing.Point(105, 135);
            this.txtTenThuThu.Name = "txtTenThuThu";
            this.txtTenThuThu.ReadOnly = true;
            this.txtTenThuThu.Size = new System.Drawing.Size(200, 22);
            this.txtTenThuThu.TabIndex = 11;
            // 
            // cboMaThuThu
            // 
            this.cboMaThuThu.FormattingEnabled = true;
            this.cboMaThuThu.Location = new System.Drawing.Point(105, 98);
            this.cboMaThuThu.Name = "cboMaThuThu";
            this.cboMaThuThu.Size = new System.Drawing.Size(200, 24);
            this.cboMaThuThu.TabIndex = 10;
            this.cboMaThuThu.SelectedIndexChanged += new System.EventHandler(this.cboMaThuThu_SelectedIndexChanged);
            // 
            // txtMaTheMuon
            // 
            this.txtMaTheMuon.Location = new System.Drawing.Point(105, 28);
            this.txtMaTheMuon.Name = "txtMaTheMuon";
            this.txtMaTheMuon.ReadOnly = true;
            this.txtMaTheMuon.Size = new System.Drawing.Size(200, 22);
            this.txtMaTheMuon.TabIndex = 9;
            this.txtMaTheMuon.TextChanged += new System.EventHandler(this.txtMaTheMuon_TextChanged);
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayMuon.Location = new System.Drawing.Point(105, 59);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Size = new System.Drawing.Size(200, 22);
            this.txtNgayMuon.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Điện thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã đọc giả: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tên đọc giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã thủ thư:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên thủ thư: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã thẻ mượn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cboMaTheMuon);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 40);
            this.panel1.TabIndex = 32;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(277, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboMaTheMuon
            // 
            this.cboMaTheMuon.FormattingEnabled = true;
            this.cboMaTheMuon.Location = new System.Drawing.Point(125, 9);
            this.cboMaTheMuon.Name = "cboMaTheMuon";
            this.cboMaTheMuon.Size = new System.Drawing.Size(121, 24);
            this.cboMaTheMuon.TabIndex = 1;
            this.cboMaTheMuon.DropDown += new System.EventHandler(this.cboMaTheMuon_DropDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã thẻ mượn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTheMuon);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 381);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvTheMuon
            // 
            this.dgvTheMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheMuon.Location = new System.Drawing.Point(3, 118);
            this.dgvTheMuon.Name = "dgvTheMuon";
            this.dgvTheMuon.RowHeadersWidth = 51;
            this.dgvTheMuon.RowTemplate.Height = 24;
            this.dgvTheMuon.Size = new System.Drawing.Size(788, 160);
            this.dgvTheMuon.TabIndex = 3;
            this.dgvTheMuon.DoubleClick += new System.EventHandler(this.dgvTheMuon_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 40);
            this.panel4.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(536, 6);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(163, 22);
            this.txtTongTien.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(461, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "Tổng tiền: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(6, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nháy đúp 1 dòng để xóa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtThanhTien);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtDonGiaMuon);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtTenSach);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cboMaSach);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(788, 100);
            this.panel3.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(346, 53);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(134, 22);
            this.txtThanhTien.TabIndex = 11;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(102, 53);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 22);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(251, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Thành tiền:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Số lượng:";
            // 
            // txtDonGiaMuon
            // 
            this.txtDonGiaMuon.Location = new System.Drawing.Point(600, 13);
            this.txtDonGiaMuon.Name = "txtDonGiaMuon";
            this.txtDonGiaMuon.ReadOnly = true;
            this.txtDonGiaMuon.Size = new System.Drawing.Size(134, 22);
            this.txtDonGiaMuon.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(514, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Giá mượn:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(346, 13);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(121, 22);
            this.txtTenSach.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mã sách:";
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(102, 10);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(121, 24);
            this.cboMaSach.TabIndex = 1;
            this.cboMaSach.SelectedIndexChanged += new System.EventHandler(this.cboMaSach_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên sách: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.btnInHoaDon);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 60);
            this.panel2.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(590, 19);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 23);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(455, 19);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(110, 23);
            this.btnInHoaDon.TabIndex = 16;
            this.btnInHoaDon.Text = "&In thẻ mượn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(185, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 23);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "&Lưu thẻ mượn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(320, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "&Hủy thẻ mượn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "&Thêm thẻ mượn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "QUẢN LÝ THẺ MƯỢN";
            // 
            // frmTheMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 648);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTheMuon";
            this.Text = "Quản lý thẻ mượn";
            this.Load += new System.EventHandler(this.frmTheMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheMuon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaDocGia;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtTenThuThu;
        private System.Windows.Forms.ComboBox cboMaThuThu;
        private System.Windows.Forms.DateTimePicker txtNgayMuon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaTheMuon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTheMuon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDonGiaMuon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMaTheMuon;
    }
}