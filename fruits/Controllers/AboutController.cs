using fruits.Data;
using fruits.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{

			var ViewModel = new AboutIndexVM
			{
				Testimonials = TestimonialRepository.GetTestimonials()

			};
			return View(ViewModel);
		}
	}
}
