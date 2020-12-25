using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.DataUtil;
using QuanLyDiemSinhVienHaui.Modal;

namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class KhoaDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();
        public List<Khoa> getDSKhoa()
        {
            List<Khoa> ds = new List<Khoa>();
            conn.Open();
            String sql = "select * from Khoa";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Khoa k = new Khoa();
                k.id = (int)rd["id"];
                k.name = (string)rd["name"];
                k.description = (string)rd["description"];
                ds.Add(k);
            }
            conn.Close();
            return ds;
        }

        public void addKhoa(Khoa khoa)
        {
            conn.Open();
            String sql = "insert into Khoa values(@name, @description)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", khoa.name);
            cmd.Parameters.AddWithValue("@description", khoa.description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void editKhoa(Khoa khoa)
        {
            conn.Open();
            String sql = "update Khoa set name = @name, description = @description" +
                " where id = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", khoa.name);
            cmd.Parameters.AddWithValue("@description", khoa.description);
            cmd.Parameters.AddWithValue("@id", khoa.id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Khoa get1Khoa(int id)
        {
            conn.Open();
            String sql = "select * from Khoa where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            Khoa khoa = null;
            if (rd.Read())
            {
                khoa = new Khoa();
                khoa.id = (int)rd["id"];
                khoa.name = (string)rd["name"];
                khoa.description = (string)rd["description"];
            }
            conn.Close();
            return khoa;
        }

        public void deleteKhoa(int id)
        {
            conn.Open();
            String sql = "delete from Khoa where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}