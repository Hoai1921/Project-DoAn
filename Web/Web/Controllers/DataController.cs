using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class DataController : Controller
    {
        BangDiemEntities db = new BangDiemEntities();
        // GET: Data
        public ActionResult ListFolder()
        {
            //kiểm tra đăng nhập
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }
            return View(db.BANGDIEMs.ToList());
        }
        public ViewResult FolderTheoLanHoc(int Id_Lan = 1)
        {

            LANHOC listFolder = db.LANHOCs.SingleOrDefault(n => n.Id == Id_Lan);
            if (listFolder == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<BANGDIEM> lstBangDiem = db.BANGDIEMs.Where(n => n.Id_LanHoc == Id_Lan).OrderBy(n => n.UrlFile).ToList();
            if (lstBangDiem.Count == 0)
            {
                ViewBag.lstBangDiem = "Không có folder nào thuộc loại này";
            }
            Session["namePage"] = listFolder.TenLan;
            ViewBag.lstBangDiem = db.BANGDIEMs.ToList();
            return View(lstBangDiem);
        }
        public ActionResult ListFile(int id = 1)
        {
            //kiểm tra đăng nhập
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }

            BANGDIEM listFile = db.BANGDIEMs.SingleOrDefault(n => n.Id == id);
            string[] url = listFile.UrlFile.Split('\\');
            Session["Url"] = url[url.Length - 1];
            if (listFile == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            if (!System.IO.Directory.Exists(listFile.UrlFile))
            {
                return RedirectToAction("ListFolder", "Data");
            }
            ViewBag.File = Directory.GetFiles(@listFile.UrlFile);
            return View(listFile);
        }
    }
}