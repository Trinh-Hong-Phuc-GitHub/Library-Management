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
    public partial class frmTacGia : Form
    {
        SqlConnection connection;
        SqlCommand cmd;

        string str = @"Data Source=DESKTOP-7NOLRS8;Initial Catalog=BTLQuanLyThuVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable tblTG; //Chứa dữ liệu bảng Tác giả
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            txtMaTacGia.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng 
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaTacGia, TenTacGia FROM TacGia";
            tblTG = Class.Functions.GetDataToDataTable(sql); //Đọc dữ liệu từ bảng
            dgvTacGia.DataSource = tblTG; //Nguồn dữ liệu            
            dgvTacGia.Columns[0].HeaderText = "Mã tác giả";
            dgvTacGia.Columns[1].HeaderText = "Tên tác gỉa";
            dgvTacGia.Columns[0].Width = 100;
            dgvTacGia.Columns[1].Width = 300;
            dgvTacGia.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvTacGia.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }
        private void dgvTacGia_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTacGia.Focus();
                return;
            }
            if (tblTG.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaTacGia.Text = dgvTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString();
            txtTenTacGia.Text = dgvTacGia.CurrentRow.Cells["TenTacGia"].Value.ToString();
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
            txtMaTacGia.Enabled = true; //cho phép nhập mới
            txtMaTacGia.Focus();
        }

        private void ResetValue()
        {
            txtMaTacGia.Text = "";
            txtTenTacGia.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaTacGia.Text.Trim().Length == 0) //Nếu chưa nhập mã 
            {
                MessageBox.Show("Bạn phải nhập mã tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaTacGia.Focus();
                return;
            }
            if (txtTenTacGia.Text.Trim().Length == 0) //Nếu chưa nhập tên 
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTacGia.Focus();
                return;
            }
            sql = "Select MaTacGia From TacGia where MaTacGia=N'" + txtMaTacGia.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã tác giả này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTacGia.Focus();
                return;
            }

            sql = "INSERT INTO TacGia VALUES(N'" +
                txtMaTacGia.Text + "',N'" + txtTenTacGia.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaTacGia.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblTG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTacGia.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenTacGia.Text.Trim().Length == 0) //nếu chưa nhập tên 
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE TacGia SET TenTacGia=N'" +
                txtTenTacGia.Text.ToString() +
                "' WHERE MaTacGia=N'" + txtMaTacGia.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTG.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaTacGia.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TacGia WHERE MaTacGia=N'" + txtMaTacGia.Text + "'";
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
            txtMaTacGia.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInDSTG_Click(object sender, EventArgs e)
        {
            frmInDSTacGia frm = new frmInDSTacGia();
            frm.ShowDialog();
        }
    }
}
