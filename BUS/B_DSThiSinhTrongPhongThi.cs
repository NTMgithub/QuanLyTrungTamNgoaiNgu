using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class B_DSThiSinhTrongPhongThi
    {
        D_DSThiSinhTrongPhongThi D_DSThiSinhTrongPhongThi = new D_DSThiSinhTrongPhongThi();
        public List<dynamic> GetDSThiSinhTrongPhongThies(int makhoathi, String maphongthi)
        {
            return D_DSThiSinhTrongPhongThi.GetDSThiSinhTrongPhongThies(makhoathi, maphongthi);
        }
        public bool UpdateDiem(DSThiSinhTrongPhongThi thiSinhNew, int madk)
        {
            return D_DSThiSinhTrongPhongThi.UpdateDiem(thiSinhNew, madk);
        }
        public List<dynamic> GetDSThiSinh_TheoTenVaSDTs(String TenHoacSdt)
        {
            return D_DSThiSinhTrongPhongThi.GetDSThiSinh_TheoTenVaSDTs(TenHoacSdt);
        }
        public List<dynamic> GetDSThiSinhs(String hoten, String sdt)
        {
            return D_DSThiSinhTrongPhongThi.GetDSThiSinhs(hoten, sdt);
        }
    }

}
