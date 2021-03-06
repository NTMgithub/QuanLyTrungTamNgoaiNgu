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
        public List<dynamic> GetDSThiSinh_TheoTenVaSDTs(String TenHoacSdt)
        {
            var DSThiSinh = from thisinh in TTAN.ThiSinhDKs
                                  join danhsach in TTAN.DSThiSinhTrongPhongThis on thisinh.MADK equals danhsach.MADK
                                  where thisinh.SDT == TenHoacSdt || thisinh.HOTEN == TenHoacSdt
                                  select new
                                  {
                                      MADK = danhsach.MADK,
                                      SBD = danhsach.SBD,
                                      HOTEN = thisinh.HOTEN,
                                      SDT = thisinh.SDT,
                                      PHONGTHI = danhsach.MAPHONGTHI,
                                      DIEMNGHE = danhsach.DIEMNGHE,
                                      DIEMNOI = danhsach.DIEMNOI,
                                      DIEMVIET = danhsach.DIEMVIET,
                                      DIEMDOC = danhsach.DIEMDOC
                                  };

            return DSThiSinh.ToList<dynamic>();
        }
        public List<dynamic> GetDSThiSinhs(String hoten, String sdt)
        {
            var DSThiSinh = from thisinh in TTAN.ThiSinhDKs
                                  join danhsach in TTAN.DSThiSinhTrongPhongThis on thisinh.MADK equals danhsach.MADK
                                  where thisinh.HOTEN == hoten && thisinh.SDT == sdt
                                  select new
                                  {
                                      MADK = danhsach.MADK,
                                      SBD = danhsach.SBD,
                                      HOTEN = thisinh.HOTEN,
                                      SDT = thisinh.SDT,
                                      PHONGTHI = danhsach.MAPHONGTHI,
                                      DIEMNGHE = danhsach.DIEMNGHE,
                                      DIEMNOI = danhsach.DIEMNOI,
                                      DIEMVIET = danhsach.DIEMVIET,
                                      DIEMDOC = danhsach.DIEMDOC
                                  };

            return DSThiSinh.ToList<dynamic>();
        }

        public List<dynamic> GetDSThiSinhTheoHoTenSDT(String hoten, String sdt)
        {
            var DSThiSinh = from thisinh in TTAN.ThiSinhDKs
                            join danhsach in TTAN.DSThiSinhTrongPhongThis on thisinh.MADK equals danhsach.MADK
                            join khoathi in TTAN.KhoaThis on danhsach.MAKHOATHI equals khoathi.MAKHOATHI
                            where thisinh.HOTEN == hoten && thisinh.SDT == sdt
                            select new
                            {
                                MADK = danhsach.MADK,
                                SBD = danhsach.SBD,
                                HOTEN = thisinh.HOTEN,
                                KHOATHI = khoathi.TENKHOATHI,
                                PHONGTHI = danhsach.MAPHONGTHI,
                                DIEMNGHE = danhsach.DIEMNGHE,
                                DIEMNOI = danhsach.DIEMNOI,
                                DIEMVIET = danhsach.DIEMVIET,
                                DIEMDOC = danhsach.DIEMDOC
                            };

            return DSThiSinh.ToList<dynamic>();
        }

        public List<dynamic> GetThongTinGiayChungNhan(int maKhoaThi, String soBaoDanh)
        {
            var DSThiSinh = from thisinh in TTAN.ThiSinhDKs
                            join danhsach in TTAN.DSThiSinhTrongPhongThis on thisinh.MADK equals danhsach.MADK
                            join khoathi in TTAN.KhoaThis on danhsach.MAKHOATHI equals khoathi.MAKHOATHI
                            where danhsach.MAKHOATHI == maKhoaThi && danhsach.SBD == soBaoDanh
                            select new
                            {
                                TRINHDO = thisinh.TRINHDO,
                                HOTEN = thisinh.HOTEN,
                                NGAYSINH = thisinh.NGAYSINH,
                                CMND = thisinh.CMND,
                                NGAYTHI = khoathi.NGAYTHI,
                                DIEMNGHE = danhsach.DIEMNGHE,
                                DIEMNOI = danhsach.DIEMNOI,
                                DIEMVIET = danhsach.DIEMVIET,
                                DIEMDOC = danhsach.DIEMDOC
                            };

            return DSThiSinh.ToList<dynamic>();
        }

        public List<dynamic> GetKetQuaThiSinhQuaMaDangKy(int maDangKy)
        {
            var DSThiSinh = from thisinh in TTAN.ThiSinhDKs
                            join danhsach in TTAN.DSThiSinhTrongPhongThis on thisinh.MADK equals danhsach.MADK
                            where danhsach.MADK == maDangKy 
                            select new
                            {
                                TRINHDO = thisinh.TRINHDO,
                                HOTEN = thisinh.HOTEN,
                                NGAYSINH = thisinh.NGAYSINH,
                                CMND = thisinh.CMND,
                                DIEMNGHE = danhsach.DIEMNGHE,
                                DIEMNOI = danhsach.DIEMNOI,
                                DIEMVIET = danhsach.DIEMVIET,
                                DIEMDOC = danhsach.DIEMDOC
                            };

            return DSThiSinh.ToList<dynamic>();
        }


    }
}
