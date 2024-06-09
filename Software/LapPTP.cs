using AppQuanLyKhachSan.Class;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyKhachSan
{
    public partial class LapPTP : Form
    {
        int SOKH = 0;
        string MAPTP = "";
        int SOKHACHTOIDA = 0;

        public LapPTP()
        {
            InitializeComponent();
            Database database = new Database();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.PHONGTRONG();
            dataGridView1.AllowUserToAddRows = false;
            lamtron();

            SOKHACHTOIDA = database.SOKHACHTOIDA();
            label5.Text = "Số khách tối đa là " + SOKHACHTOIDA;

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên khách hàng",
                Name = "TenKhachHang"
            });

            DataGridViewComboBoxColumn loaiKhachHangColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Loại khách hàng",
                Name = "LoaiKhachHang"
            };

            DataTable table = database.LOAIKHACHHANG();
            foreach (DataRow row in table.Rows)
            {
                var cellValue = row[0].ToString();
                if (!string.IsNullOrEmpty(cellValue) && !loaiKhachHangColumn.Items.Contains(cellValue))
                {
                    loaiKhachHangColumn.Items.Add(cellValue);
                }
            }

            dataGridView2.Columns.Add(loaiKhachHangColumn);

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CMND",
                Name = "CMND"
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Địa chỉ",
                Name = "DiaChi"
            });

            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToAddRows = false;

            SOKH += 1;
            dataGridView2.Rows.Add();

            dataGridView2.EditingControlShowing += DataGridView2_EditingControlShowing;
        }

        private void DataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                textBox.KeyPress -= CMND_KeyPress;

                if (dataGridView2.CurrentCell.ColumnIndex == dataGridView2.Columns["CMND"].Index)
                {
                    textBox.KeyPress += CMND_KeyPress;
                }
            }
        }
        public void lamtron()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string DG = row.Cells[2].Value.ToString();
                DG = DG.TrimEnd('0');
                if (DG.EndsWith(","))
                {
                    DG = DG.TrimEnd(',');
                }
                row.Cells[2].Value = DG;
            }
            return;
        }

        private void CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.Length >= 12)
            {
                e.Handled = true;

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MAPHONG = textBox10.Text;
            string TENKHACHHANG = "";
            string LOAIKH = "";
            string CMND = "";
            string DIACHI = "";
            int CkKH = 0;
            if (MAPHONG == "")
            {
                MessageBox.Show("Vui lòng chọn phòng để đăng ký", "Thông báo");
                return;
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                TENKHACHHANG = row.Cells["TenKhachHang"].Value?.ToString();
                LOAIKH = row.Cells["LoaiKhachHang"].Value?.ToString();
                CMND = row.Cells["CMND"].Value?.ToString();

                if (string.IsNullOrEmpty(TENKHACHHANG) || string.IsNullOrEmpty(LOAIKH))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin tên khách hàng và loại khách hàng của tất cả khách hàng", "Thông báo");
                    return;
                }
                if (!(CMND == null || CMND.Length == 12))
                {
                    MessageBox.Show("Số CMND phải là dãy 12 số", "Thông báo");
                    return;
                }
            }
            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                TENKHACHHANG = row.Cells["TenKhachHang"].Value?.ToString();
                LOAIKH = row.Cells["LoaiKhachHang"].Value?.ToString();
                CMND = row.Cells["CMND"].Value?.ToString();
                DIACHI = row.Cells["DiaChi"].Value?.ToString();
                CkKH++;
                if (CMND == null)
                {
                    CMND = "";
                }
                if(DIACHI == null)
                {
                    DIACHI = "";
                }
                if(CkKH == 1)
                {
                    using (SqlConnection conn = new SqlConnection(Database.connection))
                    {
                        conn.Open();
                        string query = "DECLARE @InsertedIDs TABLE (MAPTP CHAR(6));" +
                                        "INSERT INTO PHIEUTHUEPHONG (NGAYLAPPHIEU, MAPHONG) " +
                                        "OUTPUT inserted.MAPTP INTO @InsertedIDs(MAPTP) " +
                                        "VALUES (@DATE, @MAPHONG);" +
                                        "SELECT MAPTP FROM @InsertedIDs;";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@DATE", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MAPTP = reader["MAPTP"].ToString();
                            }
                        }
                        conn.Close();
                    }
                }

                using (SqlConnection conn = new SqlConnection(Database.connection))
                {
                    conn.Open();
                    string query = "INSERT INTO CHITIETPTP (MAPTP, MALKH, TENKHACHHANG, CMND, DIACHI) VALUES (@MAPTP, @MALKH, @TENKHACHHANG, @CMND, @DIACHI)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MAPTP", MAPTP);
                    cmd.Parameters.AddWithValue("@MALKH", LOAIKH);
                    cmd.Parameters.AddWithValue("@TENKHACHHANG", TENKHACHHANG);
                    cmd.Parameters.AddWithValue("@CMND", CMND);
                    cmd.Parameters.AddWithValue("@DIACHI", DIACHI);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "UPDATE PHONG SET TINHTRANG = N'Đã thuê' WHERE MAPHONG = @MAPHONG";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPHONG", MAPHONG);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MAPHONG = textBox1.Text;

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT MAPHONG, MALP, DONGIA FROM QLPHONG WHERE TINHTRANG = N'Có sẵn' AND MAPHONG LIKE @MAPHONG";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPHONG", "%" + MAPHONG + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                var c1 = dataGridView1.Rows[row].Cells[0].Value?.ToString() ?? string.Empty;
                textBox10.Text = c1;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            SOKH++;
            if (SOKH <= SOKHACHTOIDA)
            {
                dataGridView2.Rows.Add();
                return;
            }
            else
            {
                SOKH--;
                MessageBox.Show("Số khách hàng đã đạt tối đa", "Thông báo");
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(SOKH == 1)
            {
                MessageBox.Show("Phải có ít nhất một khách hàng", "Thông báo");
                return;
            }
            SOKH--;
            dataGridView2.Rows.RemoveAt(dataGridView2.Rows.Count - 1);
            return;
        }
    }
}
