using DataAccessLayer.Abstract;
using DataAccessLayer.Shared;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
