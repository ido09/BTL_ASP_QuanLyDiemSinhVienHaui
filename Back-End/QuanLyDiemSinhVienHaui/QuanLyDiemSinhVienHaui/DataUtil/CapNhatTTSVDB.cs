using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.Modal;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class CapNhatTTSVDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();

        public string getName(string email)
        {
            DataTable dt = new DataTable();
            string sql = "select name from SinhVien where email = @email ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("email", email);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            string name = dt.Rows[0][0].ToString();
            conn.Close();
            return name;
        }
        public string getBirthday(string email)
        {
            DataTable dt = new DataTable();
            string sql = "select birthday from SinhVien where email = @email ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("email", email);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            string birthday = dt.Rows[0][0].ToString();
            conn.Close();
            return birthday;
        }
        public string getPhone(string email)
        {
            DataTable dt = new DataTable();
            string sql = "select phone from SinhVien where email = @email ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("email", email);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            string phone = dt.Rows[0][0].ToString();
            conn.Close();
            return phone;
        }
        public string getAddress(string email)
        {
            DataTable dt = new DataTable();
            string sql = "select address from SinhVien where email = @email ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("email", email);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            string address = dt.Rows[0][0].ToString();
            conn.Close();
            return address;
        }
        public string getGender(string email)
        {
            DataTable dt = new DataTable();
            string sql = "select gender from SinhVien where email = @email ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("email", email);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dt);
            string gender = dt.Rows[0][0].ToString();
            conn.Close();
            return gender;
        }
        public void suaSV(SinhVien sv)
        {
            conn.Open();
            string sql = "update SinhVien set name=@name, gender = @gender," +
                "birthday = @birthday, email = @email, phone = @phone," +
                "address = @address, avatar = @avatar where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", sv.name);
            cmd.Parameters.AddWithValue("@gender", sv.gender);
            cmd.Parameters.AddWithValue("@birthday", sv.birthday);
            cmd.Parameters.AddWithValue("@email", sv.email);
            cmd.Parameters.AddWithValue("@phone", sv.phone);
            cmd.Parameters.AddWithValue("@address", sv.address);
            cmd.Parameters.AddWithValue("@avatar", sv.avatar);

            cmd.Parameters.AddWithValue("@id", sv.id);
            cmd.ExecuteNonQuery();
            conn.Close();
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

        public void doiMK(SinhVien sv)
        {
            conn.Open();
            string sql = "update SinhVien set password=@password where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@password", sv.password);
            cmd.Parameters.AddWithValue("@id", sv.id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}