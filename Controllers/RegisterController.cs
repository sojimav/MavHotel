using Microsoft.AspNetCore.Mvc;

namespace MavHotel.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ILogger<RegisterController> _logger;
        public RegisterController(ILogger<RegisterController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
