using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void Add(Subscribe entity)
        {
            _subscribeDal.Add(entity);
        }

        public void Delete(Subscribe entity)
        {
            _subscribeDal.Delete(entity);
        }

        public List<Subscribe> GetAll()
        {
            return _subscribeDal.GetAll();
        }

        public Subscribe GetById(int id)
        {
            return _subscribeDal.GetById(id);
        }

        public void Update(Subscribe entity)
        {
            _subscribeDal.Update(entity);
        }
    }
}
