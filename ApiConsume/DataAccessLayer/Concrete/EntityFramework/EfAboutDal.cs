using DataAccessLayer.Abstract;
using DataAccessLayer.Shared;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        public EfAboutDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
