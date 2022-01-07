using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTrungTamNgoaiNgu.Controllers
{
    public class ThongKeController : Controller
    {
        D_KhoaThi d_KhoaThi = new D_KhoaThi();
        D_XepPhongThi d_XepPhongThi = new D_XepPhongThi();
        D_DangKyThi d_DangKyThi = new D_DangKyThi();
        public ActionResult Index()
        {
            var soLuongKhoaThi = d_KhoaThi.GetAllKhoaThi().Count;
            var soLuongPhongThi = d_XepPhongThi.GetAllPhongThi().Count;
            var soLuongThiSinhA2 = d_DangKyThi.GetThiSinhTheoTrinhDo("A2").Count;
            var soLuongThiSinhB1 = d_DangKyThi.GetThiSinhTheoTrinhDo("B1").Count;

            ViewBag.soLuongKhoaThi = soLuongKhoaThi;
            ViewBag.soLuongPhongThi = soLuongPhongThi;
            ViewBag.soLuongThiSinhA2 = soLuongThiSinhA2;
            ViewBag.soLuongThiSinhB1 = soLuongThiSinhB1;

            return View();
        }

       
    }
}