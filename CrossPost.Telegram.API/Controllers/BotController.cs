using CrossPost.Telegram.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CrossPost.Telegram.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        private readonly BotService _botService;

        public BotController(BotService botService)
        {
            _botService = botService; 
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            //await _botService.SendPostAsync();
            return Ok();
        }
    }
}
