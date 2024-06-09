using AppQuanLyKhachSan.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrangChuQLKS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppQuanLyKhachSan
{
    public partial class ThemPhong : Form
    {
        public ThemPhong()
        {
            InitializeComponent();
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT MALP FROM LOAIPHONG";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                conn.Close();
            }
            comboBox1.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                var cellValue = row[0].ToString();
                if (!string.IsNullOrEmpty(cellValue) && !comboBox1.Items.Contains(cellValue))
                {
                    comboBox1.Items.Add(cellValue);
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MALP = comboBox1.Text;
            if (MALP == "Chọn loại phòng")
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Thông báo");
            }
            string query = "SELECT DONGIA FROM LOAIPHONG WHERE MALP = @MALP";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALP", MALP);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }

            foreach (DataRow row in dt.Rows)
            {
                var cellValue = row[0].ToString();
                if (!string.IsNullOrEmpty(cellValue))
                {
                    string DG = cellValue;
                    DG = DG.TrimEnd('0');
                    if (DG.EndsWith(","))
                    {
                        DG = DG.TrimEnd(',');
                    }
                    textBox2.Text = DG;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LOAIPHONG = comboBox1.Text;
            if (LOAIPHONG == "Chọn loại phòng")
            {
                MessageBox.Show("Vui lòng chọn loại phòng", "Thông báo");
                return;
            }
            string DONGIA = textBox2.Text;
            string query = "INSERT INTO PHONG (TINHTRANG, MALP) VALUES (N'Có sẵn', @LOAIPHONG)";
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LOAIPHONG", LOAIPHONG);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
