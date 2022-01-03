using System;
using System.Windows.Forms;
using BUS;
using DAL;




namespace QuanLyTrungTamNgoaiNgu
{
    public partial class fmDangKyThi : Form
    {
        B_DangKyThi b_DangKyThi = new B_DangKyThi();
        public fmDangKyThi()
        {
            InitializeComponent();
            LoadDanhSachThiSinhDangKy();
        }
        public ThiSinhDK createThiSinh()
        {
            String cmnd = textBoxCMND.Text;
            String trinhdo = comboBoxTrinhDo.SelectedText;
            String hoten = textBoxHoTen.Text;
            String gioitinh = comboBoxGioiTinh.SelectedText;
            String sdt = textBoxSoDienThoai.Text;
            String email = textBoxEmail.Text;
            DateTime ngayDK = DateTime.Parse(dateTimePickerNgayDK.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
            DateTime ngaysinh = DateTime.Parse(dateTimePickerNgaySinh.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
            ThiSinhDK thiSinhDK = new ThiSinhDK();


            return thiSinhDK;
        }


        private void LoadDanhSachThiSinhDangKy()
        {
            dataGridView_thiSinhDK.DataSource = b_DangKyThi.GetThiSinhDKs();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fmDangKyThi_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
