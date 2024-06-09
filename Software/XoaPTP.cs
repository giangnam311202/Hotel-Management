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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppQuanLyKhachSan
{
    public partial class XoaPTP : Form
    {
        public XoaPTP()
        {
            InitializeComponent();
            ThuePhong_Shown();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string TENKHACHHANG = textBox2.Text;
            string MAPHONG = textBox3.Text;
            string query = "SELECT * FROM QL_PHIEUTHUEPHONG WHERE TENKHACHHANG LIKE @TENKHACHHANG AND MAPHONG LIKE @MAPHONG";
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENKHACHHANG", "%" + TENKHACHHANG + "%");
                cmd.Parameters.AddWithValue("@MAPHONG", "%" + MAPHONG + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                conn.Close();
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;
        }

        private void DataFilter(object sender, EventArgs e)
        {
            string MAPTP = textBox2.Text;
            string MAPHONG = textBox3.Text;
            string query = "SELECT * FROM PTP_CT_HD WHERE MAPTP LIKE @MAPTP AND MAPHONG LIKE @MAPHONG";
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPTP", "%" + MAPTP + "%");
                cmd.Parameters.AddWithValue("@MAPHONG", "%" + MAPHONG + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                conn.Close();
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dataTable;
        }

        public void lamtron()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string DG = row.Cells[4].Value.ToString();
                DG = DG.TrimEnd('0');
                if (DG.EndsWith(","))
                {
                    DG = DG.TrimEnd(',');
                }
                row.Cells[4].Value = DG;
            }
            return;
        }
        private void ThuePhong_Shown()
        {
            Database database = new Database();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = database.XOAPTP();
            dataGridView1.AllowUserToAddRows = false;
            lamtron();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0 && row < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[row].Cells.Count > 2)
                {
                    string c1 = dataGridView1.Rows[row].Cells[0].Value?.ToString() ?? string.Empty;
                    string c2 = dataGridView1.Rows[row].Cells[1].Value?.ToString() ?? string.Empty;
                    textBox2.Text = c1;
                    textBox3.Text = c2;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
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
            string MAPTP = textBox2.Text;
            using(SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "DELETE FROM PHIEUTHUEPHONG WHERE MAPTP = @MAPTP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPTP", MAPTP);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            ThuePhong_Shown();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
