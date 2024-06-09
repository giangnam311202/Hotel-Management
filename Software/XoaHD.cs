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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrangChuQLKS;

namespace AppQuanLyKhachSan
{
    public partial class XoaHD : Form
    {
        public XoaHD()
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
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT * FROM HD_PTP WHERE MAHD LIKE @MAHD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAHD", "%" + MAHD + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;
        }

        private void QLHoaDon_Shown()
        {
            Database dt = new Database();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt.XoaHD();
            dataGridView1.AllowUserToAddRows = false;
            lamtron();
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
            string MAHD = textBox1.Text;
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM HOADON WHERE MAHD = @MAHD";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MAHD", MAHD);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Không có mã hoá đơn", "Thông báo");
                        return;
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "DELETE FROM HOADON WHERE MAHD = @MAHD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAHD", MAHD);
                cmd.ExecuteNonQuery();
            }
            textBox1.Clear();
            MessageBox.Show("Thành công", "Thông báo");
            QLHoaDon_Shown();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                var c1 = dataGridView1.Rows[row].Cells[0].Value?.ToString() ?? string.Empty;

                textBox1.Text = c1;
            }
        }
    }
}
