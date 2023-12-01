using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
