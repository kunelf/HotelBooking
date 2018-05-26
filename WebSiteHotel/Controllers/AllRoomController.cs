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
    public class AllRoomController : Controller
    {
        // GET: AllRoom
        QuanLyKhachSanEntities db = new QuanLyKhachSanEntities();
        public ActionResult AllRoom(int? page)
        {
            int pageSize = 12;
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