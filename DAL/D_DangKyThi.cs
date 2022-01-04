using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class D_DangKyThi
    {
        private TTANEntities TTAN = new TTANEntities();

        public List<ThiSinhDK> GetThiSinhDKs()
        {
            var dsThiSinhDk = TTAN.ThiSinhDKs;
            return dsThiSinhDk.ToList<ThiSinhDK>();
        }

        public bool ThemThiSinh(ThiSinhDK thiSinh)
        {
            {
                try
                {
                    TTAN.ThiSinhDKs.Add(thiSinh);
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

        public bool XoaThiSinh(int madk)
        {
            {
                try
                {
                    ThiSinhDK thiSinh = new ThiSinhDK();
                    thiSinh = TTAN.ThiSinhDKs.Find(madk);
                    TTAN.ThiSinhDKs.Remove(thiSinh);
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

        public bool SuaThiSinh(ThiSinhDK thiSinhNew, int madk)
        {
            {
                try
                {
                    ThiSinhDK thiSinhOld = TTAN.ThiSinhDKs.Find(madk);

                    thiSinhOld.HOTEN = thiSinhNew.HOTEN;
                    thiSinhOld.TRINHDO = thiSinhNew.TRINHDO;
                    thiSinhOld.GIOITINH = thiSinhNew.GIOITINH;
                    thiSinhOld.NGAYSINH = thiSinhNew.NGAYSINH;
                    thiSinhOld.CMND = thiSinhNew.CMND;
                    thiSinhOld.SDT = thiSinhNew.SDT;
                    thiSinhOld.EMAIL = thiSinhNew.EMAIL;
                    thiSinhOld.NGAYDK = thiSinhNew.NGAYDK;

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
        public bool checkTonTai(ThiSinhDK thiSinhNew)
        {
            var thiSinhs = from ts in TTAN.ThiSinhDKs
                           where ts.CMND == thiSinhNew.CMND
                           where ts.NGAYDK == thiSinhNew.NGAYDK
                           where ts.TRINHDO == thiSinhNew.TRINHDO
                           select ts;
            if (thiSinhs.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
    }
}