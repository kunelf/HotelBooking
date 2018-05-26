using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteHotel.Models;

namespace WebSiteHotel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public ActionResult Index()
        {
            //ViewBag.TenLoai = db.LoaiPhongs.Single(n => n.MaLoai == Phong.MaPhong).TenLoai;
            return View(db.Phongs.Take(7).ToList());
        }
    }
}