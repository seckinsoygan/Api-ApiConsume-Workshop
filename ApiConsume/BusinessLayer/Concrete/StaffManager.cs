using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Add(Staff entity)
        {
            _staffDal.Add(entity);
        }

        public void Delete(Staff entity)
        {
            _staffDal.Delete(entity);
        }

        public List<Staff> GetAll()
        {
            return _staffDal.GetAll();
        }

        public Staff GetById(int id)
        {
            return _staffDal.GetById(id);
        }

        public void Update(Staff entity)
        {
            _staffDal.Update(entity);
        }
    }
}
