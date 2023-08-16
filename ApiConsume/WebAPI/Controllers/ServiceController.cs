using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _ServiceService;
        public ServiceController(IServiceService ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var values = _ServiceService.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var value = _ServiceService.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _ServiceService.Add(Service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var Service = _ServiceService.GetById(id);
            _ServiceService.Delete(Service);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _ServiceService.Update(Service);
            return Ok();
        }
    }
}
