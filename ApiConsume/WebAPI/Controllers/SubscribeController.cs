using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _SubscribeService;
        public SubscribeController(ISubscribeService SubscribeService)
        {
            _SubscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _SubscribeService.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var value = _SubscribeService.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.Add(Subscribe);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var Subscribe = _SubscribeService.GetById(id);
            _SubscribeService.Delete(Subscribe);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.Update(Subscribe);
            return Ok();
        }
    }
}
