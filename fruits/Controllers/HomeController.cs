using fruits.Data;
using fruits.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			var ViewModel = new HomeIndexVM
			{
				Product =HomeProduct.GetProducts(),
				Testimonials=TestimonialRepository.GetTestimonials()
				
			};

			return View(ViewModel);

		}
		

	}
}