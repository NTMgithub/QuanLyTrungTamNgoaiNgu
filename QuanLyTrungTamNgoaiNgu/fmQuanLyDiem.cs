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
            void chkItems_CheckedChanged(object sender, EventArgs e)
            {
                foreach (DataGridViewRow row in dataGridViewbangDiemThiSinh.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (chk.Value == chk.FalseValue || chk.Value == null)
                    {
                        chk.Value = chk.TrueValue;
                    }
                    else
                    {
                        chk.Value = chk.FalseValue;
                    }

                }
                dataGridViewbangDiemThiSinh.EndEdit();
            }
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
            textBoxDiemDoc.Text = "";
            textBoxDiemNghe.Text = "";
            textBoxDiemNoi.Text = "";
            textBoxDiemViet.Text = "";
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
        }

        private void LoadDanhSachThiSinh()
        {
            dataGridViewbangDiemThiSinh.DataSource = null;
            if (comboBoxPhong.SelectedValue != null)
            {

                int makhoathi = int.Parse(comboBoxKhoa.SelectedValue.ToString());
                string maphongthi = comboBoxPhong.SelectedValue.ToString();
                dataGridViewbangDiemThiSinh.AutoGenerateColumns = false;
                dataGridViewbangDiemThiSinh.DataSource = B_DSThiSinhTrongPhongThi.GetDSThiSinhTrongPhongThies(makhoathi, maphongthi);
                dataGridViewbangDiemThiSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewbangDiemThiSinh.AllowUserToAddRows = false;
                //Để có thể check checkbox
                for (int i = 0; i <= dataGridViewbangDiemThiSinh.Rows.Count - 1; i++)
                {
                    dataGridViewbangDiemThiSinh.Rows[i].Cells[0].Value = false;

                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridViewbangDiemThiSinh.Rows.Count - 1; i++)
            {
                bool checkedCell = (bool)dataGridViewbangDiemThiSinh.Rows[i].Cells[0].Value;
                if (checkedCell == true)
                {
                    int madk = Convert.ToInt32(dataGridViewbangDiemThiSinh.Rows[i].Cells[1].Value.ToString());
                    DSThiSinhTrongPhongThi thisinh = new DSThiSinhTrongPhongThi();
                    thisinh.DIEMDOC = textBoxDiemDoc.Text;
                    thisinh.DIEMNGHE = textBoxDiemNghe.Text;
                    thisinh.DIEMNOI = textBoxDiemNoi.Text;
                    thisinh.DIEMVIET = textBoxDiemViet.Text;
                    B_DSThiSinhTrongPhongThi.UpdateDiem(thisinh, madk);
                }
            }
            LoadDanhSachThiSinh();
        }

        // Cau18:
        public void HienThiDanhSachThiSinhCoDiem()
        {
                string TenHoacSdt = textBoxTimKiem.Text;
                dataGridViewbangDiemThiSinh.AutoGenerateColumns = false;
                dataGridViewbangDiemThiSinh.DataSource = B_DSThiSinhTrongPhongThi.GetDSThiSinhCoDiemes(TenHoacSdt);
                dataGridViewbangDiemThiSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewbangDiemThiSinh.AllowUserToAddRows = false;
        }

        private void dataGridViewbangDiemThiSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadDanhSachThiSinh();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            HienThiDanhSachThiSinhCoDiem();
        }
    }
}
