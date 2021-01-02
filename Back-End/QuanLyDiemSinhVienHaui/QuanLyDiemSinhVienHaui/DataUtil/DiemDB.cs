using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.Modal;
namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class DiemDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();
        public List<Diem> getDSDiem()
        {
            List<Diem> ds = new List<Diem>();
            conn.Open();
            String sql = "select * from Diem";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Diem d = new Diem();
                d.id_mon = (int)rd["id_mon"];
                d.diemThi1 = (double)rd["diemThi1"];
                d.diemThi2 = (double)rd["diemThi2"];
                d.diemChu = (string)rd["diemChu"];
                d.ghiChu = (string)rd["ghiChu"];
                ds.Add(d);
            }
            conn.Close();
            return ds;
        }
    }
}