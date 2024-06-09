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

namespace AppQuanLyKhachSan
{
    public partial class QLDoanhThu : Form
    {
        public QLDoanhThu()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string THANG = textBox1.Text;
            string NAM = textBox2.Text;
            int thangValue = int.Parse(THANG);
            if (thangValue <= 0 || thangValue > 12)
            {
                MessageBox.Show("Vui lòng nhập số tháng từ 1 đến 12", "Thông báo");
                return;
            }

            string query = "SELECT * FROM BCDT_THANG_NAM WHERE THANG = @THANG AND NAM LIKE @NAM";
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@THANG", THANG);
                cmd.Parameters.AddWithValue("@NAM", "%" + NAM + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                conn.Close();
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;
            lamtron();
        }

        public void lamtron()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string DG = row.Cells[3].Value.ToString();
                DG = DG.TrimEnd('0');
                if (DG.EndsWith(","))
                {
                    DG = DG.TrimEnd(',');
                }
                row.Cells[3].Value = DG;
            }
            return;
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
        private void Hoadon_click(object sender, EventArgs e)
        {
            this.Hide();
            QLHoaDon qLHoaDon = new QLHoaDon();
            qLHoaDon.ShowDialog();
            this.Close();
        }
        public void Dangxuat_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ad_QuanLy ql = new Ad_QuanLy();
            ql.ShowDialog();
            this.Close();
        }

        private void numberonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
