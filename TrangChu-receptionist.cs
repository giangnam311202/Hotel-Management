using AppQuanLyKhachSan;

namespace TrangChuQLKS
{
    public partial class TrangChu_receptionist : Form
    {
        public TrangChu_receptionist()
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

        private void Dichvu_click(object sender, EventArgs e)
        {
            this.Hide();
            QLDichVu_receptionist qtdv = new QLDichVu_receptionist();
            qtdv.ShowDialog();
            this.Close();
        }

        private void Hoadon_click(object sender, EventArgs e)
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

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
