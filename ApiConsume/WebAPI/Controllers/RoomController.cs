using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = _roomService.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.Add(room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var room = _roomService.GetById(id);
            _roomService.Delete(room);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Room room)
        {
            _roomService.Update(room);
            return Ok();
        }
    }
}
