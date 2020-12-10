using QuanLyDiemSinhVienHaui.Modal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class MonHocDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();
        public List<MonHoc> getDSMonHoc()
        {
            List<MonHoc> ds = new List<MonHoc>();
            conn.Open();
            String sql = "select * from monhoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MonHoc m = new MonHoc();
                m.id = (int)rd["id"];
                m.name = (string)rd["name"];
                m.description = (string)rd["description"];
                m.sotinchi = (int)rd["sotinchi"];
                ds.Add(m);
            }
            conn.Close();
            return ds;
        }

        public void addMonHoc(MonHoc mon)
        {
            conn.Open();
            String sql = "insert into MonHoc values(@name, @description, @sotinchi)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", mon.name);
            cmd.Parameters.AddWithValue("@description", mon.description);
            cmd.Parameters.AddWithValue("@sotinchi", mon.sotinchi);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void editMonHoc(MonHoc mon)
        {
            conn.Open();
            String sql = "update MonHoc set name = @name, description = @description, sotinchi = @sotinchi" +
                " where id = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", mon.name);
            cmd.Parameters.AddWithValue("@description", mon.description);
            cmd.Parameters.AddWithValue("@sotinchi", mon.sotinchi);
            cmd.Parameters.AddWithValue("@id", mon.id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public MonHoc get1MonHoc(int id)
        {
            conn.Open();
            String sql = "select * from MonHoc where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            MonHoc mon = null;
            if (rd.Read())
            {
                mon = new MonHoc();
                mon.id = (int)rd["id"];
                mon.name = (string)rd["name"];
                mon.description = (string)rd["description"];
                mon.sotinchi = (int)rd["sotinchi"];
            }
            conn.Close();
            return mon;
        }

        public void deleteMonHoc(int id)
        {
            conn.Open();
            String sql = "delete from monhoc where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}