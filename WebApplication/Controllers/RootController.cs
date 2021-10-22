using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("/")]
    public class RootController : ControllerBase
    {
        [HttpGet]
        public OkObjectResult Get()
        {
            return Ok("hi there!");
        }
    }
}
