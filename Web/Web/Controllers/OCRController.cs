using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IronOcr;
namespace Web.Controllers
{
    public class OCRController : Controller
    {
        // GET: OCR
        public ActionResult OCRFile(string filename)
        {
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }
            ViewBag.pdf = filename;
            ViewBag.File = new IronTesseract().Read(@filename).Text;

            return View();
        }
    }
}