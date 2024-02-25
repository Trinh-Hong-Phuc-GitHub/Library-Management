namespace QuanLyThuVien
{
    partial class FrmInTheMuon
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
            this.crvTheMuon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTheMuon
            // 
            this.crvTheMuon.ActiveViewIndex = -1;
            this.crvTheMuon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTheMuon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTheMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTheMuon.Location = new System.Drawing.Point(0, 0);
            this.crvTheMuon.Name = "crvTheMuon";
            this.crvTheMuon.Size = new System.Drawing.Size(800, 450);
            this.crvTheMuon.TabIndex = 0;
            // 
            // FrmInTheMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvTheMuon);
            this.Name = "FrmInTheMuon";
            this.Text = "Thẻ mượn";
            this.Load += new System.EventHandler(this.FrmInTheMuon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvTheMuon;
    }
}