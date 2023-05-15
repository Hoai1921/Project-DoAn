using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        BangDiemEntities db = new BangDiemEntities();
        public ActionResult Index()
        {
            //kiểm tra đăng nhập
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }
            Session["count1"] = db.BANGDIEMs.Count(x => x.Id_LanHoc == 1);
            Session["count2"] = db.BANGDIEMs.Count(x => x.Id_LanHoc == 2);
            Session["count3"] = db.BANGDIEMs.Count(x => x.Id_LanHoc == 3);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}