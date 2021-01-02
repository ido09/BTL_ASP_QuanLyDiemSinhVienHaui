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
            String connString = @"Data Source=DESKTOP-ENU0VNB\SQLEXPRESS;Initial Catalog=QLSV1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}