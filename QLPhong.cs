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
    public partial class QLPhong : Form
    {
        public QLPhong()
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "Loại phòng";
            comboBox3.Text = "Tính trạng";
            Database database = new Database();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.PHONG_search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemPhong themPhong = new ThemPhong();
            themPhong.ShowDialog();
            this.Show();
            QLPhong_Shown();
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
                        MessageBox.Show("Mã phòng không tồn tại.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM QL_PHIEUTHUEPHONG WHERE MAPHONG = @MAPHONG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Phòng đang cho thuê.", "Thông báo");
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
                        MessageBox.Show("Mã phòng không tồn tại.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM QL_PHIEUTHUEPHONG WHERE MAPHONG = @MAPHONG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Phòng đang cho thuê.", "Thông báo");
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

        private void panel13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ad_QuanLy ad_ql = new Ad_QuanLy();
            ad_ql.ShowDialog();
            this.Close();
        }
    }
}
