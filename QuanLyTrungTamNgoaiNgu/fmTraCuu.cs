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
        B_KhoaThi b_KhoaThi = new B_KhoaThi();
        B_XepPhongThi b_XepPhongThi = new B_XepPhongThi();
        public fmTraCuu()
        {
            InitializeComponent();
            LoadComboBoxKhoaThi();
            LoadComboBoxPhong();
        }

        //Cau 18
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
            Regex regex = new Regex(@"[""!#$%&'()*+,-./:;<=>?@[\\\]^_`{|}~0-9]");

            if (regex.IsMatch(textBoxHoTen.Text))
            {
                return false;
            }
            Regex regexNumber = new Regex("[a-z]");
            if (regexNumber.IsMatch(textBoxSDT.Text))
            {
                return false;
            }

            return true;
        }

        // Cau 17
        public void LoadComboBoxKhoaThi()
        {
            comboBoxKhoa.DataSource = b_KhoaThi.GetKhoaThis();
            comboBoxKhoa.DisplayMember = "TENKHOATHI";
            comboBoxKhoa.ValueMember = "MAKHOATHI";

        }

        public void LoadComboBoxPhong()
        {
            string makhoathi = comboBoxKhoa.SelectedValue.ToString();
            comboBoxPhong.DisplayMember = "MAPHONGTHI";
            comboBoxPhong.ValueMember = "MAPHONGTHI";
        }
        public void HienThiComboPhong()
        {
            string makhoathi = comboBoxKhoa.SelectedValue.ToString();
            if (!makhoathi.Equals("System.Data.Entity.DynamicProxies.KhoaThi_87305566F1A93C290A8622FD22538AF5E789C925966D751F28BBB24AC85315ED"))
            {

                comboBoxPhong.DataSource = b_XepPhongThi.GetPhongThis(makhoathi);
                comboBoxPhong.DisplayMember = "MAPHONGTHI";
                comboBoxPhong.ValueMember = "MAPHONGTHI";
            }
        }
        public void HienThiDanhSach()
        {
            dataGridView1.DataSource = null;
            if (comboBoxPhong.SelectedValue != null)
            {
                int makhoathi = int.Parse(comboBoxKhoa.SelectedValue.ToString());
                string maphongthi = comboBoxPhong.SelectedValue.ToString();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = B_DSThiSinhTrongPhongThi.GetDSThiSinhTrongPhongThies(makhoathi, maphongthi);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false;
                //Để có thể check checkbox
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = false;

                }
            }
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

        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiComboPhong();
        }

        private void comboBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
