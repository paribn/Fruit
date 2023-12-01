using fruits.Models;

namespace fruits.Data
{
	public class ProductRepository
	{
		public static List<Product> GetProducts()
		{
			return new()
			{
				new Product
				{
					Id = 1,
					ProductName="Strawberry",
					ImagePath="product-img-1.jpg",
					Price= 23,
				},
				new Product
				{
					Id = 2,
					ProductName="Berry",
					ImagePath="product-img-2.jpg",
					Price= 49,
				},new Product
				{
					Id = 3,
					ProductName="Lemon",
					ImagePath="product-img-3.jpg",
					Price= 35,
				},new Product
				{
					Id = 4,
					ProductName="Avocado",
					ImagePath="product-img-4.jpg",
					Price= 89,
				},new Product
				{
					Id = 5,
					ProductName="Green Apple",
					ImagePath="product-img-5.jpg",
					Price= 45,
				},new Product
				{
					Id = 6,
					ProductName="Berry",
					ImagePath="product-img-6.jpg",
					Price= 109,
				},


			};
		}
	}
}
