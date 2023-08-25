using BusinessLayer.Shared;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IBookingService : IGenericService<Booking>
	{
		void BookingStatusChangeApproved(Booking booking);
	}
}
