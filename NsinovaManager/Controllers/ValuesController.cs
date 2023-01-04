using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NsinovaManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "teste";
        }
    }
}
