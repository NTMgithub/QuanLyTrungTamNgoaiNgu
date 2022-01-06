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
    public partial class fmTimKiemThiSinhCoDiem : Form
    {
        B_DSThiSinhTrongPhongThi B_DSThiSinhTrongPhongThi = new B_DSThiSinhTrongPhongThi();
        public fmTimKiemThiSinhCoDiem()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachThiSinhCoDiem()
        {
            
                string hoten = textBoxHoTen.Text;
                string sdt = (String)textBoxSoDienThoai.Text;
                dataGridViewbangDiemThiSinh.AutoGenerateColumns = false;
                dataGridViewbangDiemThiSinh.DataSource = B_DSThiSinhTrongPhongThi.GetDSThiSinhCoDiemes(sdt);
                
        }
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDanhSachThiSinhCoDiem();
        }
    }
}
