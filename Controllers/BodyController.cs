using MangaWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MangaWorld.Controllers
{
    public class BodyController : Controller
    {
        MangaDataContext data = new MangaDataContext();
        // GET: Body
        private List<TRUYEN> Laytruyenmoi(int count)
        {
            //Sắp xếp sách theo ngày cập nhật, sau đó lấy top @count 
            return data.TRUYENs.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }
        public ActionResult Index(int ? page)
        {
            //kích thước trang = số mẫu tin cho 1 trang
            int pagesize = 5;
            //Số thứ tự trang: nêu page là null thì pagenum =1, ngược lại pagenum=page
            int pagenum = (page ?? 1);
            //Lấy top 5 Album bán chạy nhất
            var truyenmoi = Laytruyenmoi(15);
            return View(truyenmoi.ToPagedList(pagenum, pagesize));
        }
        public ActionResult Theloai()
        {
            var theloai = from tl in data.THELOAIs select tl;
            return PartialView(theloai);
        }
        public ActionResult Tinhtrang()
        {
            var tinhtrang = from tt in data.TINHTRANGs select tt;
            return PartialView(tinhtrang);
        }
        public ActionResult Truyentheotheloai(int id)
        {
            var truyen= from t in data.TRUYENs where t.MaTL== id select t;
            return View(truyen);

        }
        public ActionResult Truyentheotinhtrang(int id)
        {
            var truyen = from tg in data.TRUYENs where tg.MaTinhtrang == id select tg;
            return View(truyen);

        }
    }
}