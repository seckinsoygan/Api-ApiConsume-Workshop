﻿
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Hoşgeldiniz");
        }

        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Admin Hoşgeldiniz");
        }
    }
}
