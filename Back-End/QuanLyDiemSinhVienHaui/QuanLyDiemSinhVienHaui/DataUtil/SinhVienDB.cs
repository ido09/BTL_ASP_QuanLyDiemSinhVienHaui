using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class SinhVienDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();

        public List<SinhVien> getDSSinhVien()
        {
            List<SinhVien> ds = new List<SinhVien>();
            conn.Open();
            String sql = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                SinhVien sv = new SinhVien();
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
                ds.Add(sv);
            }
            conn.Close();
            return ds;
        }

        public void xoaSV(int id)
        {
            conn.Open();
            string sql = "delete from SinhVien where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void suaSV(SinhVien sv)
        {
            conn.Open();
            string sql = "update SinhVien set name=@name, gender = @gender," +
                "birthday = @birthday, email = @email, phone = @phone," +
                "address = @address, avatar = @avatar, " +
                "id_lop = @id_lop, role = 3 where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", sv.name);
            cmd.Parameters.AddWithValue("@gender", sv.gender);
            cmd.Parameters.AddWithValue("@birthday", sv.birthday);
            cmd.Parameters.AddWithValue("@email", sv.email);
            cmd.Parameters.AddWithValue("@phone", sv.phone);
            cmd.Parameters.AddWithValue("@address", sv.address);
            cmd.Parameters.AddWithValue("@avatar", sv.avatar);
            cmd.Parameters.AddWithValue("@id_lop", sv.id_lop);
            cmd.Parameters.AddWithValue("@id", sv.id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<SinhVien> timkiemSV(string keyword)
        {
            conn.Open();
            List<SinhVien> ds = new List<SinhVien>();
            string sql = "select * from SinhVien where name LIKE '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                SinhVien sv = new SinhVien();
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
                ds.Add(sv);
            }
            conn.Close();
            return ds;
        }

        public void themSV(SinhVien sv)
        {
            conn.Open();
            string sql = "insert into SinhVien values(@name, @gender,@birthday, @email," +
                "@phone, @address, @avatar,null, @id_lop, 2)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", sv.name);
            cmd.Parameters.AddWithValue("@gender", sv.gender);
            cmd.Parameters.AddWithValue("@birthday", sv.birthday);
            cmd.Parameters.AddWithValue("@email", sv.email);
            cmd.Parameters.AddWithValue("@phone", sv.phone);
            cmd.Parameters.AddWithValue("@address", sv.address);
            cmd.Parameters.AddWithValue("@avatar", sv.avatar);
            cmd.Parameters.AddWithValue("@id_lop", sv.id_lop);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public SinhVien lay1SV(int id)
        {
            conn.Open();
            string sql = "select * from SinhVien where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            SinhVien sv = null;
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

        public String layAvatar(int id)
        {
            conn.Open();
            string avatar = "";
            string sql = "select avatar from SinhVien where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                avatar += rd["avatar"];
            }
            conn.Close();
            return avatar;
        }
    }
}