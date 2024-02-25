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
    public partial class frmThuThu : Form
    {
        DataTable tblTT; //Lưu dữ liệu bảng
        public frmThuThu()
        {
            InitializeComponent();
        }

        private void FrmThuThu_Load(object sender, EventArgs e)
        {
            txtMaThuThu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaThuThu,TenThuThu,GioiTinh,DiaChi,DienThoai,NgaySinh FROM ThuThu";
            tblTT = Functions.GetDataToDataTable(sql); //lấy dữ liệu
            dgvThuThu.DataSource = tblTT;
            dgvThuThu.Columns[0].HeaderText = "Mã thủ thư";
            dgvThuThu.Columns[1].HeaderText = "Tên thủ thư";
            dgvThuThu.Columns[2].HeaderText = "Giới tính";
            dgvThuThu.Columns[3].HeaderText = "Địa chỉ";
            dgvThuThu.Columns[4].HeaderText = "Điện thoại";
            dgvThuThu.Columns[5].HeaderText = "Ngày sinh";
            dgvThuThu.Columns[0].Width = 100;
            dgvThuThu.Columns[1].Width = 150;
            dgvThuThu.Columns[2].Width = 100;
            dgvThuThu.Columns[3].Width = 150;
            dgvThuThu.Columns[4].Width = 100;
            dgvThuThu.Columns[5].Width = 100;
            dgvThuThu.AllowUserToAddRows = false;
            dgvThuThu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvThuThu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaThuThu.Focus();
                return;
            }
            if (tblTT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaThuThu.Text = dgvThuThu.CurrentRow.Cells["MaThuThu"].Value.ToString();
            txtTenThuThu.Text = dgvThuThu.CurrentRow.Cells["TenThuThu"].Value.ToString();
            if (dgvThuThu.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam") chkGioiTinh.Checked = true;
            else chkGioiTinh.Checked = false;
            txtDiaChi.Text = dgvThuThu.CurrentRow.Cells["DiaChi"].Value.ToString();
            mtbDienThoai.Text = dgvThuThu.CurrentRow.Cells["DienThoai"].Value.ToString();
            mskNgaySinh.Value = (DateTime)dgvThuThu.CurrentRow.Cells["NgaySinh"].Value;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaThuThu.Enabled = true;
            txtMaThuThu.Focus();
        }

        private void ResetValues()
        {
            txtMaThuThu.Text = "";
            txtTenThuThu.Text = "";
            chkGioiTinh.Checked = false;
            txtDiaChi.Text = "";
            mskNgaySinh.Value = DateTime.Now;
            mtbDienThoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaThuThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thủ thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThuThu.Focus();
                return;
            }
            if (txtTenThuThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thủ thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuThu.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return;
            }
            if (mskNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaySinh.Focus();
                return;
            }
            //if (!Functions.IsDate(mskNgaySinh.Text))
            //{
            //    MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    // mskNgaySinh.Text = "";
            //    mskNgaySinh.Focus();
            //    return;
            //}
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT MaThuThu FROM ThuThu WHERE MaThuThu=N'" + txtMaThuThu.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã thủ thư này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThuThu.Focus();
                txtMaThuThu.Text = "";
                return;
            }
            sql = "INSERT INTO ThuThu(MaThuThu,TenThuThu,GioiTinh, DiaChi,DienThoai, NgaySinh) VALUES (N'" + txtMaThuThu.Text.Trim() + "',N'" + txtTenThuThu.Text.Trim() + "',N'" + gt + "',N'" + txtDiaChi.Text.Trim() + "','" + mtbDienThoai.Text + "','" + mskNgaySinh.Value + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaThuThu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblTT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaThuThu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenThuThu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên thủ thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenThuThu.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }
            if (mtbDienThoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbDienThoai.Focus();
                return;
            }
            //if (mskNgaySinh.Text == "  /  /")
            //{
            //    MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskNgaySinh.Focus();
            //    return;
            //}
            //if (!Functions.IsDate(mskNgaySinh.Text))
            //{
            //    MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mskNgaySinh.Text = "";
            //    mskNgaySinh.Focus();
            //    return;
            //}
            if (chkGioiTinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE ThuThu SET  TenThuThu=N'" + txtTenThuThu.Text.Trim().ToString() +
                    "',DiaChi=N'" + txtDiaChi.Text.Trim().ToString() +
                    "',DienThoai='" + mtbDienThoai.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',NgaySinh='" + mskNgaySinh.Value +
                    "' WHERE MaThuThu=N'" + txtMaThuThu.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaThuThu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE ThuThu WHERE MaThuThu=N'" + txtMaThuThu.Text + "'";
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
            txtMaThuThu.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
