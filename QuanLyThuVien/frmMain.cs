using QuanLyThuVien.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuTacGia_Click(object sender, EventArgs e)
        {
            frmTacGia frm = new frmTacGia();
            frm.ShowDialog();
        }

        private void mnuTheLoai_Click(object sender, EventArgs e)
        {
            frmTheLoaiSach frm = new frmTheLoaiSach();
            frm.ShowDialog();
        }

        private void mnuNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan frm = new frmNhaXuatBan();
            frm.ShowDialog();
        }

        private void mnuThuThu_Click(object sender, EventArgs e)
        {
            frmThuThu frm = new frmThuThu();
            frm.ShowDialog();
        }

        private void mnuDocGia_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.ShowDialog();
        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.ShowDialog();
        }

        private void mnuTheMuon_Click(object sender, EventArgs e)
        {
            frmTheMuon frm = new frmTheMuon();
            frm.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.ShowDialog();
            }
        }

        private void mnuTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemTheMuon frm = new frmTimKiemTheMuon();
            frm.ShowDialog();
        }
    }
}
