using MangaWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MangaWorld.Controllers
{
    public class BodyController : Controller
    {
        MangaDataContext data = new MangaDataContext();
        // GET: Body
        public ActionResult Index()
        {
            return View();
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
    }
}