using AppQuanLyKhachSan.Class;
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
    public partial class KHACHTOIDA : Form
    {
        public KHACHTOIDA()
        {
            InitializeComponent();
            KHTD_show();
        }

        int SOKHACHTOIDA = 0;
        public void KHTD_show()
        {
            Database database = new Database();
            SOKHACHTOIDA = database.SOKHACHTOIDA();
            label2.Text = "Số khách tối đa là " + SOKHACHTOIDA;

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT * FROM TILEPHUTHU";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                var c1 = dataGridView1.Rows[row].Cells[0].Value?.ToString() ?? string.Empty;
                var c2 = dataGridView1.Rows[row].Cells[1].Value?.ToString() ?? string.Empty;

                textBox1.Text = c1;
                textBox2.Text = c2;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string KHACHHANGTHU = textBox1.Text;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT * FROM TILEPHUTHU WHERE KHACHHANGTHU LIKE @KHACHHANGTHU";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KHACHHANGTHU", "%" + KHACHHANGTHU + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TILEPHUTHU = textBox2.Text.Replace(',', '.');
            bool check = float.TryParse(TILEPHUTHU, out float n);
            if (TILEPHUTHU == "")
            {
                MessageBox.Show("Vui lòng nhập tỉ lệ phụ thu", "Thông báo");
                return;
            }
            if (check == false || n < 0)
            {
                MessageBox.Show("Vui lòng nhập tỉ lệ phụ thu theo dạng số không âm", "Thông báo");
                return;
            }
            SOKHACHTOIDA += 1;
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "INSERT INTO TILEPHUTHU (KHACHHANGTHU, TILEPHUTHU) VALUES (@KHACHHANGTHU, @TILEPHUTHU)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KHACHHANGTHU", SOKHACHTOIDA);
                cmd.Parameters.AddWithValue("@TILEPHUTHU", TILEPHUTHU);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            KHTD_show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string KHACHHANGTHU = textBox1.Text;
            string TILEPHUTHU = textBox2.Text.Replace(',', '.');
            if (TILEPHUTHU == "")
            {
                MessageBox.Show("Vui lòng nhập tỉ lệ phụ thu", "Thông báo");
                return;
            }
            if (KHACHHANGTHU == "")
            {
                MessageBox.Show("Chọn số khách hàng muốn thay đổi", "Thông báo");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM TILEPHUTHU WHERE KHACHHANGTHU = @KHACHHANGTHU";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KHACHHANGTHU", KHACHHANGTHU);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Không tìm thấy số khách hàng", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "UPDATE TILEPHUTHU SET TILEPHUTHU = @TILEPHUTHU WHERE KHACHHANGTHU = @KHACHHANGTHU";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KHACHHANGTHU", KHACHHANGTHU);
                cmd.Parameters.AddWithValue("@TILEPHUTHU", TILEPHUTHU);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            KHTD_show();
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
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "DELETE FROM TILEPHUTHU WHERE KHACHHANGTHU = @SOKHACHTOIDA";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SOKHACHTOIDA", SOKHACHTOIDA);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            KHTD_show();
        }

        private void numberonly(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.' || e.KeyChar == ',') && textBox.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.' && textBox.Text.Contains('.')) || (e.KeyChar == ',' && textBox.Text.Contains(',')))
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.' && textBox.Text.Contains(',')) || (e.KeyChar == ',' && textBox.Text.Contains('.')))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
