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
    public partial class frmNhaXuatBan : Form
    {
        DataTable tblNXB; //Chứa dữ liệu bảng
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
        {
            txtMaNhaXuatBan.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng 
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaNhaXuatBan, TenNhaXuatBan FROM NhaXuatBan";
            tblNXB = Class.Functions.GetDataToDataTable(sql); //Đọc dữ liệu từ bảng
            dgvNhaXuatBan.DataSource = tblNXB; //Nguồn dữ liệu            
            dgvNhaXuatBan.Columns[0].HeaderText = "Mã nhà xuất bản";
            dgvNhaXuatBan.Columns[1].HeaderText = "Tên nhà xuất bản";
            dgvNhaXuatBan.Columns[0].Width = 150;
            dgvNhaXuatBan.Columns[1].Width = 300;
            dgvNhaXuatBan.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvNhaXuatBan.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvNhaXuatBan_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaXuatBan.Focus();
                return;
            }
            if (tblNXB.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhaXuatBan.Text = dgvNhaXuatBan.CurrentRow.Cells["MaNhaXuatBan"].Value.ToString();
            txtTenNhaXuatBan.Text = dgvNhaXuatBan.CurrentRow.Cells["TenNhaXuatBan"].Value.ToString();
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
            txtMaNhaXuatBan.Enabled = true; //cho phép nhập mới
            txtMaNhaXuatBan.Focus();
        }

        private void ResetValue()
        {
            txtMaNhaXuatBan.Text = "";
            txtTenNhaXuatBan.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaNhaXuatBan.Text.Trim().Length == 0) //Nếu chưa nhập mã 
            {
                MessageBox.Show("Bạn phải nhập mã nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhaXuatBan.Focus();
                return;
            }
            if (txtTenNhaXuatBan.Text.Trim().Length == 0) //Nếu chưa nhập tên 
            {
                MessageBox.Show("Bạn phải nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhaXuatBan.Focus();
                return;
            }
            sql = "Select MaNhaXuatBan From NhaXuatBan where MaNhaXuatBan=N'" + txtMaNhaXuatBan.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà xuất bản này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhaXuatBan.Focus();
                return;
            }

            sql = "INSERT INTO NhaXuatBan VALUES(N'" +
                txtMaNhaXuatBan.Text + "',N'" + txtTenNhaXuatBan.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaNhaXuatBan.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblNXB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhaXuatBan.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenNhaXuatBan.Text.Trim().Length == 0) //nếu chưa nhập tên 
            {
                MessageBox.Show("Bạn chưa nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE NhaXuatBan SET TenNhaXuatBan=N'" +
                txtTenNhaXuatBan.Text.ToString() +
                "' WHERE MaNhaXuatBan=N'" + txtMaNhaXuatBan.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNXB.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhaXuatBan.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NhaXuatBan WHERE MaNhaXuatBan=N'" + txtMaNhaXuatBan.Text + "'";
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
            txtMaNhaXuatBan.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
