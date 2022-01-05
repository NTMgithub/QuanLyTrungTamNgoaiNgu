using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class B_KhoaThi
    {
        D_KhoaThi _KhoaThi = new D_KhoaThi();
        public List<KhoaThi> GetKhoaThis()
        {
            return _KhoaThi.GetKhoaThis();
        }

        public List<KhoaThi> GetNgayDangKyKhoaThi(int maKhoaThi)
        {
            return _KhoaThi.GetNgayDangKyKhoaThi(maKhoaThi);
        }

        public bool ThemKhoaThi(KhoaThi khoaThi)
        {
            return _KhoaThi.ThemKhoaThi(khoaThi);
        }


    }
}
