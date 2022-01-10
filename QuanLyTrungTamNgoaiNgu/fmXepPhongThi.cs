using BUS;
using DAL;
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
    public partial class fmXepPhongThi : Form
    {
        B_XepPhongThi b_XepPhongThi = new B_XepPhongThi();
        B_KhoaThi b_KhoaThi = new B_KhoaThi();
        D_XepPhongThi d_XepPhongThi = new D_XepPhongThi();
        //int maKhoaThi = 1;
        public fmXepPhongThi()
        {
            InitializeComponent();

            HienThiComboKhoaThi();
            comboBoxTrinhDo.SelectedIndex = 0;

            HienThiDSThiSinhDaCoPhongThi();
            HienThiDSThiSinhChuaCoPhongThi();

        }


        public void HienThiDSThiSinhDaCoPhongThi()
        {
            dataGridView_DaCoPhongThi.AutoGenerateColumns = false;
            dataGridView_DaCoPhongThi.DataSource = b_XepPhongThi.GetDSThiSinhDaCoPhongThi();
        }

        public void HienThiComboKhoaThi()
        {
            comboKhoa.DataSource = b_KhoaThi.GetKhoaThis();
            comboKhoa.DisplayMember = "TENKHOATHI";
            comboKhoa.ValueMember = "MAKHOATHI";

        }

        public void HienThiDSThiSinhChuaCoPhongThi()
        {

            dataGridView_ChuaCoPhongThi.AutoGenerateColumns = false;
            dataGridView_ChuaCoPhongThi.DataSource = null;

            if (!comboKhoa.SelectedValue.ToString().Equals("System.Data.Entity.DynamicProxies.KhoaThi_87305566F1A93C290A8622FD22538AF5E789C925966D751F28BBB24AC85315ED"))
            {
                String trinhDoValue = comboBoxTrinhDo.SelectedItem.ToString();
                int maKhoaThi = Convert.ToInt32(comboKhoa.SelectedValue.ToString());
                List<KhoaThi> listKhoaThi = b_KhoaThi.GetNgayDangKyKhoaThi(maKhoaThi);

                foreach (var item in listKhoaThi)
                {
                    var datetimeNgayThi = item.NGAYTHI.Value;
                   
                    List<ThiSinhDK> listThiSinh = d_XepPhongThi.GetDSThiSinhChuaDangKy_TruocNgayThi(trinhDoValue);

                    foreach (var itemTS in listThiSinh.ToList())
                    {
                        var truoc5Ngay = (datetimeNgayThi - itemTS.NGAYDK).Days;
                        if (truoc5Ngay < 5)
                        {
                            listThiSinh.Remove(itemTS);
                        }

                    }

                    dataGridView_ChuaCoPhongThi.DataSource = listThiSinh;


                   

                }

            }


        }


        public void XepPhongThi()
        {
            if (dataGridView_ChuaCoPhongThi.Rows.Count != 0)
            {
                int maKhoaThi = Convert.ToInt32(comboKhoa.SelectedValue.ToString());
                String trinhDoValue = comboBoxTrinhDo.SelectedItem.ToString();

                double soLuongThiSinh = (double)dataGridView_ChuaCoPhongThi.Rows.Count;
                double soLuongToiDa = 35.0; //max 35 thí sinh 1 phòng
                int soLuongPhongCanTao = 0;

                
                if (soLuongThiSinh <= soLuongToiDa)
                {
                    soLuongPhongCanTao = 1;
                    
                }
                else
                {
                    double soLuongPhongCanTao_LayDu = soLuongThiSinh%soLuongToiDa;
                    if (soLuongPhongCanTao_LayDu != 0)
                    {
                        soLuongPhongCanTao = (int)(soLuongThiSinh/soLuongToiDa) + 1;
                    }
                    
                }
            
                //chia đều ra cho các phòng nếu số lượng thí sinh >35. Ví dụ: 40 thì mỗi phòng 20 thí sinh
                int soLuongThiSinhTrenMotPhong = 0;
                double soLuongThiSinhTrenMotPhong_LayDu = soLuongThiSinh%soLuongPhongCanTao;
                if (soLuongThiSinhTrenMotPhong_LayDu != 0)
                {
                    soLuongThiSinhTrenMotPhong = (int)((int)soLuongThiSinh / soLuongPhongCanTao) + 1;
                }
                else
                {
                    soLuongThiSinhTrenMotPhong = (int)((int)soLuongThiSinh / soLuongPhongCanTao);
                }
                 

                System.Diagnostics.Debug.WriteLine("Số lượng phòng cần tạo: " + soLuongPhongCanTao);
                System.Diagnostics.Debug.WriteLine("Số lượng thí sinh/phòng: " + soLuongThiSinhTrenMotPhong);
                int countLine = 1;
                int item1 = 0;
                //vòng for loop datagridview thí sinh chưa có phòng thi
                foreach (var rows in SplitDataGridView(dataGridView_ChuaCoPhongThi, soLuongThiSinhTrenMotPhong))
                {

                    item1++;
                    string maPhongThi = trinhDoValue + "P" + item1.ToString("00");

                    PhongThi objPhongThi = new PhongThi();
                    objPhongThi.MAKHOATHI = maKhoaThi;
                    objPhongThi.TRINHDO = trinhDoValue;
                    objPhongThi.MAPHONGTHI = maPhongThi;

                    if (b_XepPhongThi.ThemPhongThi(objPhongThi))
                    {
                        System.Diagnostics.Debug.WriteLine("Đã thêm phòng thi " + maPhongThi + "!");
                    }
                    //System.Diagnostics.Debug.WriteLine(trinhDoValue + "P" + item1.ToString("00")); //test

                    var sb = new StringBuilder();
                    string delimiter = "-";
                    foreach (var row in rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            sb.Append(cell.Value);
                            sb.Append(delimiter);
                        }
                        sb.Remove(sb.Length - delimiter.Length, delimiter.Length);
                        sb.AppendLine();
                    }

                    //MessageBox.Show(sb.ToString()); //test

                    int maDangKyRowInt = 0;
                    string[] delim = { Environment.NewLine, "\n" };
                    string[] lines = sb.ToString().Split(delim, StringSplitOptions.None);


                    foreach (string line in lines)
                    {

                        string maDangKyRow = line.Split('-')[0]; //lấy mã đăng ký từ stringbuilder line
                        if (int.TryParse(maDangKyRow, out maDangKyRowInt))
                        {
                            string SBDRow = trinhDoValue + countLine.ToString("000");
                            System.Diagnostics.Debug.WriteLine(maDangKyRowInt + " " + maPhongThi + " " + maKhoaThi + " " + SBDRow);

                            DSThiSinhTrongPhongThi objDSTSPhongThi = new DSThiSinhTrongPhongThi();
                            objDSTSPhongThi.MADK = maDangKyRowInt;
                            objDSTSPhongThi.MAPHONGTHI = maPhongThi;
                            objDSTSPhongThi.MAKHOATHI = maKhoaThi;
                            objDSTSPhongThi.SBD = SBDRow;

                            if (b_XepPhongThi.ThemThiSinhVaoPhongThi(objDSTSPhongThi))
                            {
                                System.Diagnostics.Debug.WriteLine("Thêm thí sinh " + SBDRow + " thành công");
                            }

                            countLine++;
                        }


                    }



                }

                MessageBox.Show("Thêm thành công", "Thông báo!");
                HienThiDSThiSinhDaCoPhongThi();
                HienThiDSThiSinhChuaCoPhongThi();
            }
            else
            {
                MessageBox.Show("Danh sách trống", "Thông báo!");
            }


        }


        private IEnumerable<IEnumerable<DataGridViewRow>> SplitDataGridView(DataGridView dgv, int maxSize)
        {
            var rows = new List<DataGridViewRow>(maxSize);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                rows.Add(row);

                if (rows.Count == maxSize)
                {
                    yield return rows;
                    rows = new List<DataGridViewRow>(maxSize);
                }
            }

            if (rows.Count > 0)
            {
                yield return rows;
            }
        }






        private void comboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            HienThiDSThiSinhChuaCoPhongThi();

        }

        private void comboBoxTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDSThiSinhChuaCoPhongThi();
        }

        private void btnLapNhanh_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("XÁC NHẬN XẾP PHÒNG THI?", "Xác nhận!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                XepPhongThi();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDSThiSinhChuaCoPhongThi();
            HienThiDSThiSinhDaCoPhongThi();
            HienThiComboKhoaThi();
        }
    }
}
