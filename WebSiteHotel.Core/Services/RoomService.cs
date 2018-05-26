using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using PagedList;
using WebSiteHotel.Core.Models;
using WebSiteHotel.Core.Repositories;

namespace WebSiteHotel.Core.Services
{
    public class RoomService
    {
        private readonly Repository<Room> _roomRepository;

        public RoomService()
        {
            _roomRepository = new Repository<Room>();
        }

        public List<Room> GetRooms()
        {
            return _roomRepository.GetAll().Take(7).ToList();
        }

        public IPagedList<Room> GetAllRooms(int pageNumber, int pageSize)
        {
            List<Room> rooms = _roomRepository.GetAll().ToList();
            return rooms.ToPagedList(pageNumber, pageSize);
        }
    }
}
