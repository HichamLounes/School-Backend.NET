using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class RoomController : Controller
    {
        public readonly IRoomRepository _roomRepository;
        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Room> rooms = _roomRepository.GetlAllRooms();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Room room)
        {
            _roomRepository.Create(room);
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int roomId)
        {
            _roomRepository.Delete(roomId);
            return View();
        }
    }
}
