using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public interface IRoomRepository
    {
        public List<Room> GetlAllRooms();
        public void Create(Room room);
        public void Delete(int roomId);
    }
}
