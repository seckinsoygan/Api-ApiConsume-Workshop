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

		public void BookingStatusChangeApproved(Booking booking)
		{
			var context = new AppDbContext();
			var values = context.Bookings.Where(x => x.BookingId == booking.BookingId).FirstOrDefault();
			values.Status = "Onaylandı.";
			context.SaveChanges();
		}
	}
}
