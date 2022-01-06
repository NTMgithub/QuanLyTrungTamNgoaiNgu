using BUS;
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
    public partial class fmDanhSachThiSinh : Form
    {
        B_KhoaThi b_KhoaThi = new B_KhoaThi();
        B_XepPhongThi b_XepPhongThi = new B_XepPhongThi();
        B_DSThiSinhTrongPhongThi b_DSThiSinhTrongPhongThi = new B_DSThiSinhTrongPhongThi();

        public fmDanhSachThiSinh()
        {
            InitializeComponent();

            comboBoxKhoa.ValueMember = "MAKHOATHI";
            LoadComboBoxKhoaThi();
            //comboBoxKhoa.SelectedIndex = 0;
            LoadComboBoxPhong();
            HienThiDanhSach();
        }

        
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
            /*int makhoathi = Convert.ToInt32(comboBoxKhoa.SelectedValue.ToString());
            string maphongthi = comboBoxPhong.SelectedValue.ToString();
            dataGridViewDanhSachThiSinh.AutoGenerateColumns = false;
            dataGridViewDanhSachThiSinh.DataSource = b_DSThiSinhTrongPhongThi.GetDSThiSinhTrongPhongThies(makhoathi, maphongthi);*/

            dataGridViewDanhSachThiSinh.DataSource = null;
            if (comboBoxPhong.SelectedValue != null)
            {

                int makhoathi = int.Parse(comboBoxKhoa.SelectedValue.ToString());
                string maphongthi = comboBoxPhong.SelectedValue.ToString();
                dataGridViewDanhSachThiSinh.AutoGenerateColumns = false;
                dataGridViewDanhSachThiSinh.DataSource = b_DSThiSinhTrongPhongThi.GetDSThiSinhTrongPhongThies(makhoathi, maphongthi);
                dataGridViewDanhSachThiSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDanhSachThiSinh.AllowUserToAddRows = false;
                //Để có thể check checkbox
                for (int i = 0; i <= dataGridViewDanhSachThiSinh.Rows.Count - 1; i++)
                {
                    dataGridViewDanhSachThiSinh.Rows[i].Cells[0].Value = false;

                }
            }
        }    

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiComboPhong();

        }
        private void comboBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDanhSachThiSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPhong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
    }
}
