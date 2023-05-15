using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        BangDiemEntities db = new BangDiemEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TAIKHOAN tk, FormCollection account)
        {
            string username = account["TenTK"].ToString();
            string password = GetMD5(account["MatKhau"].ToString());
            tk = db.TAIKHOANs.SingleOrDefault(x => x.TenTK.Equals(username) && x.MatKhau.Equals(password));
            if (tk != null)
            {
                Session["TenTaiKhoan"] = tk.TenTK;
                Session["Admin"] = tk.Quyen;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.DangNhapSai = "Thông tin tài khoản hoặc mật khẩu không chính xác, xin kiểm tra lại!";
            return View("Index");
        }
        private string GetMD5(string input)
        {
            string str = "";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(input);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (byte b in buffer)
            {
                str += b.ToString("x2");
            }
            return str;
        }
    }
}