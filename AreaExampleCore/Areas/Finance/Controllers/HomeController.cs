using Microsoft.AspNetCore.Mvc;

namespace AreaExampleCore.Areas.Finance.Controllers
{
    [Area("Finance")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
