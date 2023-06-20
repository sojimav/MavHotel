using Microsoft.AspNetCore.Mvc;

namespace MavHotel.Controllers
{
    public class StoriesController : Controller
    {
        private readonly ILogger<StoriesController> _logger;
        public StoriesController(ILogger<StoriesController> logger)
        {
            _logger = logger;
        }


        public IActionResult Stories()
        {
            return View();
        }
    }
}
