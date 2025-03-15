using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Auth_Care_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Index"),Authorize ]
        public IActionResult Index()
        {
            return Ok(new { ff = "This is Private Access"});

        }
        [HttpGet("QryFromUnauthAre")]
        public IActionResult QryFromUnauthAre()
        {
            return Ok(new { Token = "This is Public Access" });
        }
    }
}
