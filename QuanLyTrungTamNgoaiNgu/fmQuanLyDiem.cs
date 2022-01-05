using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace QuanLyTrungTamNgoaiNgu
{
    public partial class fmQuanLyDiem : Form
    {
        B_KhoaThi B_KhoaThi = new B_KhoaThi();
        B_DSThiSinhTrongPhongThi B_DSThiSinhTrongPhongThi = new B_DSThiSinhTrongPhongThi();
        public fmQuanLyDiem()
        {
            InitializeComponent();
            LoadComboboxKhoaThi();
        }

        private void LoadComboboxKhoaThi()
        {
            comboBoxKhoa.DataSource = B_KhoaThi.GetKhoaThis();
            comboBoxKhoa.DisplayMember = "TENKHOATHI";
            comboBoxKhoa.ValueMember = "MAKHOATHI";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makhoathi = comboBoxKhoa.SelectedValue.ToString();
            //  comboBoxPhong.DataSource = B_PhongThi.GetPhongThis(makhoathi);
            comboBoxPhong.DisplayMember = "MAPHONGTHI";
            comboBoxPhong.ValueMember = "MAPHONGTHI";
        }

        private void comboBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int makhoathi = int.Parse(comboBoxKhoa.SelectedValue.ToString());
            string maphongthi = comboBoxPhong.SelectedValue.ToString();
            dataGridViewbangDiemThiSinh.DataSource = B_DSThiSinhTrongPhongThi.GetDSThiSinhTrongPhongThies(makhoathi, maphongthi);
        }
    }
}
