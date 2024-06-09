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
    public partial class QLLoaiPhong : Form
    {
        public QLLoaiPhong()
        {
            InitializeComponent();
            LOAIPHONGSHOW();
        }

        public void lamtron()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    string DG = row.Cells[2].Value.ToString();
                    DG = DG.TrimEnd('0');
                    if (DG.EndsWith(","))
                    {
                        DG = DG.TrimEnd(',');
                    }
                    row.Cells[2].Value = DG;
                }
            }
            return;
        }

        public void LOAIPHONGSHOW()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                string query = "SELECT * FROM LOAIPHONG";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            lamtron();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string MALP = textBox10.Text;
            string TENLOAIPHONG = textBox1.Text;
            string DONGIA = textBox2.Text.Replace(',', '.');

            if (MALP == "" || TENLOAIPHONG == "" || DONGIA == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIPHONG WHERE MALP = @MALP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MALP", MALP);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã loại phòng đã tồn tại trong cơ sở dữ liệu.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            int check = int.Parse(DONGIA);
            if (check == 0)
            {
                MessageBox.Show("Đơn giá không được là 0", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIPHONG WHERE TENLOAIPHONG = @TENLOAIPHONG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TENLOAIPHONG", TENLOAIPHONG);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên loại phòng đã tồn tại trong cơ sở dữ liệu.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "INSERT INTO LOAIPHONG (MALP, TENLOAIPHONG, DONGIA) VALUES (@MALP, @TENLOAIPHONG, @DONGIA);";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALP", MALP);
                cmd.Parameters.AddWithValue("@TENLOAIPHONG", TENLOAIPHONG);
                cmd.Parameters.AddWithValue("@DONGIA", DONGIA);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            LOAIPHONGSHOW();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string MALP = textBox10.Text;
            string TENLOAIPHONG = textBox1.Text;
            string DONGIA = textBox2.Text.Replace(',', '.');

            if (MALP == "" || TENLOAIPHONG == "" || DONGIA == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIPHONG WHERE MALP = @MALP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MALP", MALP);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Chưa có loại phòng này", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            int check = int.Parse(DONGIA);
            if (check == 0)
            {
                MessageBox.Show("Đơn giá không được là 0", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIPHONG WHERE TENLOAIPHONG = @TENLOAIPHONG";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TENLOAIPHONG", TENLOAIPHONG);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên loại phòng đã tồn tại trong cơ sở dữ liệu.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "UPDATE LOAIPHONG SET TENLOAIPHONG = @TENLOAIPHONG, DONGIA = @DONGIA WHERE MALP = @MALP;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALP", MALP);
                cmd.Parameters.AddWithValue("@TENLOAIPHONG", TENLOAIPHONG);
                cmd.Parameters.AddWithValue("@DONGIA", DONGIA);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            LOAIPHONGSHOW();
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
            string MALP = textBox10.Text;
            string TENLOAIPHONG = textBox1.Text;
            string DONGIA = textBox2.Text.Replace(',', '.');

            if (MALP == "" || TENLOAIPHONG == "" || DONGIA == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM LOAIPHONG WHERE MALP = @MALP";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MALP", MALP);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Chưa có loại phòng này", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            int check = int.Parse(DONGIA);
            if (check == 0)
            {
                MessageBox.Show("Đơn giá không được là 0", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "DELETE LOAIPHONG WHERE MALP = @MALP;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MALP", MALP);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            LOAIPHONGSHOW();
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
