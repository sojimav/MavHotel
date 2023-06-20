using Microsoft.AspNetCore.Mvc;

namespace MavHotel.Controllers
{
    public class AgentsController : Controller
    {
        private readonly ILogger<AgentsController> _logger;
        public AgentsController(ILogger<AgentsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Agents()
        {
            return View();
        }
    }
}
