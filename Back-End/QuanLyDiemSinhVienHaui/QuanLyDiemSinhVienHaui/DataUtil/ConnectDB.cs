using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class ConnectDB
    {
        public static SqlConnection getDBConnection()
        {
            String connString = @"Data Source=DESKTOP-8SGL0JG\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}