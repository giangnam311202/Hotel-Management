using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyKhachSan.Class
{
    internal class Database
    {

        public static string connection = "Data Source=LAPTOP-52KB8O7T;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";

        public DataTable PHONG_search()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM PHONG";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable QLPHONG_search()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM QLPHONG";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
        public DataTable QLDICHVU_search()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM DICHVU";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable ThuePhong_Search()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM QL_PHIEUTHUEPHONG";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable LOAIKHACHHANG()
        {
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT MALKH FROM LOAIKH";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public int SOKHACHTOIDA()
        {
            DataTable dt = new DataTable();
            string query = "SELECT KTD FROM KHACHTOIDA";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            int SOKHACHTOIDA = 0;
            foreach (DataRow row in dt.Rows)
            {
                var cellValue = row[0].ToString();
                if (!string.IsNullOrEmpty(cellValue))
                {
                    SOKHACHTOIDA = int.Parse(cellValue);
                }
                return SOKHACHTOIDA;
            }
            return 0;
        }

        public DataTable QL_HOADON()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM QL_HOADON";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable PHONGTRONG()
        {
            DataTable db = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT MAPHONG, MALP, DONGIA FROM QLPHONG WHERE TINHTRANG = N'Có sẵn'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(db);
                conn.Close();
            }
            return db;
        }

        public DataTable XOAPTP()
        {
            DataTable db = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM PTP_CT_HD";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(db);
                conn.Close();
            }
            return db;
        }

        public DataTable XoaHD()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM HD_PTP";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }
    }
}
