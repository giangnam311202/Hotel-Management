using AppQuanLyKhachSan;

namespace TrangChuQLKS
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void QL_click(object sender, EventArgs e)
        {
            this.Hide();
            Ad_QuanLy ad_QuanLy = new Ad_QuanLy();
            ad_QuanLy.ShowDialog();
            this.Show();
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
