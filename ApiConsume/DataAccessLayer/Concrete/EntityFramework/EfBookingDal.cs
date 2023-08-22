using DataAccessLayer.Abstract;
using DataAccessLayer.Shared;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
