using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.Dtos.RoomDto;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
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
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Room>(roomAddDto);
            _roomService.Add(values);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var room = _roomService.GetById(id);
            _roomService.Delete(room);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDto roomUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                BadRequest();
            }
            var values = _mapper.Map<Room>(roomUpdateDto);
            _roomService.Update(values);
            return Ok();
        }
    }
}
