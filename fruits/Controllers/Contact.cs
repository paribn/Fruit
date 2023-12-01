using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
	public class Contact : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
