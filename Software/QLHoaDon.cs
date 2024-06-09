using AppQuanLyKhachSan.Class;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
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

namespace AppQuanLyKhachSan
{
    public partial class QLHoaDon : Form
    {
        public QLHoaDon()
        {
            InitializeComponent();
            QLHoaDon_Shown();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MAHD = textBox1.Text;
            string KHTHANHTOAN = textBox2.Text;

            string query = "SELECT * FROM QL_HOADON WHERE MAHD LIKE @MAHD AND KHTHANHTOAN LIKE @KHTHANHTOAN";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAHD", "%" + MAHD + "%");
                cmd.Parameters.AddWithValue("@KHTHANHTOAN", "%" + KHTHANHTOAN + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
            lamtron();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string MAHD = textBox1.Text;
            string KHTHANHTOAN = textBox2.Text;

            string query = "SELECT * FROM QL_HOADON WHERE MAHD LIKE @MAHD AND KHTHANHTOAN LIKE @KHTHANHTOAN";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAHD", "%" + MAHD + "%");
                cmd.Parameters.AddWithValue("@KHTHANHTOAN", "%" + KHTHANHTOAN + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
            lamtron();
        }

        private void Phong_click(object sender, EventArgs e)
        {
            this.Hide();
            QLPhong qLPhong = new QLPhong();
            qLPhong.ShowDialog();
            this.Close();
        }

        private void ThuePhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThuePhong tphong = new ThuePhong();
            tphong.ShowDialog();
            this.Close();
        }

        private void Dichvu_click(object sender, EventArgs e)
        {
            this.Hide();
            QLDichVu qtdv = new QLDichVu();
            qtdv.ShowDialog();
            this.Close();
        }

        private void Doangthu_click(object sender, EventArgs e)
        {
            this.Hide();
            QLDoanhThu qtdv = new QLDoanhThu();
            qtdv.ShowDialog();
            this.Close();
        }

        public void Dangxuat_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemHoaDon dn = new ThemHoaDon();
            dn.ShowDialog();
            this.Show();
            QLHoaDon_Shown();
        }

        private void QLHoaDon_Shown()
        {
            Database dt = new Database();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt.QL_HOADON();
            dataGridView1.AllowUserToAddRows = false;
            lamtron();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ad_QuanLy dn = new Ad_QuanLy();
            dn.ShowDialog();
            this.Show();
        }

        public void lamtron()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string DG = row.Cells[4].Value.ToString();
                DG = DG.TrimEnd('0');
                if (DG.EndsWith(","))
                {
                    DG = DG.TrimEnd(',');
                }
                row.Cells[4].Value = DG;
            }
            return;
        }
    }
}
