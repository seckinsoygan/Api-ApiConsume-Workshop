using DataAccessLayer.Abstract;
using DataAccessLayer.Shared;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
