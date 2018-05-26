using System.Web.Mvc;
using WebSiteHotel.Core.Services;

namespace WebSiteHotel.Controllers
{
    public class RoomsController : Controller
    {
        private readonly RoomService _roomService;
        public RoomsController()
        {
            _roomService = new RoomService();
        }

        public ActionResult Rooms(int? page)
        {
            int pageSize = 6;
            int pageNumber = (page ?? 1);

            var model = _roomService.GetAllRooms(pageNumber, pageSize);
            if (model.Count == 0)
            {
                ViewBag.Phong = "Không có phòng nào thuộc loại này";
            }
            return View(model);
        }
    }
}