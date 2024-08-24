using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class RoomRepository : IRoomRepository
    {
        public readonly MyDbContext _myDbContext;
        public RoomRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public void Create(Room room)
        {
            _myDbContext.rooms.Add(room);
            _myDbContext.SaveChanges();
        }

        public void Delete(int roomId)
        {
            Room room = (from roomObj in _myDbContext.rooms
                         where roomObj.id == roomId
                         select roomObj).FirstOrDefault();
            _myDbContext.rooms.Remove(room);
            _myDbContext.SaveChanges();
        }

        public List<Room> GetlAllRooms()
        {
            List<Room> rooms = (from roomObj in _myDbContext.rooms
                                select roomObj).ToList();
            return rooms;
        }
    }
}
