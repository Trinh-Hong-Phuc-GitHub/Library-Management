using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmInDSTacGia : Form
    {
        public frmInDSTacGia()
        {
            InitializeComponent();
        }

        private void frmInDSTacGia_Load(object sender, EventArgs e)
        {
            string str = "Data Source=DESKTOP-7NOLRS8;Initial Catalog=BTLQuanLyThuVien;Integrated Security=True";

            crpDSTacGia rpt = new crpDSTacGia();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("select * from TacGia", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crvDSTacGia.ReportSource = rpt;
        }
    }
}
