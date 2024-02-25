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
    public partial class frmSach : Form
    {
        DataTable tblS; //Bảng 
        public frmSach()
        {
            InitializeComponent();
        }

        private void FrmSach_Load(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo("SELECT MaTheLoai, TenTheLoai from TheLoai", cboMaTheLoai, "MaTheLoai", "TenTheLoai");
            cboMaTheLoai.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaTacGia, TenTacGia from TacGia", cboMaTacGia, "MaTacGia", "TenTacGia");
            cboMaTacGia.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNhaXuatBan, TenNhaXuatBan from NhaXuatBan", cboMaNhaXuatBan, "MaNhaXuatBan", "TenNhaXuatBan");
            cboMaNhaXuatBan.SelectedIndex = -1;
            ResetValues();
        }

        private void ResetValues()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboMaTheLoai.Text = "";
            cboMaTacGia.Text = "";
            cboMaNhaXuatBan.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaSach.Text = "0";
            txtDonGiaMuon.Text = "0";
            txtSoLuong.Enabled = true;
            txtDonGiaSach.Enabled = false;
            txtDonGiaMuon.Enabled = false;
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhiChu.Text = "";
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from Sach";
            tblS = Functions.GetDataToDataTable(sql);
            dgvSach.DataSource = tblS;
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Mã nhà xuất bản";
            dgvSach.Columns[3].HeaderText = "Mã tác giả";
            dgvSach.Columns[4].HeaderText = "Mã thể loại";
            dgvSach.Columns[5].HeaderText = "Số lượng";
            dgvSach.Columns[6].HeaderText = "Đơn giá sách";
            dgvSach.Columns[7].HeaderText = "Đơn giá mượn";
            dgvSach.Columns[8].HeaderText = "Ảnh";
            dgvSach.Columns[9].HeaderText = "Ghi chú";
            dgvSach.Columns[0].Width = 80;
            dgvSach.Columns[1].Width = 180;
            dgvSach.Columns[2].Width = 120;
            dgvSach.Columns[3].Width = 100;
            dgvSach.Columns[4].Width = 100;
            dgvSach.Columns[5].Width = 80;
            dgvSach.Columns[6].Width = 100;
            dgvSach.Columns[7].Width = 100;
            dgvSach.Columns[8].Width = 200;
            dgvSach.Columns[9].Width = 300;
            dgvSach.AllowUserToAddRows = false;
            dgvSach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaSach.Enabled = true;
            txtMaSach.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaSach.Enabled = true;
            txtDonGiaMuon.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return;
            }
            if (txtTenSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
                return;
            }
            if (cboMaTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaTheLoai.Focus();
                return;
            }
            if (cboMaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaTacGia.Focus();
                return;
            }
            if (cboMaNhaXuatBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNhaXuatBan.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            sql = "SELECT MaSach FROM Sach WHERE MaSach=N'" + txtMaSach.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sách này đã tồn tại, bạn phải chọn mã sách khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return;
            }
            sql = "INSERT INTO Sach(MaSach,TenSach,MaTheLoai,MaTacGia,MaNhaXuatBan,SoLuong,DonGiaSach, DonGiaMuon,Anh,GhiChu) VALUES(N'"
                + txtMaSach.Text.Trim() + "',N'" + txtTenSach.Text.Trim() +
                "',N'" + cboMaTheLoai.SelectedValue.ToString() +
                "',N'" + cboMaTacGia.SelectedValue.ToString() +
                "',N'" + cboMaNhaXuatBan.SelectedValue.ToString() +
                "'," + txtSoLuong.Text.Trim() + "," + txtDonGiaSach.Text +
                "," + txtDonGiaMuon.Text + ",'" + txtAnh.Text + "',N'" + txtGhiChu.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaSach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblS.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return;
            }
            if (txtTenSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
                return;
            }
            if (cboMaTheLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaTheLoai.Focus();
                return;
            }
            if (cboMaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaTacGia.Focus();
                return;
            }
            if (cboMaNhaXuatBan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNhaXuatBan.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE Sach SET TenSach=N'" + txtTenSach.Text.Trim().ToString() +
                "',MaTheLoai=N'" + cboMaTheLoai.SelectedValue.ToString() +
                "',MaTacGia=N'" + cboMaTacGia.SelectedValue.ToString() +
                "',MaNhaXuatBan=N'" + cboMaNhaXuatBan.SelectedValue.ToString() +
                "',SoLuong=" + txtSoLuong.Text +
                ",Anh='" + txtAnh.Text + "',GhiChu=N'" + txtGhiChu.Text + "' WHERE MaSach=N'" + txtMaSach.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblS.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Sach WHERE MaSach=N'" + txtMaSach.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaSach.Text == "") && (txtTenSach.Text == "") && (cboMaTheLoai.Text == "") && (cboMaTacGia.Text == "") && (cboMaNhaXuatBan.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from Sach WHERE 1=1";
            if (txtMaSach.Text != "")
                sql += " AND MaHang LIKE N'%" + txtMaSach.Text + "%'";
            if (txtTenSach.Text != "")
                sql += " AND TenHang LIKE N'%" + txtTenSach.Text + "%'";
            if (cboMaTheLoai.Text != "")
                sql += " AND MaTheLoai LIKE N'%" + cboMaTheLoai.SelectedValue + "%'";
            if (cboMaTacGia.Text != "")
                sql += " AND MaTacGia LIKE N'%" + cboMaTacGia.SelectedValue + "%'";
            if (cboMaNhaXuatBan.Text != "")
                sql += " AND MaNhaXuatBan LIKE N'%" + cboMaNhaXuatBan.SelectedValue + "%'";
            tblS = Functions.GetDataToDataTable(sql);
            if (tblS.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblS.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSach.DataSource = tblS;
            ResetValues();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT Masach,TenSach,MaTheLoai,MaTacGia,MaNhaXuatBan,SoLuong,DonGiaSach,DonGiaMuon,Anh,GhiChu FROM Sach";
            tblS = Functions.GetDataToDataTable(sql);
            dgvSach.DataSource = tblS;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSach_Click(object sender, EventArgs e)
        {
            string MaTacGia;
            string MaTheLoai;
            string MaNhaXuatBan;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return;
            }
            if (tblS.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaSach.Text = dgvSach.CurrentRow.Cells["MaSach"].Value.ToString();
            txtTenSach.Text = dgvSach.CurrentRow.Cells["TenSach"].Value.ToString();
            MaTheLoai = dgvSach.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            sql = "SELECT TenTheLoai FROM TheLoai WHERE MaTheLoai=N'" + MaTheLoai + "'";
            cboMaTheLoai.Text = Functions.GetFieldValues(sql);
            MaTacGia = dgvSach.CurrentRow.Cells["MaTacGia"].Value.ToString();
            sql = "SELECT TenTacGia FROM TacGia WHERE MaTacGia=N'" + MaTacGia + "'";
            cboMaTacGia.Text = Functions.GetFieldValues(sql);
            MaNhaXuatBan = dgvSach.CurrentRow.Cells["MaNhaXuatBan"].Value.ToString();
            sql = "SELECT TenNhaXuatBan FROM NhaXuatBan WHERE MaNhaXuatBan=N'" + MaNhaXuatBan + "'";
            cboMaNhaXuatBan.Text = Functions.GetFieldValues(sql);
            txtSoLuong.Text = dgvSach.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGiaSach.Text = dgvSach.CurrentRow.Cells["DonGiaSach"].Value.ToString();
            txtDonGiaMuon.Text = dgvSach.CurrentRow.Cells["DonGiaMuon"].Value.ToString();
            sql = "SELECT Anh FROM Sach WHERE MaSach=N'" + txtMaSach.Text + "'";
            txtAnh.Text = Functions.GetFieldValues(sql);
            picAnh.Image = Image.FromFile(txtAnh.Text);
            sql = "SELECT GhiChu FROM Sach WHERE MaSach = N'" + txtMaSach.Text + "'";
            txtGhiChu.Text = Functions.GetFieldValues(sql);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
    }
}
