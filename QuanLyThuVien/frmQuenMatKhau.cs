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

namespace QuanLyThuVien
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
            ketqua.Text = "";
        }

        Modify modify = new Modify();

        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button_LayMatKhau_Click(object sender, EventArgs e)
        {
            string email = textBox_EmailDangKy.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng ký!"); }
            else
            {
                string query = "Select * from TaiKhoan Where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    ketqua.ForeColor = Color.Blue;
                    ketqua.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    ketqua.ForeColor = Color.Red;
                    ketqua.Text = "Email này chưa được đăng ký!";
                }
            }
        }
    }
}
