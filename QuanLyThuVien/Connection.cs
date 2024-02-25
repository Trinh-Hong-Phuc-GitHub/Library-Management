using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-7NOLRS8;Initial Catalog=BTLQuanLyThuVien;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
