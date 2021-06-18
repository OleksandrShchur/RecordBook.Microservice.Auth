using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Auth.API.Controllers
{
    [ApiController]
    public class IdentityController : ControllerBase
    {
        [HttpGet]
        [Route("identity")]
        [Authorize]
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
