using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class fmTrangChu : Form
    {
        public fmTrangChu()
        {
            InitializeComponent();
        }

        private void fmTrangChu_Load(object sender, EventArgs e)
        {
            //labelTime.Text = DateTime.Now.ToLongTimeString();

            //labelDate.Text = DateTime.Now.ToString("d");
        }

        public void HienThiFormCon(Form formName)
        {
            this.Hide();
            formName.ShowDialog();
            this.Show();
        }

        private void btnTour_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmTraCuu fmTC = new fmTraCuu();
            HienThiFormCon(fmTC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmDangKyThi fmDKT = new fmDangKyThi();
            HienThiFormCon(fmDKT);
        }

        private void btnLapPhongThi_Click(object sender, EventArgs e)
        {
            fmLapPhongThi fmLPT = new fmLapPhongThi();
            HienThiFormCon(fmLPT);
        }

        private void btnXepPhongThi_Click(object sender, EventArgs e)
        {
            fmXepPhongThi fmXPT = new fmXepPhongThi();
            HienThiFormCon(fmXPT);
        }

        private void btnQuanLyDiem_Click(object sender, EventArgs e)
        {
            fmQuanLyDiem fmQLD = new fmQuanLyDiem();
            HienThiFormCon(fmQLD);
        }

        private void btnXepGiaoVien_Click(object sender, EventArgs e)
        {
            fmXepGiaoVien fmXGV = new fmXepGiaoVien();
            HienThiFormCon(fmXGV);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fmLapKhoaThi fmLKT = new fmLapKhoaThi();
            HienThiFormCon(fmLKT);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDanhSachThiSinh_Click(object sender, EventArgs e)
        {
            fmDanhSachThiSinh fmDSTS = new fmDanhSachThiSinh();
            HienThiFormCon(fmDSTS);
        }
    }
}
