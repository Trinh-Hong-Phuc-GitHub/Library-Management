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
    public partial class frmDocGia : Form
    {
        DataTable tblDG; //Bảng đọc giả
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            txtMaDocGia.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from DocGia";
            tblDG = Functions.GetDataToDataTable(sql); //Lấy dữ liệu từ bảng
            dgvDocGia.DataSource = tblDG; //Hiển thị vào dataGridView
            dgvDocGia.Columns[0].HeaderText = "Mã đọc giả";
            dgvDocGia.Columns[1].HeaderText = "Tên đọc giả";
            dgvDocGia.Columns[2].HeaderText = "Địa chỉ";
            dgvDocGia.Columns[3].HeaderText = "Điện thoại";
            dgvDocGia.Columns[0].Width = 100;
            dgvDocGia.Columns[1].Width = 150;
            dgvDocGia.Columns[2].Width = 150;
            dgvDocGia.Columns[3].Width = 150;
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvDocGia_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDocGia.Focus();
                return;
            }
            if (tblDG.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaDocGia.Text = dgvDocGia.CurrentRow.Cells["MaDocGia"].Value.ToString();
            txtTenDocGia.Text = dgvDocGia.CurrentRow.Cells["TenDocGia"].Value.ToString();
            txtDiaChi.Text = dgvDocGia.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbDienThoai.Text = dgvDocGia.CurrentRow.Cells["DienThoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaDocGia.Enabled = true;
            txtMaDocGia.Focus();
        }

        private void ResetValues()
        {
            txtMaDocGia.Text = "";
            txtTenDocGia.Text = "";
            txtDiaChi.Text = "";
            mtbDienThoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaDocGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đọc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDocGia.Focus();
                return;
            }
            if (txtTenDocGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đọc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDocGia.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã đọc giả chưa
            sql = "SELECT MaDocGia FROM DocGia WHERE MaDocGia=N'" + txtMaDocGia.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã đọc giả này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaDocGia.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO DocGia VALUES (N'" + txtMaDocGia.Text.Trim() +
                "',N'" + txtTenDocGia.Text.Trim() + "',N'" + txtDiaChi.Text.Trim() + "','" + mtbDienThoai.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaDocGia.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDG.Rows.Count == 0)
            {
                MessageBox.Show("DGông còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaDocGia.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenDocGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên đọc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDocGia.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbDienThoai.Focus();
                return;
            }
            sql = "UPDATE DocGia SET TenDocGia=N'" + txtTenDocGia.Text.Trim().ToString() + "',DiaChi=N'" +
                txtDiaChi.Text.Trim().ToString() + "',DienThoai='" + mtbDienThoai.Text.ToString() +
                "' WHERE MaDocGia=N'" + txtMaDocGia.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaDocGia.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE DocGia WHERE MaDocGia=N'" + txtMaDocGia.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaDocGia.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
