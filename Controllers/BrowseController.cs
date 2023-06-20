using Microsoft.AspNetCore.Mvc;

namespace MavHotel.Controllers
{
    public class BrowseController : Controller
    {

        private readonly ILogger<BrowseController> _logger;

        public BrowseController(ILogger<BrowseController> logger)
        {
            _logger = logger;
        }

        public IActionResult Browse()
        {
            return View();
        }
    }
}
