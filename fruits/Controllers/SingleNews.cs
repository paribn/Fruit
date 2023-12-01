using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
	public class SingleNews : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
