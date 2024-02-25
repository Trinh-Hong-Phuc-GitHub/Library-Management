using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sử dụng thư viện để làm việc SQL server
using QuanLyThuVien.Class; //Sử dụng class Functions.cs

namespace QuanLyThuVien
{
    public partial class frmTheLoaiSach : Form
    {
        DataTable tblTL; //Chứa dữ liệu bảng thể loại
        public frmTheLoaiSach()
        {
            InitializeComponent();
        }

        private void frmTheLoaiSach_Load(object sender, EventArgs e)
        {
            txtMaTheLoai.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng 
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaTheLoai, TenTheLoai FROM TheLoai";
            tblTL = Class.Functions.GetDataToDataTable(sql); //Đọc dữ liệu từ bảng
            dgvTheLoai.DataSource = tblTL; //Nguồn dữ liệu            
            dgvTheLoai.Columns[0].HeaderText = "Mã thể loại";
            dgvTheLoai.Columns[1].HeaderText = "Tên thể loại";
            dgvTheLoai.Columns[0].Width = 100;
            dgvTheLoai.Columns[1].Width = 300;
            dgvTheLoai.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvTheLoai.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvTheLoai_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTheLoai.Focus();
                return;
            }
            if (tblTL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaTheLoai.Text = dgvTheLoai.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txtTenTheLoai.Text = dgvTheLoai.CurrentRow.Cells["TenTheLoai"].Value.ToString();
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
            ResetValue(); //Xoá trắng các textbox
            txtMaTheLoai.Enabled = true; //cho phép nhập mới
            txtMaTheLoai.Focus();
        }

        private void ResetValue()
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaTheLoai.Text.Trim().Length == 0) //Nếu chưa nhập mã 
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTheLoai.Focus();
                return;
            }
            if (txtTenTheLoai.Text.Trim().Length == 0) //Nếu chưa nhập tên 
            {
                MessageBox.Show("Bạn phải nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTheLoai.Focus();
                return;
            }
            sql = "Select MaTheLoai From TheLoai where MaTheLoai=N'" + txtMaTheLoai.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã thể loại này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTheLoai.Focus();
                return;
            }

            sql = "INSERT INTO TheLoai VALUES(N'" +
                txtMaTheLoai.Text + "',N'" + txtTenTheLoai.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaTheLoai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTheLoai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenTheLoai.Text.Trim().Length == 0) //nếu chưa nhập tên 
            {
                MessageBox.Show("Bạn chưa nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE TheLoai SET TenTheLoai=N'" +
                txtTenTheLoai.Text.ToString() +
                "' WHERE MaTheLoai=N'" + txtMaTheLoai.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTheLoai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TheLoai WHERE MaTheLoai=N'" + txtMaTheLoai.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaTheLoai.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
