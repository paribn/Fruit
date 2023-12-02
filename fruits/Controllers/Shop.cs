using fruits.Data;
using fruits.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace fruits.Controllers
{
    public class Shop : Controller
    {
        public IActionResult Index()
        {

			var ViewModel = new ShopIndexVM
			{
				Product = ProductRepository.GetProducts()
			};

			return View(ViewModel);
        }

        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}
