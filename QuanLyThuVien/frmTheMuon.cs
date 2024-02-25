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
    public partial class frmTheMuon : Form
    {
        DataTable tblCTTM; //Bảng chi tiết hoá đơn bán
        public frmTheMuon()
        {
            InitializeComponent();
        }

        private void frmTheMuon_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtMaTheMuon.ReadOnly = true;
            txtTenThuThu.ReadOnly = true;
            txtTenDocGia.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            mtbDienThoai.ReadOnly = true;
            txtTenSach.ReadOnly = true;
            txtDonGiaMuon.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtTongTien.Text = "0";
            Functions.FillCombo("SELECT MaDocGia, TenDocGia FROM DocGia", cboMaDocGia, "MaDocGia", "TenDocGia");
            cboMaDocGia.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaThuThu, TenThuThu FROM ThuThu", cboMaThuThu, "MaThuThu", "TenThuThu");
            cboMaThuThu.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaSach, TenSach FROM Sach", cboMaSach, "MaSach", "TenSach");
            cboMaSach.SelectedIndex = -1;
            //Hiển thị thông tin của một thẻ mượn được gọi từ form tìm kiếm
            if (txtMaTheMuon.Text != "")
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaSach, b.TenSach, a.SoLuong, b.DonGiaMuon ,a.ThanhTien FROM ChiTietTheMuon AS a, Sach AS b  WHERE a.MaTheMuon = N'" + txtMaTheMuon.Text + "' AND a.MaSach=b.MaSach";
            tblCTTM = Functions.GetDataToDataTable(sql);
            dgvTheMuon.DataSource = tblCTTM;
            dgvTheMuon.Columns[0].HeaderText = "Mã sách";
            dgvTheMuon.Columns[1].HeaderText = "Tên sách";
            dgvTheMuon.Columns[2].HeaderText = "Số lượng";
            dgvTheMuon.Columns[3].HeaderText = "Đơn giá";
            dgvTheMuon.Columns[4].HeaderText = "Thành tiền";
            dgvTheMuon.Columns[0].Width = 80;
            dgvTheMuon.Columns[1].Width = 130;
            dgvTheMuon.Columns[2].Width = 80;
            dgvTheMuon.Columns[3].Width = 90;
            dgvTheMuon.Columns[4].Width = 90;
            dgvTheMuon.AllowUserToAddRows = false;
            dgvTheMuon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        // Nạp chi tiết thẻ mượn
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayMuon FROM TheMuon WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'";
            txtNgayMuon.Value = DateTime.Parse(Functions.GetFieldValues(str));
            str = "SELECT MaThuThu FROM TheMuon WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'";
            cboMaThuThu.SelectedValue = Functions.GetFieldValues(str);
            str = "SELECT MaDocGia FROM TheMuon WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'";
            cboMaDocGia.SelectedValue = Functions.GetFieldValues(str);
            str = "SELECT TongTien FROM TheMuon WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaTheMuon.Text = Functions.CreateKey("TM");
            LoadDataGridView();
        }

        private void ResetValues()
        {
            txtMaTheMuon.Text = "";
            txtNgayMuon.Value = DateTime.Now;
            cboMaThuThu.Text = "";
            cboMaDocGia.Text = "";
            txtTongTien.Text = "0";
            cboMaSach.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaTheMuon FROM TheMuon WHERE MaTheMuon=N'" + txtMaTheMuon.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã thẻ mượn chưa có, tiến hành lưu các thông tin chung
                // Mã TheMuon được sinh tự động do đó không có trường hợp trùng khóa
                if (cboMaThuThu.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập thủ thư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaThuThu.Focus();
                    return;
                }
                if (cboMaDocGia.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập đọc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaDocGia.Focus();
                    return;
                }
                sql = "INSERT INTO TheMuon(MaTheMuon, NgayMuon, MaThuThu, MaDocGia, TongTien) VALUES (N'" + txtMaTheMuon.Text.Trim() + "','" +
                        txtNgayMuon.Value + "',N'" + cboMaThuThu.SelectedValue + "',N'" +
                        cboMaDocGia.SelectedValue + "'," + txtTongTien.Text + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các sách
            if (cboMaSach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaSach.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "SELECT MaSach FROM ChiTietTheMuon WHERE MaSach=N'" + cboMaSach.SelectedValue + "' AND MaTheMuon = N'" + txtMaTheMuon.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaSach.Focus();
                return;
            }
            // Kiểm tra xem số lượng sách trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM Sach WHERE MaSach = N'" + cboMaSach.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng sách này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "INSERT INTO ChiTietTheMuon(MaTheMuon,MaSach,SoLuong,DonGia,ThanhTien) VALUES(N'" + txtMaTheMuon.Text.Trim() + "',N'" + cboMaSach.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGiaMuon.Text + "," + txtThanhTien.Text + ")";
            Functions.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của sách vào bảng Sach
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE Sach SET SoLuong =" + SLcon + " WHERE MaSach= N'" + cboMaSach.SelectedValue + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho thẻ mượn
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM TheMuon WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE TheMuon SET TongTien =" + Tongmoi + " WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'";
            Functions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            ResetValuesHang();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;
        }

        //  Bổ sung reset hàng
        private void ResetValuesHang()
        {
            cboMaSach.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
        }

        private void dgvTheMuon_DoubleClick(object sender, EventArgs e)
        {
            string MaSachxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTTM.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa sách và cập nhật lại số lượng sách 
                MaSachxoa = dgvTheMuon.CurrentRow.Cells["MaSach"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvTheMuon.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvTheMuon.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE ChiTietTheMuon WHERE MaTheMuon=N'" + txtMaTheMuon.Text + "' AND MaSach = N'" + MaSachxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại số lượng cho các sách
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM Sach WHERE MaSach = N'" + MaSachxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE Sach SET SoLuong =" + slcon + " WHERE MaSach= N'" + MaSachxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho thẻ mượn
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM TheMuon WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE TheMuon SET TongTien =" + tongmoi + " WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'";
                Functions.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                LoadDataGridView();
            }
        }

        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaSach.Text == "")
            {
                txtTenSach.Text = "";
                txtDonGiaMuon.Text = "";
            }
            // Khi chọn mã sách thì các thông tin về sách hiện ra
            str = "SELECT MaSach FROM Sach WHERE MaSach =N'" + cboMaSach.SelectedValue + "'";
            txtTenSach.Text = Functions.GetFieldValues(str);
            str = "SELECT DonGiaMuon FROM Sach WHERE MaSach =N'" + cboMaSach.SelectedValue + "'";
            txtDonGiaMuon.Text = Functions.GetFieldValues(str);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtDonGiaMuon.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGiaMuon.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaSach,SoLuong FROM ChiTietTheMuon WHERE MaTheMuon = N'" + txtMaTheMuon.Text + "'";
                DataTable tblSach = Functions.GetDataToDataTable(sql);
                for (int sach = 0; sach <= tblSach.Rows.Count - 1; sach++)
                {
                    // Cập nhật lại số lượng cho các sách
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM Sach WHERE MaSach = N'" + tblSach.Rows[sach][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblSach.Rows[sach][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE Sach SET SoLuong =" + slcon + " WHERE MaSach= N'" + tblSach.Rows[sach][0].ToString() + "'";
                    Functions.RunSQL(sql);
                }

                //Xóa chi tiết thẻ mượn
                sql = "DELETE ChiTietTheMuon WHERE MaTheMuon=N'" + txtMaTheMuon.Text + "'";
                Functions.RunSqlDel(sql);

                //Xóa thẻ mượn
                sql = "DELETE TheMuon WHERE MaTheMuon=N'" + txtMaTheMuon.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                btnXoa.Enabled = false;
                btnInHoaDon.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaTheMuon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã thẻ mượn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaTheMuon.Focus();
                return;
            }
            txtMaTheMuon.Text = cboMaTheMuon.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = true;
            cboMaTheMuon.SelectedIndex = -1;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaDocGia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string str;
            if (cboMaDocGia.Text == "")
            {
                txtTenDocGia.Text = "";
                txtDiaChi.Text = "";
                mtbDienThoai.Text = "";
            }
            //Khi chọn Mã đọc giả thì các thông tin của đọc giả sẽ hiện ra
            str = "Select MaDocGia from DocGia where MaDocGia = N'" + cboMaDocGia.SelectedValue + "'";
            txtTenDocGia.Text = Functions.GetFieldValues(str);
            str = "Select DiaChi from DocGia where MaDocGia = N'" + cboMaDocGia.SelectedValue + "'";
            txtDiaChi.Text = Functions.GetFieldValues(str);
            str = "Select DienThoai from DocGia where MaDocGia= N'" + cboMaDocGia.SelectedValue + "'";
            mtbDienThoai.Text = Functions.GetFieldValues(str);
        }

        private void cboMaThuThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaThuThu.Text == "")
                txtTenThuThu.Text = "";
            // Khi chọn mã thủ thư thì tên thủ thư tự động hiện ra
            str = "Select MaThuThu from ThuThu where MaThuThu =N'" + cboMaThuThu.SelectedValue + "'";
            txtTenThuThu.Text = Functions.GetFieldValues(str);
        }

        private void cboMaTheMuon_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaTheMuon FROM TheMuon", cboMaTheMuon, "MaTheMuon", "MaTheMuon");
            cboMaTheMuon.SelectedIndex = -1;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            FrmInTheMuon frm = new FrmInTheMuon();
            frm.ShowDialog();
        }

        private void txtMaTheMuon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
