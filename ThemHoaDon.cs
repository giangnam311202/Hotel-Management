using AppQuanLyKhachSan.Class;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections;
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
    public partial class ThemHoaDon : Form
    {
        public ThemHoaDon()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "SELECT * FROM TT_ADDHOADON";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvInvoiceDetails.RowHeadersVisible = false;
                dgvInvoiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInvoiceDetails.DataSource = dt;
                dgvInvoiceDetails.AllowUserToAddRows = false;
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = "check value";
                checkBoxColumn.HeaderText = "";
                dgvInvoiceDetails.Columns.Insert(0, checkBoxColumn);
                lamtron();
                conn.Close();
            }
        }
        string MAHD = "";
        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void lamtron()
        {
            foreach (DataGridViewRow row in dgvInvoiceDetails.Rows)
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

        public void button4_Click(object sender, EventArgs e)
        {
            string TENKHACHHANG = txtCustomerName.Text;
            List<string> selectedMATPValues = new List<string>();

            for (int x = 0; x < dgvInvoiceDetails.Rows.Count; x++)
            {
                if (dgvInvoiceDetails.Rows[x].Cells[0].Value != null && !string.IsNullOrEmpty(dgvInvoiceDetails.Rows[x].Cells[0].Value.ToString()))
                {
                    bool isChecked = Convert.ToBoolean(dgvInvoiceDetails.Rows[x].Cells[0].Value.ToString());
                    if (isChecked)
                    {
                        selectedMATPValues.Add(dgvInvoiceDetails.Rows[x].Cells[2].Value.ToString());
                    }
                }
            }

            if (selectedMATPValues.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu thuê phòng để lập hóa đơn", "Thông báo");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "DECLARE @InsertedIDs TABLE (MAHD CHAR(6));" +
                                            "INSERT INTO HOADON (NGAYLAPHD, KHTHANHTOAN) " +
                                            "OUTPUT inserted.MAHD INTO @InsertedIDs(MAHD) " +
                                            "VALUES (@NGAYLAPHD, @KHTHANHTOAN);" +
                                            "SELECT MAHD FROM @InsertedIDs;";
                SqlCommand cmd1 = new SqlCommand(query, conn);
                cmd1.Parameters.AddWithValue("@NGAYLAPHD", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd1.Parameters.AddWithValue("@KHTHANHTOAN", TENKHACHHANG);

                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MAHD = reader["MAHD"].ToString();
                    }
                }
                conn.Close();
            }

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                for (int i = 0; i < selectedMATPValues.Count; i++)
                {
                    string query = "INSERT INTO CT_HOADON (MAHD, MAPTP) VALUES (@MAHD, @MAPTP" + i + ")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MAHD", MAHD);
                    cmd.Parameters.AddWithValue("@MAPTP" + i, selectedMATPValues[i]);
                    int row = cmd.ExecuteNonQuery();
                }
                conn.Close(); 
            }
            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "UPDATE PHONG SET TINHTRANG = N'Có sẵn' WHERE MAPHONG IN (SELECT MAPHONG FROM PHIEUTHUEPHONG WHERE MAPTP IN (";
                for (int i = 0; i < selectedMATPValues.Count; i++)
                {
                    query += "@MAPTP" + i;
                    if (i < selectedMATPValues.Count - 1)
                    {
                        query += ", ";
                    }
                }
                query += "))";

                // Tạo lệnh SQL
                SqlCommand cmd = new SqlCommand(query, conn);

                // Thêm các giá trị tham số
                for (int i = 0; i < selectedMATPValues.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@MAPTP" + i, selectedMATPValues[i]);
                }

                // Thực thi câu truy vấn
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Thành công", "Thông báo");
            this.Close();
        }

        public void dgvInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                var press = Convert.ToBoolean(dgvInvoiceDetails.Rows[e.RowIndex].Cells["check value"].Value);
                if (press)
                {
                    dgvInvoiceDetails.Rows[e.RowIndex].Cells["check value"].Value = false;
                    dgvInvoiceDetails.EndEdit();
                }
                else
                {
                    dgvInvoiceDetails.Rows[e.RowIndex].Cells["check value"].Value = true;
                    dgvInvoiceDetails.EndEdit();
                }
            }
            CHITIETPTP();
        }

        public void CHITIETPTP()
        {
            List<string> selectedMATPValues = new List<string>();

            for (int x = 0; x < dgvInvoiceDetails.Rows.Count; x++)
            {
                if (dgvInvoiceDetails.Rows[x].Cells[0].Value != null && !string.IsNullOrEmpty(dgvInvoiceDetails.Rows[x].Cells[0].Value.ToString()))
                {
                    bool isChecked = Convert.ToBoolean(dgvInvoiceDetails.Rows[x].Cells[0].Value.ToString());
                    if (isChecked)
                    {
                        selectedMATPValues.Add(dgvInvoiceDetails.Rows[x].Cells[2].Value.ToString());
                    }
                }
            }

            if (selectedMATPValues.Count == 0)
            {
                dataGridView1.DataSource = null;
                textBox2.Clear();
                return;
            }

            string query = "SELECT * FROM PTP_CHITIETDICHVU WHERE MAPTP IN (";

            for (int i = 0; i < selectedMATPValues.Count; i++)
            {
                query += "@MAPTP" + i;
                if (i < selectedMATPValues.Count - 1)
                {
                    query += ",";
                }
            }
            query += ")";

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                for (int i = 0; i < selectedMATPValues.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@MAPTP" + i, selectedMATPValues[i]);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = dt;
                conn.Close();
                float Thanhtien = 0;
                for (int i = 0; i < selectedMATPValues.Count; i++)
                {
                    Thanhtien += TinhThanhTien(selectedMATPValues[i]);
                }
                string DG = Convert.ToString(Thanhtien);
                textBox2.Text = DG;
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MAPTP = textBox1.Text;

            using (SqlConnection conn = new SqlConnection(Database.connection))
            {
                string query = "SELECT * FROM TT_ADDHOADON WHERE MAPTP LIKE @MAPTP";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAPTP", "%" + MAPTP + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvInvoiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvInvoiceDetails.DataSource = dt;
                lamtron();
            }
        }

        public static float TinhThanhTien(string maptp)
        {
            using (SqlConnection connection = new SqlConnection(Database.connection))
            {
                connection.Open();
                // TINH SONGAYTHUE
                DateTime now = DateTime.Now;
                DateTime ngayLapPhieu;
                using (SqlCommand cmd = new SqlCommand("SELECT NGAYLAPPHIEU FROM PHIEUTHUEPHONG WHERE MAPTP = @MAPTP", connection))
                {
                    cmd.Parameters.AddWithValue("@MAPTP", maptp);
                    ngayLapPhieu = (DateTime)cmd.ExecuteScalar();
                }
                TimeSpan x = now - ngayLapPhieu;
                int songaythue = x.Days;

                if (songaythue == 0)
                {
                    songaythue += 1;
                }

                // LAY TYLEPHUTHU
                float tilePhuThu;
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT (1 + TILEPHUTHU) FROM TILEPHUTHU WHERE TILEPHUTHU.KHACHHANGTHU = " +
                    "(SELECT COUNT(*) FROM CHITIETPTP WHERE MAPTP = @MAPTP)", connection))
                {
                    cmd.Parameters.AddWithValue("@MAPTP", maptp);
                    tilePhuThu = Convert.ToSingle(cmd.ExecuteScalar());
                    if (tilePhuThu == 0)
                    {
                        tilePhuThu = 1;
                    }
                }

                // LAY DONGIA_LOAIPHONG
                float donGiaLP;
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT lp.DONGIA FROM LOAIPHONG lp " +
                    "JOIN PHONG p ON p.MALP = lp.MALP " +
                    "JOIN PHIEUTHUEPHONG ptp ON ptp.MAPHONG = p.MAPHONG " +
                    "WHERE ptp.MAPTP = @MAPTP", connection))
                {
                    cmd.Parameters.AddWithValue("@MAPTP", maptp);
                    donGiaLP = Convert.ToSingle(cmd.ExecuteScalar());
                }

                // LAY HESOPHUTHU
                float hesoPhuThu;
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT CASE WHEN 'NN' IN (SELECT lkh.MALKH FROM LOAIKH lkh " +
                    "JOIN CHITIETPTP ctptp ON lkh.MALKH = ctptp.MALKH " +
                    "WHERE ctptp.MAPTP = @MAPTP) THEN 1.25 ELSE 1 END", connection))
                {
                    cmd.Parameters.AddWithValue("@MAPTP", maptp);
                    hesoPhuThu = Convert.ToSingle(cmd.ExecuteScalar());
                }

                // LAY DONGIA_CT_DANGKYDV
                float donGiaDV;
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT ISNULL(SUM(cd.DONGIA), 0) FROM CT_DANGKYDV cd WHERE cd.MAPTP = @MAPTP", connection))
                {
                    cmd.Parameters.AddWithValue("@MAPTP", maptp);
                    donGiaDV = Convert.ToSingle(cmd.ExecuteScalar());
                }

                // TINH THANHTIEN
                float thanhTien = (songaythue * donGiaLP * tilePhuThu * hesoPhuThu) + donGiaDV;

                return thanhTien;
            }
        }
    }
}
