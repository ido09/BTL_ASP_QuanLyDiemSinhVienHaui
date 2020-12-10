using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class GiangVienDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();

        public List<GiangVien> getDSGiangVien()
        {
            List<GiangVien> ds = new List<GiangVien>();
            conn.Open();
            String sql = "select * from GiangVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                GiangVien gv = new GiangVien();
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
                ds.Add(gv);
            }
            conn.Close();
            return ds;
        }

        public void xoaGV(int id)
        {
            conn.Open();
            string sql = "delete from GiangVien where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void suaGV(GiangVien gv)
        {
            conn.Open();
            string sql = "update GiangVien set name=@name, gender = @gender," +
                "birthday = @birthday, email = @email, phone = @phone," +
                "address = @address, avatar = @avatar, " +
                "id_khoa = @id_khoa, role = 2 where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", gv.name);
            cmd.Parameters.AddWithValue("@gender", gv.gender);
            cmd.Parameters.AddWithValue("@birthday", gv.birthday);
            cmd.Parameters.AddWithValue("@email", gv.email);
            cmd.Parameters.AddWithValue("@phone", gv.phone);
            cmd.Parameters.AddWithValue("@address", gv.address);
            cmd.Parameters.AddWithValue("@avatar", gv.avatar);
            cmd.Parameters.AddWithValue("@id_khoa", gv.id_khoa);
            cmd.Parameters.AddWithValue("@id", gv.id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<GiangVien> timkiemGV(string keyword)
        {
            conn.Open();
            List<GiangVien> ds = new List<GiangVien>();
            string sql = "select * from GiangVien where name LIKE '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {   
                GiangVien gv = new GiangVien();
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
                ds.Add(gv);
            }
            conn.Close();
            return ds;
        }

        public void themGV(GiangVien gv)
        {
            conn.Open();
            string sql = "insert into GiangVien values(@name, @gender,@birthday, @email," +
                "@phone, @address, @avatar,null, @id_khoa, 2)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", gv.name);
            cmd.Parameters.AddWithValue("@gender", gv.gender);
            cmd.Parameters.AddWithValue("@birthday", gv.birthday);
            cmd.Parameters.AddWithValue("@email", gv.email);
            cmd.Parameters.AddWithValue("@phone", gv.phone);
            cmd.Parameters.AddWithValue("@address", gv.address);
            cmd.Parameters.AddWithValue("@avatar", gv.avatar);
            cmd.Parameters.AddWithValue("@id_khoa", gv.id_khoa);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public GiangVien lay1GV(int id)
        {
            conn.Open();
            string sql = "select * from GiangVien where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            GiangVien gv = null;
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

        public String layAvatar(int id)
        {
            conn.Open();
            string avatar = "";
            string sql = "select avatar from GiangVien where id = " + id;
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