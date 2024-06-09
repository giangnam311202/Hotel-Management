using AppQuanLyKhachSan;
using AppQuanLyKhachSan.Class;
using ControlzEx.Standard;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrangChuQLKS
{
    public partial class QLPhong_receptionist : Form
    {
        public QLPhong_receptionist()
        {
            InitializeComponent();
            QLPhong_Shown();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datafilter(object sender, EventArgs e)
        {
            string MAPHONG = textBox1.Text;
            string TINHTRANG = comboBox3.Text;
            string LOAIPHONG = comboBox1.Text;

            if (TINHTRANG == "None" || TINHTRANG == "Tính trạng")
            {
                TINHTRANG = "";
            }
            if (LOAIPHONG == "None" || LOAIPHONG == "Loại phòng")
            {
                LOAIPHONG = "";
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PHONG WHERE MAPHONG LIKE '%' + @MAPHONG + '%' AND TINHTRANG LIKE '%' + @TINHTRANG + '%' AND MALP LIKE '%' + @LOAIPHONG + '%'", conn);
                cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);
                cmd.Parameters.AddWithValue("@TINHTRANG", TINHTRANG);
                cmd.Parameters.AddWithValue("@LOAIPHONG", LOAIPHONG);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = dataTable;
                conn.Close();
            }
        }

        private void ThuePhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThuePhong_receptionist tphong = new ThuePhong_receptionist();
            tphong.ShowDialog();
            this.Close();
        }

        private void Dichvu_click(object sender, EventArgs e)
        {
            this.Hide();
            QLDichVu_receptionist qtdv = new QLDichVu_receptionist();
            qtdv.ShowDialog();
            this.Close();
        }

        private void Hoadon_click(object sender, EventArgs e)
        {
            this.Hide();
            QLHoaDon_receptionist qLHoaDon = new QLHoaDon_receptionist();
            qLHoaDon.ShowDialog();
            this.Close();
        }
        public void Dangxuat_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "Loại phòng";
            comboBox3.Text = "Tính trạng";
            Database database = new Database();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.PHONG_search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MAPHONG = textBox1.Text;
            string TINHTRANG = comboBox3.Text;
            string LOAIPHONG = comboBox1.Text;

            if (TINHTRANG == "None" || TINHTRANG == "Tính trạng")
            {
                TINHTRANG = "";
            }
            if (LOAIPHONG == "None" || LOAIPHONG == "Loại phòng")
            {
                LOAIPHONG = "";
            }
            if (MAPHONG == "" || LOAIPHONG == "" || TINHTRANG == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM PHONG WHERE MAPHONG = @MAPHONG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Chưa có loại phòng này", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "UPDATE PHONG SET MALP = @LOAIPHONG, TINHTRANG = @TINHTRANG WHERE MAPHONG = @MAPHONG;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);
                cmd.Parameters.AddWithValue("@LOAIPHONG", LOAIPHONG);
                cmd.Parameters.AddWithValue("@TINHTRANG", TINHTRANG);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            QLPhong_Shown();
        }

        private void QLPhong_Shown()
        {
            Database database = new Database();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.PHONG_search();
            dataGridView1.AllowUserToAddRows = false;

            DataTable dataTable = new DataTable();
            using(SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT * FROM LOAIPHONG";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                conn.Close();
            }
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = dataTable;
            dataGridView2.AllowUserToAddRows = false;

            comboBox1.Items.Clear();
            comboBox1.Items.Add("None");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells[2].Value?.ToString();
                    if (!string.IsNullOrEmpty(cellValue) && !comboBox1.Items.Contains(cellValue))
                    {
                        comboBox1.Items.Add(cellValue);
                    }
                }
            }

            comboBox3.Items.Clear();
            comboBox3.Items.Add("None");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells[1].Value?.ToString();
                    if (!string.IsNullOrEmpty(cellValue) && !comboBox3.Items.Contains(cellValue))
                    {
                        comboBox3.Items.Add(cellValue);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row != null)
                {
                    var c1 = row.Cells[0].Value?.ToString();
                    var c2 = row.Cells[1].Value?.ToString();
                    var c3 = row.Cells[2].Value?.ToString();
                    comboBox3.Text = c2;
                    comboBox1.Text = c3;
                    textBox1.Text = c1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return;
            }

            string MAPHONG = textBox1.Text;
            string TINHTRANG = comboBox3.Text;
            string LOAIPHONG = comboBox1.Text;


            if (TINHTRANG == "None" || TINHTRANG == "Tính trạng")
            {
                TINHTRANG = "";
            }
            if (LOAIPHONG == "None" || LOAIPHONG == "Loại phòng")
            {
                LOAIPHONG = "";
            }

            if (MAPHONG == "" || TINHTRANG == "" || LOAIPHONG == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM PHONG WHERE MAPHONG = @MAPHONG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "DELETE PHONG WHERE MAPHONG = @MAPHONG;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            QLPhong_Shown();
        }
    }
}
