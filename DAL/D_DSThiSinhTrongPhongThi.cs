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
                                                DIEMNGHE = ds.DIEMNGHE,
                                                DIEMNOI = ds.DIEMNOI,
                                                DIEMVIET = ds.DIEMVIET,
                                                DIEMDOC = ds.DIEMDOC
                                            };

            return DSThiSinhTrongPhongThiNay.ToList<dynamic>();
        }
    }
}
