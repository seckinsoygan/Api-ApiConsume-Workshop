using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class BookingManager : IBookingService
	{
		private readonly IBookingDal _bookingDal;

		public BookingManager(IBookingDal BookingDal)
		{
			_bookingDal = BookingDal;
		}

		public void Add(Booking entity)
		{
			_bookingDal.Add(entity);
		}

		public void BookingStatusChangeApproved(Booking booking)
		{
			_bookingDal.BookingStatusChangeApproved(booking);
		}

		public void Delete(Booking entity)
		{
			_bookingDal.Delete(entity);
		}

		public List<Booking> GetAll()
		{
			return _bookingDal.GetAll();
		}

		public Booking GetById(int id)
		{
			return _bookingDal.GetById(id);
		}

		public void Update(Booking entity)
		{
			_bookingDal.Update(entity);
		}
	}
}
