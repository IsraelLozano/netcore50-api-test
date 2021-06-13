using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjectTest.API.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Initial Home Get by Ilozano AZURE vfinal ");
            return "Net Core 5.0 Running ... 12062021-v15 AZURE ilozano vfinal 1234 ";
        }
    }
}
