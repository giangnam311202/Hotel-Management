using AppQuanLyKhachSan.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKhachSan
{
    public partial class ThemDichVu : Form
    {
        public ThemDichVu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TENDICHVU = textBox1.Text;
            string DONGIA = textBox2.Text.Replace(',', '.');
            if (TENDICHVU == "" && DONGIA == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "INSERT INTO DICHVU (TENDICHVU, TINHTRANG, DONGIA) VALUES (@TENDICHVU, N'Có sẵn', @DONGIA);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENDICHVU", TENDICHVU);
                cmd.Parameters.AddWithValue("@DONGIA", DONGIA);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            this.Close();
        }

        private void numberonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.Length > 11)
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
