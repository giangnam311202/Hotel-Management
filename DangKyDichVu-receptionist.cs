using AppQuanLyKhachSan.Class;
using MahApps.Metro.Controls;
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

namespace AppQuanLyKhachSan
{
    public partial class DangKyDichVu_receptionist : Form
    {
        public DangKyDichVu_receptionist()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT * FROM TT_PTP_DKDV";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.DataSource = dt;
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;

        }
        public void lamtron()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    string DG = row.Cells[4].Value.ToString();
                    DG = DG.TrimEnd('0');
                    if (DG.EndsWith(","))
                    {
                        DG = DG.TrimEnd(',');
                    }
                    row.Cells[4].Value = DG;
                }
            }
            return;
        }

        public void lamtron2()
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    string DG = row.Cells[3].Value.ToString();
                    DG = DG.TrimEnd('0');
                    if (DG.EndsWith(","))
                    {
                        DG = DG.TrimEnd(',');
                    }
                    row.Cells[3].Value = DG;
                }
            }
            return;
        }

        string MAPHONG;
        string MAPTP;

        public void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string c1 = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            string c2 = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            MAPHONG = c1;
            MAPTP = c2;
            textBox1.Text = c1;
            textBox10.Text = c1;

            DVCDK();
            DVDDK();
        }

        public void DVCDK()
        {
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT * FROM DICHVU D WHERE D.MADV NOT IN(SELECT MADV FROM CT_DANGKYDV C JOIN TT_PTP_DKDV T ON C.MAPTP = T.MAPTP WHERE C.MAPTP = @MAPTP) AND TINHTRANG = N'Có sẵn'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPTP", MAPTP);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    bool checkBoxColumnExists = false;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if (column.Name == "check value")
                        {
                            checkBoxColumnExists = true;
                            break;
                        }
                    }
                    if (!checkBoxColumnExists)
                    {
                        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                        checkBoxColumn.Name = "check value";
                        checkBoxColumn.HeaderText = "";
                        dataGridView1.Columns.Insert(0, checkBoxColumn);
                    }
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.DataSource = dt;
                    lamtron();
                }
                else
                {
                    dataGridView1.DataSource = null;
                    bool checkBoxColumnExists = false;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        if (column.Name == "check value")
                        {
                            checkBoxColumnExists = true;
                            break;
                        }
                    }
                    if (checkBoxColumnExists)
                    {
                        dataGridView1.Columns.Remove("check value");
                    }
                }
                conn.Close();
            }
        }

        public void DVDDK()
        {
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT D.MADV, D.TENDICHVU, D.DONGIA, CT_DANGKYDV.NGAYDANGKY FROM DICHVU D JOIN CT_DANGKYDV ON D.MADV = CT_DANGKYDV.MADV WHERE D.MADV IN(SELECT MADV FROM CT_DANGKYDV C JOIN TT_PTP_DKDV T ON C.MAPTP = T.MAPTP WHERE C.MAPTP = @MAPTP) AND CT_DANGKYDV.MAPTP = @MAPTP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPTP", MAPTP);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    bool checkBoxColumnExists = false;
                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        if (column.Name == "check value")
                        {
                            checkBoxColumnExists = true;
                            break;
                        }
                    }
                    if (!checkBoxColumnExists)
                    {
                        DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                        checkBoxColumn.Name = "check value";
                        checkBoxColumn.HeaderText = "";
                        dataGridView3.Columns.Insert(0, checkBoxColumn);
                    }
                    dataGridView3.RowHeadersVisible = false;
                    dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView3.DataSource = dt;
                    lamtron2();
                }
                else
                {
                    dataGridView3.DataSource = null;
                    bool checkBoxColumnExists = false;
                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        if (column.Name == "check value")
                        {
                            checkBoxColumnExists = true;
                            break;
                        }
                    }
                    if (checkBoxColumnExists)
                    {
                        dataGridView3.Columns.Remove("check value");
                    }
                }
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MAPHONG = textBox1.Text;
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT * FROM TT_PTP_DKDV WHERE MAPHONG LIKE @MAPHONG";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPHONG", "%" + MAPHONG + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                var press = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["check value"].Value);
                if (press)
                {
                    dataGridView1.Rows[e.RowIndex].Cells["check value"].Value = false;
                    dataGridView1.EndEdit();
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells["check value"].Value = true;
                    dataGridView1.EndEdit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.ColumnCount == 0)
            {
                MessageBox.Show("Phòng đã đăng ký tất cả các dịch vụ", "Thông báo");
                return;
            }
            List<string> checkedRows = new List<string>();
            DateTime NGAY = dateTimePicker1.Value;
            string NGAYDKANGKY = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (NGAY.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày không được nhỏ hơn ngày hiện tại", "Thông báo");
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["check value"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    string MADV = row.Cells["MADV"].Value.ToString();
                    checkedRows.Add(MADV);
                }
            }
            if (checkedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ", "Thông báo");
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(Database.connection))
                {
                    conn.Open();
                    foreach (string MADV in checkedRows)
                    {
                        string query = "INSERT INTO CT_DANGKYDV (MADV, MAPTP, NGAYDANGKY) VALUES (@MADV, @MAPTP, @NGAYDANGKY)";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@MADV", MADV);
                            command.Parameters.AddWithValue("@MAPTP", MAPTP);
                            command.Parameters.AddWithValue("@NGAYDANGKY", NGAYDKANGKY);
                            command.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }
            MessageBox.Show("Thành công", "Thông báo");
            Datashow();
        }

        public void Datashow()
        {
            DVCDK();
            DVDDK();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                var press = Convert.ToBoolean(dataGridView3.Rows[e.RowIndex].Cells["check value"].Value);
                if (press)
                {
                    dataGridView3.Rows[e.RowIndex].Cells["check value"].Value = false;
                    dataGridView3.EndEdit();
                }
                else
                {
                    dataGridView3.Rows[e.RowIndex].Cells["check value"].Value = true;
                    dataGridView3.EndEdit();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView3.ColumnCount == 0)
            {
                MessageBox.Show("Phòng chưa đăng ký bất kì dịch vụ nào dịch vụ", "Thông báo");
                return;
            }
            List<string> checkedRows = new List<string>();
            DateTime NGAY = dateTimePicker1.Value;
            string NGAYDKANGKY = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (NGAY.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày không được nhỏ hơn ngày hiện tại", "Thông báo");
                return;
            }
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["check value"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    string MADV = row.Cells["MADV"].Value.ToString();
                    checkedRows.Add(MADV);
                }
            }
            if (checkedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ", "Thông báo");
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(Database.connection))
                {
                    conn.Open();
                    foreach (string MADV in checkedRows)
                    {
                        string query = "UPDATE CT_DANGKYDV SET NGAYDANGKY = @NGAYDANGKY WHERE MADV = @MADV AND MAPTP = @MAPTP";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@MADV", MADV);
                            command.Parameters.AddWithValue("@MAPTP", MAPTP);
                            command.Parameters.AddWithValue("@NGAYDANGKY", NGAYDKANGKY);
                            command.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }
            MessageBox.Show("Thành công", "Thông báo");
            Datashow();
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
            if (dataGridView3.ColumnCount == 0)
            {
                MessageBox.Show("Phòng chưa đăng ký bất kì dịch vụ nào dịch vụ", "Thông báo");
                return;
            }
            List<string> checkedRows = new List<string>();
            DateTime NGAY = dateTimePicker1.Value;
            string NGAYDKANGKY = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (NGAY.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Không được xóa dịch vụ đã sửa dụng", "Thông báo");
                return;
            }
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["check value"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    string MADV = row.Cells["MADV"].Value.ToString();
                    checkedRows.Add(MADV);
                }
            }
            if (checkedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ", "Thông báo");
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(Database.connection))
                {
                    conn.Open();
                    foreach (string MADV in checkedRows)
                    {
                        string query = "DELETE FROM CT_DANGKYDV WHERE MADV = @MADV AND MAPTP = @MAPTP";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@MADV", MADV);
                            command.Parameters.AddWithValue("@MAPTP", MAPTP);
                            command.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                }
            }
            MessageBox.Show("Thành công", "Thông báo");
            Datashow();
        }
    }
}

