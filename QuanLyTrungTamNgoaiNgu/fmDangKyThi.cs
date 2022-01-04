using System;
using System.Drawing;
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
        public void createThiSinh()
        {
            if (!String.IsNullOrWhiteSpace(textBoxHoTen.Text))
            {
                if (!String.IsNullOrWhiteSpace(textBoxCMND.Text))
                {
                    if (!String.IsNullOrWhiteSpace(textBoxEmail.Text))
                    {
                        if (!String.IsNullOrWhiteSpace(textBoxSoDienThoai.Text))
                        {
                            String cmnd = textBoxCMND.Text;
                            String trinhdo = comboBoxTrinhDo.SelectedItem.ToString();
                            String hoten = textBoxHoTen.Text;
                            String gioitinh = comboBoxGioiTinh.SelectedItem.ToString();
                            String sdt = textBoxSoDienThoai.Text;
                            String email = textBoxEmail.Text;
                            DateTime ngayDK = DateTime.Parse(dateTimePickerNgayDK.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                            DateTime ngaysinh = DateTime.Parse(dateTimePickerNgaySinh.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));

                            ThiSinhDK thiSinhDK = new ThiSinhDK();
                            thiSinhDK.CMND = cmnd;
                            thiSinhDK.TRINHDO = trinhdo;
                            thiSinhDK.HOTEN = hoten;
                            thiSinhDK.GIOITINH = gioitinh;
                            thiSinhDK.SDT = sdt;
                            thiSinhDK.EMAIL = email;
                            thiSinhDK.NGAYDK = ngayDK;
                            thiSinhDK.NGAYSINH = ngaysinh;

                            if (b_DangKyThi.ThemThiSinh(thiSinhDK))
                            {
                                MessageBox.Show("Thêm thành công", "Thông báo!");
                                LoadDanhSachThiSinhDangKy();
                                clearFields();
                                textBoxHoTen.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Thêm KHÔNG thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo!");
                            textBoxHoTen.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập email!", "Thông báo!");
                        textBoxHoTen.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập CMND!", "Thông báo!");
                    textBoxHoTen.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo!");
                textBoxHoTen.Focus();
            }



        }

        private void ThemThiSinh()
        {
            createThiSinh();
        }

        private void clearFields()
        {
            textBoxHoTen.Text = "";
            textBoxCMND.Text = "";
            textBoxEmail.Text = "";
            textBoxSoDienThoai.Text = "";
        }

        private void LoadDanhSachThiSinhDangKy()
        {
            dataGridView_thiSinhDK.AutoGenerateColumns = false;
            dataGridView_thiSinhDK.DataSource = b_DangKyThi.GetThiSinhDKs();

            comboBoxGioiTinh.SelectedIndex = 0;
            comboBoxTrinhDo.SelectedIndex = 0;
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

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            ThemThiSinh();
        }



        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel5.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }

}
