namespace QuanLyThuVien
{
    partial class frmInDSTacGia
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
            this.crvDSTacGia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDSTacGia
            // 
            this.crvDSTacGia.ActiveViewIndex = -1;
            this.crvDSTacGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDSTacGia.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDSTacGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDSTacGia.Location = new System.Drawing.Point(0, 0);
            this.crvDSTacGia.Name = "crvDSTacGia";
            this.crvDSTacGia.Size = new System.Drawing.Size(800, 450);
            this.crvDSTacGia.TabIndex = 0;
            // 
            // frmInDSTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvDSTacGia);
            this.Name = "frmInDSTacGia";
            this.Text = "frmInDSTacGia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInDSTacGia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvDSTacGia;
    }
}