using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QuanLyThuVien
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac) // check mật khẩu và tài khoản
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em) // check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBoxMatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text;
            string email = textBox_Email.Text;
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường"); return; };
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường"); return; };
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; };
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; };
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác!"); return; };
            try
            {
                string query = "Insert into TaiKhoan values('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký! Vui lòng đăng ký tên tài khoản khác!");
            }
        }
    }
}
