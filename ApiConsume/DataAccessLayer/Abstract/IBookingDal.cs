using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface IBookingDal : IGenericRepository<Booking>
	{
		void BookingStatusChangeApproved(Booking booking);
	}
}
