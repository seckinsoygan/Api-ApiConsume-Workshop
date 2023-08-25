using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking Booking)
        {
            _bookingService.Add(Booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var Booking = _bookingService.GetById(id);
            _bookingService.Delete(Booking);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking Booking)
        {
            _bookingService.Update(Booking);
            return Ok();
        }
        //[HttpPut("UpdateReservationStatusApproved")]
        //public IActionResult UpdateReservationStatusApproved(Booking booking)
        //{
        //	_bookingService.BookingStatusChangeApproved(booking);
        //	return Ok();
        //}
    }
}
