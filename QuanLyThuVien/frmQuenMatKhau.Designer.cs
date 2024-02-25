namespace QuanLyThuVien
{
    partial class frmQuenMatKhau
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
            this.button_LayMatKhau = new System.Windows.Forms.Button();
            this.ketqua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_EmailDangKy = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LayMatKhau
            // 
            this.button_LayMatKhau.BackColor = System.Drawing.Color.SteelBlue;
            this.button_LayMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LayMatKhau.ForeColor = System.Drawing.Color.Snow;
            this.button_LayMatKhau.Location = new System.Drawing.Point(128, 316);
            this.button_LayMatKhau.Name = "button_LayMatKhau";
            this.button_LayMatKhau.Size = new System.Drawing.Size(143, 37);
            this.button_LayMatKhau.TabIndex = 32;
            this.button_LayMatKhau.Text = "Lấy lại mật khẩu";
            this.button_LayMatKhau.UseVisualStyleBackColor = false;
            this.button_LayMatKhau.Click += new System.EventHandler(this.button_LayMatKhau_Click);
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ketqua.Location = new System.Drawing.Point(26, 263);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(63, 16);
            this.ketqua.TabIndex = 31;
            this.ketqua.Text = "Kết quả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(26, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Email đăng ký:";
            // 
            // textBox_EmailDangKy
            // 
            this.textBox_EmailDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmailDangKy.Location = new System.Drawing.Point(179, 214);
            this.textBox_EmailDangKy.Name = "textBox_EmailDangKy";
            this.textBox_EmailDangKy.Size = new System.Drawing.Size(194, 22);
            this.textBox_EmailDangKy.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 384);
            this.Controls.Add(this.button_LayMatKhau);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_EmailDangKy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmQuenMatKhau";
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.frmQuenMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LayMatKhau;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EmailDangKy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}