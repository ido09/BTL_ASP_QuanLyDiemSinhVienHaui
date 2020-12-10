using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class LoginDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();

        public GiangVien checkLoginGV(string username, string password)
        {
            conn.Open();
            GiangVien gv = null;
            string sql = "select * from GiangVien where email = @email and password = @password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                gv = new GiangVien();
                gv.id = (int)rd["id"];
                gv.name = (string)rd["name"];
                gv.gender = (string)rd["gender"];
                gv.birthday = (string)rd["birthday"];
                gv.email = (string)rd["email"];
                gv.phone = (string)rd["phone"];
                gv.address = (string)rd["address"];
                gv.avatar = (string)rd["avatar"];
                gv.id_khoa = (int)rd["id_khoa"];
                gv.role = (int)rd["role"];
            }
            conn.Close();
            return gv;
        }

        public SinhVien checkLoginSV(string username, string password)
        {
            conn.Open();
            SinhVien sv = null;
            string sql = "select * from SinhVien where email = @email and password = @password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                sv = new SinhVien();
                sv.id = (int)rd["id"];
                sv.name = (string)rd["name"];
                sv.gender = (string)rd["gender"];
                sv.birthday = (string)rd["birthday"];
                sv.email = (string)rd["email"];
                sv.phone = (string)rd["phone"];
                sv.address = (string)rd["address"];
                sv.avatar = (string)rd["avatar"];
                sv.id_lop = (int)rd["id_lop"];
                sv.role = (int)rd["role"];
            }
            conn.Close();
            return sv;
        }

        public Admin checkLoginAdmin(string username, string password)
        {
            conn.Open();
            Admin ad = null;
            string sql = "select * from Admin where username = @username and password = @password";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                ad = new Admin();
                ad.id = (int)rd["id"];
                ad.username = (string)rd["username"];
                ad.password = (string)rd["password"];
                ad.role = (int)rd["role"];
            }
            conn.Close();
            return ad;
        }
    }
}