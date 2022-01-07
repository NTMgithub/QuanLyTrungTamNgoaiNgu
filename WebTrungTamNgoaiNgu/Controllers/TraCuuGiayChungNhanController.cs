using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTrungTamNgoaiNgu.Controllers
{
    public class TraCuuGiayChungNhanController : Controller
    {
        D_KhoaThi d_KhoaThi = new D_KhoaThi();
        D_DSThiSinhTrongPhongThi d_DSTSphongThi = new D_DSThiSinhTrongPhongThi();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("GetAllKhoaThi")]
        public JsonResult GetAllKhoaThi()
        {
            
            var getList = d_KhoaThi.GetAllKhoaThi();
            return Json(getList, JsonRequestBehavior.AllowGet);
        }
        

        [HttpGet]
        [Route("GetThongTinGiayChungNhan")]
        public JsonResult GetThongTinGiayChungNhan(int maKhoaThi, String soBaoDanh)
        {

            var getList = d_DSTSphongThi.GetThongTinGiayChungNhan(maKhoaThi, soBaoDanh);
            return Json(getList, JsonRequestBehavior.AllowGet);
        }

    }
}