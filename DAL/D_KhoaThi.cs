using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_KhoaThi
    {
        private TTANEntities TTAN = new TTANEntities();

        public List<KhoaThi> GetKhoaThis()
        {
            return TTAN.KhoaThis.ToList<KhoaThi>();
        }

        public List<KhoaThi> GetNgayDangKyKhoaThi(int maKhoaThi)
        {
            var resultList = TTAN.KhoaThis.Where(t => t.MAKHOATHI == maKhoaThi);

            return resultList.ToList<KhoaThi>();
        }

        public bool ThemKhoaThi(KhoaThi khoaThi)
        {
            {
                try
                {
                    TTAN.KhoaThis.Add(khoaThi);
                    TTAN.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return false;
                }
            }
        }
    }
}
