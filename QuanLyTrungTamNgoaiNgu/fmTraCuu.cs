using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class fmTraCuu : Form
    {
        B_DSThiSinhTrongPhongThi B_DSThiSinhTrongPhongThi = new B_DSThiSinhTrongPhongThi();
        public fmTraCuu()
        {
            InitializeComponent();
        }

        public void HienThiDanhSachThiSinh_TheoTenHoacSDT()
        {
            
                if (textBoxSDT.Text.Length != 0 && textBoxHoTen.Text.Length != 0)
                {
                    HienThiDanhSachThiSinh();
                }
                else
                {
                    if(KiemTraRangBuoc()==true)
                    {
                        string TenHoacSdt = "";
                        if (textBoxSDT.Text.Length == 0)
                            TenHoacSdt = textBoxHoTen.Text;
                        if (textBoxHoTen.Text.Length == 0)
                            TenHoacSdt = textBoxSDT.Text;

                        dataGridViewbangDanhSachThiSinh.AutoGenerateColumns = false;
                        dataGridViewbangDanhSachThiSinh.DataSource = B_DSThiSinhTrongPhongThi.GetDSThiSinh_TheoTenVaSDTs(TenHoacSdt);
                        dataGridViewbangDanhSachThiSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewbangDanhSachThiSinh.AllowUserToAddRows = false;
                    }    
                }
               
        }

        public void HienThiDanhSachThiSinh()
        {
            string hoten = textBoxHoTen.Text;
            string sdt = textBoxSDT.Text;
            dataGridViewbangDanhSachThiSinh.AutoGenerateColumns = false;
            dataGridViewbangDanhSachThiSinh.DataSource = B_DSThiSinhTrongPhongThi.GetDSThiSinhs(hoten, sdt);
            dataGridViewbangDanhSachThiSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewbangDanhSachThiSinh.AllowUserToAddRows = false;
        }
        bool KiemTraRangBuoc()
        {
            //Kiểm tra kí tự đặc biệt và số
            Regex regex = new Regex(@"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]");

            if (regex.IsMatch(textBoxHoTen.Text))
            {
                //MessageBox.Show("Họ tên không được có số và kí tự đặc biệt!", "Thông báo");
                //textBoxHoTen.Focus();
                return false;
            }
            Regex regexNumber = new Regex("[a-z]");
            if (regexNumber.IsMatch(textBoxSDT.Text))
            {
                //MessageBox.Show("Số điện thoại ở dạng số", "Thông báo");
                //textBoxSDT.Focus();
                return false;
            }

            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewbangDiemThiSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HienThiDanhSachThiSinh_TheoTenHoacSDT();
        }

        private void textBoxHoTen_TextChanged(object sender, EventArgs e)
        {
            HienThiDanhSachThiSinh_TheoTenHoacSDT();
        }

        private void labelTongSoThiSinhChuaCoPhongThi_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_TheoTenVaSDT_Click(object sender, EventArgs e)
        {
            
        }
    }
}
