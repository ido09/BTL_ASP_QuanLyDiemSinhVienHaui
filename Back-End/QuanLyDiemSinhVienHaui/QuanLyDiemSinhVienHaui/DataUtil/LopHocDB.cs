using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using QuanLyDiemSinhVienHaui.Modal;
namespace QuanLyDiemSinhVienHaui.DataUtil
{
    public class LopHocDB
    {
        SqlConnection conn = ConnectDB.getDBConnection();
        public List<Lop> getDSLopHoc()
        {
            List<Lop> ds = new List<Lop>();
            conn.Open();
            String sql = "select Lop.id, Lop.id_nganhhoc, NganhHoc.name as 'tennganh', Lop.name, " +
                "Lop.description from Lop inner join NganhHoc on Lop.id_nganhhoc = NganhHoc.id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Lop lop = new Lop();
                lop.id = (int)rd["id"];
                lop.name = (string)rd["name"];
                lop.description = (string)rd["description"];
                lop.id_nganhhoc = (int)rd["id_nganhhoc"];
                lop.tennganh = (string)rd["tennganh"];
                ds.Add(lop);
            }
            conn.Close();
            return ds;
        }

        public void addLopHoc(Lop lop)
        {
            conn.Open();
            String sql = "insert into Lop values(@name, @description, @id_nganhhoc)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", lop.name);
            cmd.Parameters.AddWithValue("@description", lop.description);
            cmd.Parameters.AddWithValue("@id_nganhhoc", lop.id_nganhhoc);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Lop> timkiemLopHoc(string keyword)
        {
            conn.Open();
            List<Lop> ds = new List<Lop>();
            string sql = "select * from Lop where name LIKE @keyword";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@keyword", '%' + keyword + '%');
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Lop lop = new Lop();
                lop.id = (int)rd["id"];
                lop.name = (string)rd["name"];
                lop.description = (string)rd["description"];
                lop.id_nganhhoc = (int)rd["id_nganhhoc"];
                ds.Add(lop);
            }
            return ds;
            conn.Close();
        }

        public void editLopHoc(Lop lop)
        {
            conn.Open();
            String sql = "update Lop set name = @name, description = @description, id_nganhhoc = @id_nganhhoc" +
                " where id = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", lop.name);
            cmd.Parameters.AddWithValue("@description", lop.description);
            cmd.Parameters.AddWithValue("@id_nganhhoc", lop.id_nganhhoc);
            cmd.Parameters.AddWithValue("@id", lop.id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Lop get1LopHoc(int id)
        {
            conn.Open();
            String sql = "select * from Lop where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            Lop lop = null;
            if (rd.Read())
            {
                lop = new Lop();
                lop.id = (int)rd["id"];
                lop.name = (string)rd["name"];
                lop.description = (string)rd["description"];
                lop.id_nganhhoc = (int)rd["id_nganhhoc"];
            }
            conn.Close();
            return lop;
        }

        public void deleteNganhHoc(int id)
        {
            conn.Open();
            String sql = "delete from Lop where id = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}