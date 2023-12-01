using fruits.Data;
using fruits.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace fruits.Controllers
{
	public class Cart : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult AddToBasket(int id) 
		{
			var foundProduct =ProductRepository.GetProducts().FirstOrDefault(x => x.Id == id);
			if (foundProduct != null) { return NotFound(); }

			List<BasketItem> basketItemsList;
			var newBasketItem = new BasketItem
			{
				ProductId = id,
				Count=1

			};
			 Request.Cookies.TryGetValue("Cart", out string? existingBasket);

			if(!string.IsNullOrWhiteSpace(existingBasket))
			{
				basketItemsList = JsonSerializer.Deserialize<List<BasketItem>>(existingBasket);

			}
			else
			{
				basketItemsList = new();
			}

			basketItemsList.Add(newBasketItem);

			Response.Cookies.Append("cart", JsonSerializer.Serialize(basketItemsList));

			return RedirectToAction("Index","Shop");
		
		}
	}
}
