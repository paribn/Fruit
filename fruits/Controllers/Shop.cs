using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
    public class Shop : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
