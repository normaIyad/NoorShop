using Microsoft.AspNetCore.Mvc;
using NoorShop.API.Database;

namespace NoorShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatigoryController : ControllerBase
    {
        private readonly applecationDatabase _context;

        public CatigoryController(applecationDatabase context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("done connection ");
        }


    }

}
