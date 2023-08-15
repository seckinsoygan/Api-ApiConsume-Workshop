using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Add(Room entity)
        {
            _roomDal.Add(entity);
        }

        public void Delete(Room entity)
        {
            _roomDal.Delete(entity);
        }

        public List<Room> GetAll()
        {
            return _roomDal.GetAll();
        }

        public Room GetById(int id)
        {
            return _roomDal.GetById(id);
        }

        public void Update(Room entity)
        {
            _roomDal.Update(entity);
        }
    }
}
