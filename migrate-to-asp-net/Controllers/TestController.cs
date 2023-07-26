using System;
using Microsoft.AspNetCore.Mvc;

namespace migrate_to_asp_net.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            // return "Hello From Get";
            return Ok("Hello From Get");
        }
        public string Get1()
        {
            return "Hello From Get1";
        }
    }
}
