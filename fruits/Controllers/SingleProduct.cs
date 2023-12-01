using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
	public class SingleProduct : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
