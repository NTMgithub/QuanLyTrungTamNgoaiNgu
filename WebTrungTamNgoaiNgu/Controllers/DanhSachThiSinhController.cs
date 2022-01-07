using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTrungTamNgoaiNgu.Controllers
{
    public class DanhSachThiSinhController : Controller
    {

        D_XepPhongThi d_XepPhongThi = new D_XepPhongThi();
        D_DSThiSinhTrongPhongThi d_DSTSPhongThi = new D_DSThiSinhTrongPhongThi();
        D_DangKyThi d_DangKyThi = new D_DangKyThi();
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        [Route("GetPhongThiTheoKhoa")]
        public JsonResult GetPhongThiTheoKhoa(int maKhoaThi)
        {

            var getList = d_XepPhongThi.GetPhongThiTheoKhoa(maKhoaThi);
            return Json(getList, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        [Route("TraCuuDanhSachThiSinh")]
        public JsonResult TraCuuDanhSachThiSinh(int maKhoaThi, String maPhongThi)
        {

            var getList = d_DSTSPhongThi.GetDSThiSinhTrongPhongThies(maKhoaThi, maPhongThi);
            return Json(getList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetThongTinThiSinh")]
        public JsonResult GetThongTinThiSinh(int maDangKy)
        {

            var getList = d_DangKyThi.GetThongTinThiSinh(maDangKy);
            return Json(getList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("GetKetQuaThiSinhQuaMaDangKy")]
        public JsonResult GetKetQuaThiSinhQuaMaDangKy(int maDangKy)
        {

            var getList = d_DSTSPhongThi.GetKetQuaThiSinhQuaMaDangKy(maDangKy);
            return Json(getList, JsonRequestBehavior.AllowGet);
        }



    }
}