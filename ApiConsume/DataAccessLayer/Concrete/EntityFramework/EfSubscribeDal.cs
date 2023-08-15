using DataAccessLayer.Abstract;
using DataAccessLayer.Shared;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
