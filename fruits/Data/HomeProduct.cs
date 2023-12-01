
using fruits.Models;

namespace fruits.Data
{
	public class HomeProduct
	{
		public static List<HomePageProduct> GetProducts()
		{
			return new()
			{
				new HomePageProduct
				{
					Id = 1,
					ProductName="Strawberry",
					ImagePath="product-img-1.jpg",
					Price= 23,
				},
				new HomePageProduct
				{
					Id = 2,
					ProductName="Berry",
					ImagePath="product-img-2.jpg",
					Price= 49,
				},new HomePageProduct
				{
					Id = 3,
					ProductName="Lemon",
					ImagePath="product-img-3.jpg",
					Price= 35,
				}

			};
		}
	}
}