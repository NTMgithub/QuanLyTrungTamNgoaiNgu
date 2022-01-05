using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class B_XepPhongThi
    {
        D_XepPhongThi d_XepPhongThi = new D_XepPhongThi();

        //Danh sach thi sinh
        public List<dynamic> GetDSThiSinhDaCoPhongThi()
        {
            return d_XepPhongThi.GetDSThiSinhDaCoPhongThi();
        }

        public List<ThiSinhDK> GetDSThiSinhChuaDangKy(int monthKhoa, int yearKhoa, String trinhDoValue)
        {
            return d_XepPhongThi.GetDSThiSinhChuaDangKy(monthKhoa, yearKhoa, trinhDoValue);
        }

        public bool ThemThiSinhVaoPhongThi(DSThiSinhTrongPhongThi objDSTSPhongThi)
        {
            return d_XepPhongThi.ThemThiSinhVaoPhongThi(objDSTSPhongThi);
        }


        //Phong thi
        public bool ThemPhongThi(PhongThi objPhongThi)
        {
            return d_XepPhongThi.ThemPhongThi(objPhongThi);
        }


    }
}
