using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class TaiKhoanController : Controller
    {
        BangDiemEntities db = new BangDiemEntities();
        // GET: TaiKhoan
        public ActionResult ListTaiKhoan()
        {
            //kiểm tra đăng nhập
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }
            return View(db.TAIKHOANs.ToList());
        }
        //create new account 
        [HttpGet]
        public ActionResult TaoTaiKhoan()
        {
            TAIKHOAN tk = new TAIKHOAN();
            //kiểm tra đăng nhập
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                tk.TenTK = null;
                tk.MatKhau = RandomNumber();
            }
            return View(tk);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TaoTaiKhoan([Bind(Include = " TenTK,MatKhau")] TAIKHOAN tk)
        {
            if (ModelState.IsValid)
            {
                string pass = GetMD5(tk.MatKhau);
                tk.MatKhau = pass;
                tk.Quyen = 0;
                db.TAIKHOANs.Add(tk);
                db.SaveChanges();
                return RedirectToAction("ListTaiKhoan", "TaiKhoan");
            }
            return RedirectToAction("TaoTaiKhoan", "TaiKhoan");
        }
        //Edit one account
        [HttpGet]
        public ActionResult SuaTaiKhoan(string ten)
        {
            //kiểm tra đăng nhập
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }
            if (Session["Admin"].ToString() == "1" && Session["TenTaiKhoan"].ToString() == ten)
            {
                return RedirectToAction("ResetPass", "TaiKhoan");
            }
            TAIKHOAN tk = db.TAIKHOANs.Find(ten);
            if (tk == null)
            {
                return HttpNotFound();
            }
            tk.MatKhau = "";
            return View(tk);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SuaTaiKhoan([Bind(Include = " TenTK,MatKhau")] TAIKHOAN tk)
        {
            if (ModelState.IsValid)
            {
                string pass = GetMD5(tk.MatKhau);
                tk.MatKhau = pass;
                tk.Quyen = 0;
                db.Entry(tk).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ListTaiKhoan", "TaiKhoan");
            }
            return RedirectToAction("SuaTaiKhoan", "TaiKhoan");
        }
        //Setting
        [HttpGet]
        public ActionResult ResetPass(string ten)
        {
            //kiểm tra đăng nhập
            if (Session["TenTaiKhoan"] == null || Session["Admin"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResetPass([Bind(Include = "MatKhau")] TAIKHOAN tk, FormCollection f)
        {
            string name = Session["TenTaiKhoan"].ToString();
            string pass = GetMD5(f["txtPass"].ToString());
            TAIKHOAN lstKQ = db.TAIKHOANs.AsNoTracking().SingleOrDefault(x => x.TenTK.Equals(name) && x.MatKhau.Equals(pass));
            if (lstKQ != null)
            {
                if (ModelState.IsValid)
                {
                    tk.TenTK = name;
                    string savepass = GetMD5(tk.MatKhau);
                    tk.MatKhau = savepass;
                    tk.Quyen = Int32.Parse(Session["Admin"].ToString());
                    db.Entry(tk).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }

            ViewBag.ThongBao = "Mật khẩu hiện tại chưa chính xác mời nhập lại!";
            return View();
        }
        //random chuỗi số bất kỳ
        public static string RandomNumber()
        {
            string randomStr = "";
            try
            {

                int[] myIntArray = new int[8];
                int x;
                //that is to create the random # and add it to uour string
                Random autoRand = new Random();
                for (x = 0; x < 8; x++)
                {
                    myIntArray[x] = System.Convert.ToInt32(autoRand.Next(0, 9));
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch (Exception ex)
            {
                randomStr = "error";
            }
            return randomStr;
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