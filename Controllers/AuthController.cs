using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MangaWorld.Models;


namespace MangaWorld.Controllers
{

    public class AuthController : Controller
    {
         MangaDataContext db = new MangaDataContext();
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection hz)
        {
            var tendn = hz["TenDN"];
            var matkhau = hz["Matkhau"];
            if (String.IsNullOrEmpty(tendn))
                ViewData["Loi1"] = "Vui lòng nhập tên đăng nhập";
            else if (String.IsNullOrEmpty(matkhau))
                ViewData["Loi2"] = "Vui lo2nh nhập mật khẩu";
            else
            {
                var us = db.USERs.SingleOrDefault(n => n.Taikhoan == tendn && n.Matkhau == matkhau);
                if (us != null)
                {
                    Session["Taikhoan"] = us;
                    return RedirectToAction("Index", "Auth");
                }
                else
                    ViewBag.Thongbao = "Tên đăng nhập hoặc mật khẩu không hợp lệ";
            }

            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(FormCollection collection, USER us)
        {
            // Gán các giá tị người dùng nhập liệu cho các biến 
            var tendn = collection["TenDN"];
            var matkhau = collection["Matkhau"];
            var matkhaunhaplai = collection["Matkhaunhaplai"];
            var dienthoai = collection["Dienthoai"];
            var email = collection["Email"];
            var gender = String.Format("MALE,FEMALE", collection["gender"]);
            var ngaysinh = String.Format("{0:MM/dd/yyyy}", collection["Ngaysinh"]);
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Hãy nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Bạn chưa nhập mật khẩu";
            }
            else if (String.IsNullOrEmpty(matkhaunhaplai))
            {
                ViewData["Loi3"] = "Hãy nhập lại mật khẩu";
            }
            else if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "Email không được bỏ trống";
            }

            else if (String.IsNullOrEmpty(dienthoai))
            {
                ViewData["Loi4"] = "Hãy nhập nhập điện thoai";
            }
            else
            {
                //Gán giá trị cho đối tượng được tạo mới (us)
                us.Taikhoan = tendn;
                us.Matkhau = matkhau;
                us.Email = email;
                us.DienThoai = dienthoai;
                us.Ngaysinh = DateTime.Parse(ngaysinh);
                db.USERs.InsertOnSubmit(us);
                db.SubmitChanges();
                return RedirectToAction("Login", "Auth");
            }
            return this.Registration();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}