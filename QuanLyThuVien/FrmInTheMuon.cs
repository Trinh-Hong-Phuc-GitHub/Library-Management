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
    public partial class FrmInTheMuon : Form
    {
        public FrmInTheMuon()
        {
            InitializeComponent();
        }

        private void FrmInTheMuon_Load(object sender, EventArgs e)
        {
            string str = "Data Source=DESKTOP-7NOLRS8;Initial Catalog=BTLQuanLyThuVien;Integrated Security=True";

            crpQuanLyTheMuon rpt = new crpQuanLyTheMuon();
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter dap = new SqlDataAdapter("Select TheMuon.MaTheMuon, TheMuon.TenTheMuon, TheMuon.MaThuThu, TheMuon.MaDocGia, TheMuon.TongTien, ChiTietTheMuon.MaSach, ChiTietTheMuon.DonGia, ChhiTietTheMuon.ThanhTien, ThuThu.TenThuThu, DocGia.TenDocGia, DocGia.DiaChi, DocGia.NgaySinh, DocGia.SoDienThoai, Sach.TenSach From TheMuon, ChiTietTheMuon, ThuThu, DocGia, Sach Where TheMuon.MaTheMuon = ChhiTietTheMuon.MaTheMuon, TheMuon.MaDocGia = DocGia.MaDocGia, TheMuon.MaThuThu = ThuThu.MaThuThu, ChiTietTheMuon.MaSach = Sach.MaSach, TheMuon.MaTheMuon = cboMaTheMuon", conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            rpt.SetDataSource(ds.Tables[0]);
            crvTheMuon.ReportSource = rpt;
        }
    }
}
