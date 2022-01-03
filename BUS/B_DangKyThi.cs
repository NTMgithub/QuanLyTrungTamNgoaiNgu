using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class B_DangKyThi
    {
        D_DangKyThi d_DangKy = new D_DangKyThi();
        public List<dynamic> GetThiSinhDKs()
        {
            return d_DangKy.GetThiSinhDKs();
        }
        public bool ThemThiSinh(ThiSinhDK thiSinh)
        {
            return d_DangKy.ThemThiSinh(thiSinh);
        }
        public bool XoaThiSinh(int madk)
        {
            return d_DangKy.XoaThiSinh(madk);
        }
        public bool SuaThiSinh(ThiSinhDK thiSinhNew, int madk)
        {
            return d_DangKy.SuaThiSinh(thiSinhNew, madk);
        }
    }
}
