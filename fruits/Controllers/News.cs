using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
	public class News : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
