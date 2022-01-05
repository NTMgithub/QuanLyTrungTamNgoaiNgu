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
    public partial class fmLapKhoaThi : Form
    {
        B_KhoaThi B_KhoaThi = new B_KhoaThi();
        public fmLapKhoaThi()
        {
            InitializeComponent();
            LoadDSKhoaThi();
        }

        private void LoadDSKhoaThi()
        {
            dataGridViewKhoaThi.AutoGenerateColumns = false;
            dataGridViewKhoaThi.DataSource = B_KhoaThi.GetKhoaThis();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            themKhoaThi();
        }

        private void themKhoaThi()
        {
            KhoaThi khoaThi = createKhoaThi();
            if (khoaThi != null)
            {
                B_KhoaThi.ThemKhoaThi(khoaThi);
                LoadDSKhoaThi();
            }
        }

        private KhoaThi createKhoaThi()
        {
            if (!String.IsNullOrWhiteSpace(textBox_TenKhoaThi.Text))
            {
                String tenKhoaThi = textBox_TenKhoaThi.Text;
                DateTime ngayThi = DateTime.Parse(dateTimePickerNgayThi.Value.Date.ToString("yyyy-MM-dd hh:mm:ss.ss"));
                KhoaThi khoaThi = new KhoaThi();
                khoaThi.TENKHOATHI = tenKhoaThi;
                khoaThi.NGAYTHI = ngayThi;
                return khoaThi;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khoá thi!", "Thông báo!");
                textBox_TenKhoaThi.Focus();
                return null;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
