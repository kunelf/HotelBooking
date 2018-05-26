using System.Web.Mvc;
using WebSiteHotel.Core.Services;

namespace WebSiteHotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly RoomService _roomService;
        public HomeController()
        {
            _roomService = new RoomService();
        }

        public ActionResult Index()
        {
            //ViewBag.TenLoai = db.LoaiPhongs.Single(n => n.MaLoai == Phong.MaPhong).TenLoai;
            return View(_roomService.GetRooms());
        }
    }
}