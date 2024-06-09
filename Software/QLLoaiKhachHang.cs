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

namespace AppQuanLyKhachSan
{
    public partial class QLLoaiKhachHang : Form
    {
        public QLLoaiKhachHang()
        {
            InitializeComponent();
            LOAIKH_Show();
        }

        private void LOAIKH_Show()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                string query = "SELECT * FROM LOAIKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row != null)
                {
                    textBox10.Text = row.Cells[0].Value?.ToString();
                    textBox1.Text = row.Cells[1].Value?.ToString();
                    textBox2.Text = row.Cells[2].Value?.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MALKH = textBox10.Text;
            string TENLKH = textBox1.Text;
            string HESOPHUTHU = textBox2.Text.Replace(',', '.');

            if (MALKH == "" || TENLKH == "" || HESOPHUTHU == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIKH WHERE MALKH = @MALKH";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MALKH", MALKH);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã loại khách đã tồn tại.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            float check = float.Parse(HESOPHUTHU);
            if (check == 0)
            {
                MessageBox.Show("Hệ số phụ thu không được là 0", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIKH WHERE TENLKH = @TENLKH";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TENLKH", TENLKH);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên loại khách đã tồn tại.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "INSERT INTO LOAIKH (MALKH, TENLKH, HESOPHUTHU) VALUES (@MALKH, @TENLKH, @HESOPHUTHU);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALKH", MALKH);
                cmd.Parameters.AddWithValue("@TENLKH", TENLKH);
                cmd.Parameters.AddWithValue("@HESOPHUTHU", HESOPHUTHU);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            LOAIKH_Show();
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
            string MALKH = textBox10.Text;
            string TENLKH = textBox1.Text;
            string HESOPHUTHU = textBox2.Text.Replace(',', '.');

            if (MALKH == "" || TENLKH == "" || HESOPHUTHU == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIKH WHERE MALKH = @MALKH";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MALKH", MALKH);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Không có mã khách hàng", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            float check = float.Parse(HESOPHUTHU);
            if (check == 0)
            {
                MessageBox.Show("Hệ số phụ thu không được là 0", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "DELETE FROM LOAIKH WHERE MALKH = @MALKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALKH", MALKH);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Thành công", "Thông báo");
            LOAIKH_Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MALKH = textBox10.Text;
            string TENLKH = textBox1.Text;
            string HESOPHUTHU = textBox2.Text.Replace(',', '.');

            if (MALKH == "" || TENLKH == "" || HESOPHUTHU == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIKH WHERE MALKH = @MALKH";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MALKH", MALKH);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Không có mã khách hàng", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }
            float check = float.Parse(HESOPHUTHU);
            if (check == 0)
            {
                MessageBox.Show("Hệ số phụ thu không được là 0", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIKH WHERE TENLKH = @TENLKH";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TENLKH", TENLKH);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên loại khách đã tồn tại.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "UPDATE LOAIKH SET TENLKH = @TENLKH, HESOPHUTHU = @HESOPHUTHU WHERE MALKH = @MALKH;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALKH", MALKH);
                cmd.Parameters.AddWithValue("@TENLKH", TENLKH);
                cmd.Parameters.AddWithValue("@HESOPHUTHU", HESOPHUTHU);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Thành công", "Thông báo");
            LOAIKH_Show();
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
    }
}
