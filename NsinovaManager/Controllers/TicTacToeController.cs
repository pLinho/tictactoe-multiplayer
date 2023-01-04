using Microsoft.AspNetCore.Mvc;

namespace NsinovaManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicTacToeController : ControllerBase
    {
        private readonly ILogger<TicTacToeController> _logger;

        public TicTacToeController(ILogger<TicTacToeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "teste";
        }
    }
}