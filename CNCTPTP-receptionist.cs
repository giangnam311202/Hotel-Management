using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControlzEx.Standard.NativeMethods;
using TrangChuQLKS;
using System.Data.SqlClient;
using AppQuanLyKhachSan.Class;
using System.Windows.Documents;

namespace AppQuanLyKhachSan
{
    public partial class CNCTPTP_receptionist : Form
    {
        string MAPTP;
        string MAPHONG;
        DateTime dateTime;
        string KHACHHANGTHU;
        string TENKHACHHANG;
        string DIACHI;
        string CMND;
        string MALKH;
        public CNCTPTP_receptionist(string maptp, string maphong, DateTime ngaylay, string khthu, string ten, string dc, string cmnd, string mALKH)
        {
            InitializeComponent();
            MAPTP = maptp;
            MAPHONG = maphong;
            dateTime = ngaylay;
            KHACHHANGTHU = khthu;
            TENKHACHHANG = ten;
            DIACHI = dc;
            CMND = cmnd;
            MALKH = mALKH;
            Database database = new Database();
            DataTable table = database.LOAIKHACHHANG();
            comboBox3.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                var cellValue = row[0].ToString();
                if (!string.IsNullOrEmpty(cellValue) && !comboBox3.Items.Contains(cellValue))
                {
                    comboBox3.Items.Add(cellValue);
                }
            }
            textBox8.KeyPress += new KeyPressEventHandler(CMND_KeyPress); // Thêm sự kiện KeyPress cho textBox8
            CNCTPTP_Show();
        }

        private void CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chỉ cho phép nhập số
            }

            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.Length >= 12)
            {
                e.Handled = true; // Ngăn không cho nhập quá 12 ký tự
                if ((sender as TextBox).Text.Length == 12)
                {
                    MessageBox.Show("Số CMND phải là dãy 12 số", "Thông báo");
                }
            }
        }

        public void CNCTPTP_Show()
        {
            textBox10.Text = MAPTP;
            textBox1.Text = MAPHONG;
            dateTimePicker1.Value = dateTime;
            textBox9.Text = TENKHACHHANG;
            textBox8.Text = CMND;
            textBox7.Text = DIACHI;
            comboBox3.Text = MALKH;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string TKH = textBox9.Text;
            string DC = textBox7.Text;
            string CD = textBox8.Text;
            string LKH = comboBox3.Text;

            if (TKH == "")
            {
                MessageBox.Show("Tên khách hàng không được trống", "Thông báo");
                return;
            }
            if (CD.Length != 12)
            {
                MessageBox.Show("Số CMND phải là dãy 12 số", "Thông báo");
                return;
            }

            using (SqlConnection conn =  new SqlConnection(Database.connection))
            {
                conn.Open();
                string query = "UPDATE CHITIETPTP SET TENKHACHHANG = @TENKHACHHANG, DIACHI = @DIACHI, CMND = @CMND,  MALKH = @MALKH " + 
                               "WHERE MAPTP = @MAPTP AND KHACHHANGTHU = @KHACHHANGTHU";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENKHACHHANG", TKH);
                cmd.Parameters.AddWithValue("@DIACHI", DC);
                cmd.Parameters.AddWithValue("@CMND", CD);
                cmd.Parameters.AddWithValue("@MAPTP", MAPTP);
                cmd.Parameters.AddWithValue("@KHACHHANGTHU", KHACHHANGTHU);
                cmd.Parameters.AddWithValue("@MALKH", LKH);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Thành công", "Thông báo");
            this.Close();
        }
    }
}
