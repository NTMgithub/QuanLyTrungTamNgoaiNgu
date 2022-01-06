using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_DSThiSinhTrongPhongThi
    {
        private TTANEntities TTAN = new TTANEntities();
        public List<dynamic> GetDSThiSinhTrongPhongThies(int makhoathi, String maphongthi)
        {
            var DSThiSinhTrongPhongThiNay = from ds in TTAN.DSThiSinhTrongPhongThis
                                            join thisinh in TTAN.ThiSinhDKs on ds.MADK equals thisinh.MADK
                                            where ds.MAKHOATHI == makhoathi
                                            where ds.MAPHONGTHI == maphongthi
                                            select new
                                            {
                                                MADK = ds.MADK,
                                                SBD = ds.SBD,
                                                HOTEN = thisinh.HOTEN,
                                                PHONGTHI = ds.MAPHONGTHI,
                                                DIEMNGHE = ds.DIEMNGHE,
                                                DIEMNOI = ds.DIEMNOI,
                                                DIEMVIET = ds.DIEMVIET,
                                                DIEMDOC = ds.DIEMDOC
                                            };

            return DSThiSinhTrongPhongThiNay.ToList<dynamic>();
        }
        public bool UpdateDiem(DSThiSinhTrongPhongThi thiSinhNew, int madk)
        {
            {
                try
                {
                    DSThiSinhTrongPhongThi thiSinhOld = (from thisinh in TTAN.DSThiSinhTrongPhongThis
                                                         where thisinh.MADK == madk
                                                         select thisinh).SingleOrDefault();

                    if (!thiSinhNew.DIEMDOC.Equals(""))
                    {
                        thiSinhOld.DIEMDOC = thiSinhNew.DIEMDOC;
                    }
                    if (!thiSinhNew.DIEMNGHE.Equals(""))
                    {
                        thiSinhOld.DIEMNGHE = thiSinhNew.DIEMNGHE;

                    }
                    if (!thiSinhNew.DIEMNOI.Equals(""))
                    {
                        thiSinhOld.DIEMNOI = thiSinhNew.DIEMNOI;

                    }
                    if (!thiSinhNew.DIEMVIET.Equals(""))
                    {
                        thiSinhOld.DIEMVIET = thiSinhNew.DIEMVIET;
                    }


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

        // Câu 18
        public List<dynamic> GetDSThiSinhCoDiemes(String TenHoacSdt)
        {
            var DSThiSinhCoDiem = from thisinh in TTAN.ThiSinhDKs
                                  join danhsach in TTAN.DSThiSinhTrongPhongThis on thisinh.MADK equals danhsach.MADK
                                  where thisinh.SDT == TenHoacSdt || thisinh.HOTEN == TenHoacSdt
                                  select new
                                  {
                                      MADK = danhsach.MADK,
                                      SBD = danhsach.SBD,
                                      HOTEN = thisinh.HOTEN,
                                      PHONGTHI = danhsach.MAPHONGTHI,
                                      DIEMNGHE = danhsach.DIEMNGHE,
                                      DIEMNOI = danhsach.DIEMNOI,
                                      DIEMVIET = danhsach.DIEMVIET,
                                      DIEMDOC = danhsach.DIEMDOC
                                  };

            return DSThiSinhCoDiem.ToList<dynamic>();
        }
    }
}
