using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class SearchController : Controller
    {
        BangDiemEntities db = new BangDiemEntities();
        // GET: Search
        [HttpPost]
        public ActionResult Searching(FormCollection f)
        {
            //kiểm tra đăng nhập
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }
            string searchkey = f["txtKeyWord"].ToString();
            ViewBag.keyword = searchkey;
            List<BANGDIEM> lstKQ = db.BANGDIEMs.Where(n => n.UrlFile.Contains(searchkey)).ToList();
            if (lstKQ.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy Folder nào!";
                return View(db.BANGDIEMs.OrderBy(n => n.UrlFile).ToList());
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQ.Count + " kết quả";
            return View(lstKQ.OrderBy(n => n.UrlFile).ToList());
        }
        [HttpGet]
        public ActionResult Searching(string searchkey)
        {
            ViewBag.keyword = searchkey;
            List<BANGDIEM> lstKQ = db.BANGDIEMs.Where(n => n.UrlFile.Contains(searchkey)).ToList();
            if (lstKQ.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy Folder nào!";
                return View(db.BANGDIEMs.OrderBy(n => n.UrlFile).ToList());
            }
            ViewBag.ThongBao = "Đã tìm thấy " + lstKQ.Count + " kết quả";
            return View(lstKQ.OrderBy(n => n.UrlFile).ToList());
        }
    }
}