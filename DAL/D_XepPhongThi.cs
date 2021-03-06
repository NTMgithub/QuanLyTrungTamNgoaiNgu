using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class D_XepPhongThi
    {
        private TTANEntities TTAN = new TTANEntities();

        //Danh sach thi sinh
        public List<dynamic> GetDSThiSinhDaCoPhongThi()
        {
            var dsThiSinhDk = (from tableThiSinh in TTAN.ThiSinhDKs
                               from tableKhoaThi in TTAN.KhoaThis
                               from tableDSThiSinhPhongThi in TTAN.DSThiSinhTrongPhongThis
                               where tableThiSinh.MADK == tableDSThiSinhPhongThi.MADK && tableKhoaThi.MAKHOATHI == tableDSThiSinhPhongThi.MAKHOATHI
                               select new
                               {
                                   MADK = tableThiSinh.MADK,
                                   HOTEN = tableThiSinh.HOTEN,
                                   NGAYSINH = tableThiSinh.NGAYSINH,
                                   CMND = tableThiSinh.CMND,
                                   SDT = tableThiSinh.SDT,
                                   NGAYDK = tableThiSinh.NGAYDK,
                                   TRINHDO = tableThiSinh.TRINHDO,
                                   TENKHOATHI = tableKhoaThi.TENKHOATHI,
                                   MAPHONGTHI = tableDSThiSinhPhongThi.MAPHONGTHI,
                                   SBD = tableDSThiSinhPhongThi.SBD,
                                   NGAYTHI = tableKhoaThi.NGAYTHI
                               }
                              );

            return dsThiSinhDk.ToList<dynamic>();
        }


        public List<ThiSinhDK> GetDSThiSinhChuaDangKy(int monthKhoa, int yearKhoa, String trinhDoValue)
        {
            var dsThiSinhDk = from tableThiSinh in TTAN.ThiSinhDKs
                              where !(from tableDSThiSinhPhongThi in TTAN.DSThiSinhTrongPhongThis select tableDSThiSinhPhongThi.MADK).Contains(tableThiSinh.MADK)
                              && tableThiSinh.NGAYDK.Month == monthKhoa && tableThiSinh.NGAYDK.Year == yearKhoa
                              && tableThiSinh.TRINHDO == trinhDoValue
                              select tableThiSinh;


            return dsThiSinhDk.ToList<ThiSinhDK>();
        }

        public List<ThiSinhDK> GetDSThiSinhChuaDangKy_TruocNgayThi(String trinhDoValue)
        {
            var dsThiSinhDk = from tableThiSinh in TTAN.ThiSinhDKs
                              where !(from tableDSThiSinhPhongThi in TTAN.DSThiSinhTrongPhongThis select tableDSThiSinhPhongThi.MADK).Contains(tableThiSinh.MADK)
                              && tableThiSinh.TRINHDO == trinhDoValue
                              select tableThiSinh;

                
            return dsThiSinhDk.ToList<ThiSinhDK>();
        }

       



        public bool ThemThiSinhVaoPhongThi(DSThiSinhTrongPhongThi objDSTSPhongThi)
        {
            {
                try
                {
                    TTAN.DSThiSinhTrongPhongThis.Add(objDSTSPhongThi);
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




        //Phong thi
        public List<PhongThi> GetAllPhongThi()
        {
            var dsPhongThi = TTAN.PhongThis;

            return dsPhongThi.ToList<PhongThi>();
        }

        public List<dynamic> GetPhongThis(String khoathi)
        {
            int makhoathi = Int32.Parse(khoathi);
            var dsPhongThi = from phongthis in TTAN.PhongThis
                             where phongthis.MAKHOATHI == makhoathi
                             select phongthis;

            return dsPhongThi.ToList<dynamic>();
        }

        public List<PhongThi> GetPhongThiTheoKhoa(int maKhoathi)
        {
            TTAN.Configuration.ProxyCreationEnabled = false;
            var dsPhongThi = from phongthis in TTAN.PhongThis
                             where phongthis.MAKHOATHI == maKhoathi
                             select phongthis;

            return dsPhongThi.ToList<PhongThi>();
        }

        public bool ThemPhongThi(PhongThi objPhongThi)
        {
            {
                try
                {
                    TTAN.PhongThis.Add(objPhongThi);
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