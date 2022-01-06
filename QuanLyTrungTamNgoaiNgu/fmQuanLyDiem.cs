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
        B_XepPhongThi B_XepPhongThi = new B_XepPhongThi();
        public fmQuanLyDiem()
        {
            InitializeComponent();
            LoadComboboxKhoaThi();


            LoadComboboxPhongThi();
        }

        private void LoadComboboxPhongThi()
        {
            string makhoathi = comboBoxKhoa.SelectedValue.ToString();
            // comboBoxPhong.DataSource = B_XepPhongThi.GetPhongThis(makhoathi);
            comboBoxPhong.DisplayMember = "MAPHONGTHI";
            comboBoxPhong.ValueMember = "MAPHONGTHI";

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
            if (!makhoathi.Equals("System.Data.Entity.DynamicProxies.KhoaThi_87305566F1A93C290A8622FD22538AF5E789C925966D751F28BBB24AC85315ED"))
            {
                comboBoxPhong.DataSource = B_XepPhongThi.GetPhongThis(makhoathi);
                comboBoxPhong.DisplayMember = "MAPHONGTHI";
                comboBoxPhong.ValueMember = "MAPHONGTHI";
            }


        }

        private void comboBoxPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhSachThiSinh();
        }

        private void LoadDanhSachThiSinh()
        {
            int makhoathi = int.Parse(comboBoxKhoa.SelectedValue.ToString());
            string maphongthi = comboBoxPhong.SelectedValue.ToString();

            dataGridViewbangDiemThiSinh.AutoGenerateColumns = false;
            dataGridViewbangDiemThiSinh.DataSource = B_DSThiSinhTrongPhongThi.GetDSThiSinhTrongPhongThies(makhoathi, maphongthi);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            DSThiSinhTrongPhongThi thisinh = new DSThiSinhTrongPhongThi();
            thisinh.DIEMDOC = textBoxDiemDoc.Text;
            thisinh.DIEMNGHE = textBoxDiemNghe.Text;
            thisinh.DIEMNOI = textBoxDiemNoi.Text;
            thisinh.DIEMVIET = textBoxDiemViet.Text;
            B_DSThiSinhTrongPhongThi.UpdateDiem(thisinh, 9);
            LoadDanhSachThiSinh();


        }
    }
}
