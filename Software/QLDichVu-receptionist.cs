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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TrangChuQLKS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppQuanLyKhachSan
{
    public partial class QLDichVu_receptionist : Form
    {
        public QLDichVu_receptionist()
        {
            InitializeComponent();
            datashow();
        }
        public void datashow()
        {
            Database database = new Database();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.QLDICHVU_search();
            dataGridView1.AllowUserToAddRows = false;
            lamtron();
            comboBox3.Items.Clear();
            comboBox3.Items.Add("None");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells[2].Value?.ToString();
                    if (!string.IsNullOrEmpty(cellValue) && !comboBox3.Items.Contains(cellValue))
                    {
                        comboBox3.Items.Add(cellValue);
                    }
                }
            }
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
        public void label7_Click(object sender, EventArgs e)
        {

        }

        public void Datafilter(object sender, EventArgs e)
        {
            string MADV = textBox1.Text;
            string TINHTRANG = comboBox3.Text;
            string TENDICHVU = textBox2.Text;
            string DONGIA = textBox3.Text;
            if (TINHTRANG == "Tính trạng" || TINHTRANG == "None")
            {
                TINHTRANG = "";
            }
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                string query = "SELECT * FROM DICHVU WHERE MADV LIKE @MADV AND TENDICHVU LIKE @TENDICHVU AND CAST(DONGIA AS VARCHAR) LIKE @DONGIA AND TINHTRANG LIKE @TINHTRANG";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADV", "%" + MADV + "%");
                cmd.Parameters.AddWithValue("@TINHTRANG", "%" + TINHTRANG + "%");
                cmd.Parameters.AddWithValue("@TENDICHVU", "%" + TENDICHVU + "%");
                if (DONGIA == "0")
                {
                    cmd.Parameters.AddWithValue("@DONGIA", DONGIA);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DONGIA", "%" + DONGIA + "%");
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                conn.Close();
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;
            lamtron();
        }

        public void Phong_click(object sender, EventArgs e)
        {
            this.Hide();
            QLPhong_receptionist qLPhong = new QLPhong_receptionist();
            qLPhong.ShowDialog();
            this.Close();
        }
        private void ThuePhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThuePhong_receptionist tphong = new ThuePhong_receptionist();
            tphong.ShowDialog();
            this.Close();
        }

        public void Hoadon_click(object sender, EventArgs e)
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

        public void button2_Click(object sender, EventArgs e)
        {
            string MADV = textBox1.Text;
            string TINHTRANG = comboBox3.Text;
            string TENNDICHVU = textBox2.Text;
            string DONGIA = textBox3.Text.Replace(',', '.');

            if (TINHTRANG == "None" || TINHTRANG == "Tính trạng")
            {
                TINHTRANG = "";
            }

            if (MADV == "" || TENNDICHVU == "" || TINHTRANG == "" || DONGIA == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM DICHVU WHERE MADV = @MADV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MADV", MADV);

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
                string query = "UPDATE DICHVU SET TINHTRANG = @TINHTRANG, TENDICHVU = @TENDICHVU, DONGIA = @DONGIA WHERE MADV = @MADV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADV", MADV);
                cmd.Parameters.AddWithValue("@TINHTRANG", TINHTRANG);
                cmd.Parameters.AddWithValue("@TENDICHVU", TENNDICHVU);
                cmd.Parameters.AddWithValue("@DONGIA", DONGIA);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
                conn.Close();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox3.Text = "Tính trạng";
            textBox3.Text = "";


            Database database = new Database();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.QLDICHVU_search();
            lamtron();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox3.Text = "Tính trạng";
            textBox3.Text = "";

            Database database = new Database();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.QLDICHVU_search();
            lamtron();
        }


        public void button3_Click(object sender, EventArgs e)
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

            string MADV = textBox1.Text;
            string TINHTRANG = comboBox3.Text;
            string TENNDICHVU = textBox2.Text;
            string DONGIA = textBox3.Text.Replace(',', '.');

            if (TINHTRANG == "None" || TINHTRANG == "Tính trạng")
            {
                TINHTRANG = "";
            }

            if (MADV == "" || TENNDICHVU == "" || TINHTRANG == "" || DONGIA == "")
            {
                MessageBox.Show("Vui lòng Nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM DICHVU WHERE MADV = @MADV";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MADV", MADV);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Mã khách hàng không tồn tại.", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }
            string query1 = "DELETE FROM CT_DANGKYDV WHERE MADV = @MADV";
            string query2 = "DELETE FROM DICHVU WHERE TINHTRANG = @TINHTRANG AND TENDICHVU = @TENDICHVU AND DONGIA = @DONGIA AND MADV = @MADV";
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd1.Parameters.AddWithValue("@MADV", MADV);
                cmd2.Parameters.AddWithValue("@MADV", MADV);
                cmd2.Parameters.AddWithValue("@TINHTRANG", TINHTRANG);
                cmd2.Parameters.AddWithValue("@TENDICHVU", TENNDICHVU);
                cmd2.Parameters.AddWithValue("@DONGIA", DONGIA);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                int row1 = cmd1.ExecuteNonQuery();
                int row2 = cmd2.ExecuteNonQuery();
                if (row1 > 0 && row2 > 0)
                {
                    MessageBox.Show("Thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo");
                }
                conn.Close();
            }
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox3.Text = "Tính trạng";
            textBox3.Text = "";

            Database database = new Database();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.QLDICHVU_search();
            lamtron();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
                    var c4 = row.Cells[3].Value?.ToString();

                    comboBox3.Text = c3;
                    textBox1.Text = c1;
                    textBox2.Text = c2;
                    textBox3.Text = c4;
                }
            }
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
