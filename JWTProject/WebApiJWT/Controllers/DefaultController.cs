
using Microsoft.AspNetCore.Mvc;
using WebApiJWT.Models;

namespace WebApiJWT.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DefaultController : ControllerBase
	{
		[HttpGet("[action]")]
		public IActionResult Test()
		{
			return Ok(new CreateToken().TokenCreate());
		}

		[HttpGet("[action]")]
		[Microsoft.AspNetCore.Authorization.Authorize]
		public IActionResult Test2()
		{
			return Ok("Hoşgeldiniz");
		}
	}
}
