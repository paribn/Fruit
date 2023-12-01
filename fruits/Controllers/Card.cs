using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
	public class Card : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
