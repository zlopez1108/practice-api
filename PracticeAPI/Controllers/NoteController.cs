using Microsoft.AspNetCore.Mvc;

namespace PracticeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {

        private readonly ILogger<NoteController> _logger;


        public NoteController(ILogger<NoteController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {



            return Ok();
        }
    }
}
