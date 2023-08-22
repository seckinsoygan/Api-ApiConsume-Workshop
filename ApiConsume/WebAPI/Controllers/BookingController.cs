using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _BookingService;
        public BookingController(IBookingService BookingService)
        {
            _BookingService = BookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _BookingService.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _BookingService.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking Booking)
        {
            _BookingService.Add(Booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var Booking = _BookingService.GetById(id);
            _BookingService.Delete(Booking);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking Booking)
        {
            _BookingService.Update(Booking);
            return Ok();
        }
    }
}
