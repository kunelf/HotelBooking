using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteHotel.Models;
using PagedList;
using PagedList.Mvc;

namespace WebSiteHotel.Controllers
{
    public class RoomsController : Controller
    {
        // GET: Room
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public ActionResult Rooms(int? page)
        {
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            List<Phong> lstphong = db.Phongs.ToList();
            {
                if (lstphong.Count == 0)
                {
                    ViewBag.Phong = "Không có phòng nào thuộc loại này";
                }
            }
            return View(lstphong.ToPagedList(pageNumber, pageSize));
        }
    }
}