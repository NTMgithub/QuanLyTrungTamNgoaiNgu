using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTrungTamNgoaiNgu.Controllers
{
    public class TraCuuThongTinThiSinhController : Controller
    {
        B_DSThiSinhTrongPhongThi b_dstsphongthi = new B_DSThiSinhTrongPhongThi();
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        [Route("GetThiSinhTheoHoTenSDT")]
        public JsonResult GetThiSinhTheoHoTenSDT(String hoTen, String sdt)
        {
            var getList = b_dstsphongthi.GetDSThiSinhs(hoTen, sdt);
            return Json(getList, JsonRequestBehavior.AllowGet);
        }




    }
}