using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyThuVien.Class;

namespace QuanLyThuVien
{
    public partial class frmTimKiemTheMuon : Form
    {
        DataTable tblTM;
        public frmTimKiemTheMuon()
        {
            InitializeComponent();
        }

        private void frmTimKiemTheMuon_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvTKTheMuon.DataSource = null;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaTheMuon.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaTheMuon.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtMaThuThu.Text == "") && (txtMaDocGia.Text == "") &&
               (txtTongTien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM TheMuon WHERE 1=1";
            if (txtMaTheMuon.Text != "")
                sql = sql + " AND MaTheMuon Like N'%" + txtMaTheMuon.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(NgayMuon) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(NgayMuon) =" + txtNam.Text;
            if (txtMaThuThu.Text != "")
                sql = sql + " AND MaThuThu Like N'%" + txtMaThuThu.Text + "%'";
            if (txtMaDocGia.Text != "")
                sql = sql + " AND MaDocGia Like N'%" + txtMaDocGia.Text + "%'";
            if (txtTongTien.Text != "")
                sql = sql + " AND TongTien <=" + txtTongTien.Text;
            tblTM = Functions.GetDataToDataTable(sql);
            if (tblTM.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblTM.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvTKTheMuon.DataSource = tblTM;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            dgvTKTheMuon.Columns[0].HeaderText = "Mã thẻ mượn";
            dgvTKTheMuon.Columns[1].HeaderText = "Mã thủ thư";
            dgvTKTheMuon.Columns[2].HeaderText = "Ngày mượn";
            dgvTKTheMuon.Columns[3].HeaderText = "Mã đọc giả";
            dgvTKTheMuon.Columns[4].HeaderText = "Tổng tiền";
            dgvTKTheMuon.Columns[0].Width = 150;
            dgvTKTheMuon.Columns[1].Width = 100;
            dgvTKTheMuon.Columns[2].Width = 80;
            dgvTKTheMuon.Columns[3].Width = 80;
            dgvTKTheMuon.Columns[4].Width = 80;
            dgvTKTheMuon.AllowUserToAddRows = false;
            dgvTKTheMuon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTKTheMuon.DataSource = null;
        }

        private void dgvTKTheMuon_DoubleClick(object sender, EventArgs e)
        {
            string matm;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                matm = dgvTKTheMuon.CurrentRow.Cells["MaTheMuon"].Value.ToString();
                frmTheMuon frm = new frmTheMuon();
                frm.txtMaTheMuon.Text = matm;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }
    }
}
