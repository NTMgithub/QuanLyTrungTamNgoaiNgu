using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebTrungTamNgoaiNgu.Controllers
{
    public class DangKyThiController : Controller
    {
        B_DangKyThi b_DangKyThi = new B_DangKyThi();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Create")]
        public JsonResult Create(ThiSinhDK objThiSinh)
        {

            return Json(b_DangKyThi.ThemThiSinh(objThiSinh), JsonRequestBehavior.AllowGet);

        }


    }
}