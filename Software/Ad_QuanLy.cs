using AppQuanLyKhachSan;

namespace TrangChuQLKS
{
    public partial class Ad_QuanLy : Form
    {
        public Ad_QuanLy()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Ad_QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Phong_click(object sender, EventArgs e)
        {
            this.Hide();
            QLPhong qLPhong = new QLPhong();
            qLPhong.ShowDialog();
            this.Close();
        }

        private void ThuePhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThuePhong tphong = new ThuePhong();
            tphong.ShowDialog();
            this.Close();
        }

        private void Dichvu_click(object sender, EventArgs e)
        {
            this.Hide();
            QLDichVu qtdv = new QLDichVu();
            qtdv.ShowDialog();
            this.Close();
        }

        private void Doangthu_click(object sender, EventArgs e)
        {
            this.Hide();
            QLDoanhThu qtdv = new QLDoanhThu();
            qtdv.ShowDialog();
            this.Close();
        }

        private void Hoadon_click(object sender, EventArgs e)
        {
            this.Hide();
            QLHoaDon qLHoaDon = new QLHoaDon();
            qLHoaDon.ShowDialog();
            this.Close();
        }

        public void Dangxuat_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ad_QuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Click(object sender, EventArgs e)
        {
            this.Hide();
            KHACHTOIDA kHACHTOIDA = new KHACHTOIDA();
            kHACHTOIDA.ShowDialog();
            this.Show();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLLoaiKhachHang phong = new QLLoaiKhachHang();
            phong.ShowDialog();
            this.Show();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            this.Hide();
            QLLoaiPhong lPhong = new QLLoaiPhong();
            lPhong.ShowDialog();
            this.Show();
        }

        private void panel14_Paint(object sender, EventArgs e)
        {
            this.Hide();
            XoaPTP xoaPTP = new XoaPTP();
            xoaPTP.ShowDialog();
            this.Show();
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            this.Hide();
            XoaHD xoaHD = new XoaHD();
            xoaHD.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
