using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTrungTamNgoaiNgu.Controllers
{
    public class TraCuuThongTinThiSinhController : Controller
    {
        D_DSThiSinhTrongPhongThi d_dstsphongthi = new D_DSThiSinhTrongPhongThi();
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        [Route("GetThiSinhTheoHoTenSDT")]
        public JsonResult GetThiSinhTheoHoTenSDT(String hoTen, String sdt)
        {
            var getList = d_dstsphongthi.GetDSThiSinhTheoHoTenSDT(hoTen, sdt);
            return Json(getList, JsonRequestBehavior.AllowGet);
        }




    }
}