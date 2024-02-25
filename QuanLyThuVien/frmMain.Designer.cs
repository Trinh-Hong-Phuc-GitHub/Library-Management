namespace QuanLyThuVien
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaXuatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTheMuon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuTheMuon,
            this.mnuTimKiem,
            this.mnuGioiThieu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat,
            this.mnuDangXuat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(69, 24);
            this.mnuFile.Text = "&Tệp tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(183, 26);
            this.mnuThoat.Text = "&Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(183, 26);
            this.mnuDangXuat.Text = "&Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTacGia,
            this.mnuTheLoai,
            this.mnuNhaXuatBan,
            this.mnuSach,
            this.mnuDocGia,
            this.mnuThuThu});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "&Danh mục";
            // 
            // mnuTacGia
            // 
            this.mnuTacGia.Name = "mnuTacGia";
            this.mnuTacGia.Size = new System.Drawing.Size(180, 26);
            this.mnuTacGia.Text = "&Tác giả";
            this.mnuTacGia.Click += new System.EventHandler(this.mnuTacGia_Click);
            // 
            // mnuTheLoai
            // 
            this.mnuTheLoai.Name = "mnuTheLoai";
            this.mnuTheLoai.Size = new System.Drawing.Size(180, 26);
            this.mnuTheLoai.Text = "&Thể loại sách";
            this.mnuTheLoai.Click += new System.EventHandler(this.mnuTheLoai_Click);
            // 
            // mnuNhaXuatBan
            // 
            this.mnuNhaXuatBan.Name = "mnuNhaXuatBan";
            this.mnuNhaXuatBan.Size = new System.Drawing.Size(180, 26);
            this.mnuNhaXuatBan.Text = "&Nhà xuất bản";
            this.mnuNhaXuatBan.Click += new System.EventHandler(this.mnuNhaXuatBan_Click);
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(180, 26);
            this.mnuSach.Text = "&Sách";
            this.mnuSach.Click += new System.EventHandler(this.mnuSach_Click);
            // 
            // mnuDocGia
            // 
            this.mnuDocGia.Name = "mnuDocGia";
            this.mnuDocGia.Size = new System.Drawing.Size(180, 26);
            this.mnuDocGia.Text = "&Đọc giả";
            this.mnuDocGia.Click += new System.EventHandler(this.mnuDocGia_Click);
            // 
            // mnuThuThu
            // 
            this.mnuThuThu.Name = "mnuThuThu";
            this.mnuThuThu.Size = new System.Drawing.Size(180, 26);
            this.mnuThuThu.Text = "&Thủ thư";
            this.mnuThuThu.Click += new System.EventHandler(this.mnuThuThu_Click);
            // 
            // mnuTheMuon
            // 
            this.mnuTheMuon.Name = "mnuTheMuon";
            this.mnuTheMuon.Size = new System.Drawing.Size(90, 24);
            this.mnuTheMuon.Text = "&Thẻ mượn";
            this.mnuTheMuon.Click += new System.EventHandler(this.mnuTheMuon_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(84, 24);
            this.mnuTimKiem.Text = "&Tìm kiếm";
            this.mnuTimKiem.Click += new System.EventHandler(this.mnuTimKiem_Click);
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(87, 24);
            this.mnuGioiThieu.Text = "&Giới thiệu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources.Quản_LÝ_Thư_Viện__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý thư viện";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuTacGia;
        private System.Windows.Forms.ToolStripMenuItem mnuTheLoai;
        private System.Windows.Forms.ToolStripMenuItem mnuTheMuon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaXuatBan;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mnuDocGia;
        private System.Windows.Forms.ToolStripMenuItem mnuThuThu;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
    }
}

