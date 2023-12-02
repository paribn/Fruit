using fruits.Models;

namespace fruits.Data
{
	public class NewsRepository
	{
		public static List<News> GetNews()
		{
			return new()
			{
				new News
				{
					Id = 1,
					Title="You will vainly look for fruit on it in autumn.",
					Details= "Detailsss",
					//ImagePath="product-img-2.jpg"
				},
				new News
				{
					Id = 2,
					Title="You will vainly look for fruit on it in autumn.",
					Details= "Detailsss",
					//ImagePath="product-img-2.jpg"
				},new News
				{
					Id = 3,
					Title="You will vainly look for fruit on it in autumn.",
					Details= "Detailsss",
					//ImagePath="product-img-2.jpg"
				},
				new News
				{
					Id = 4,
					Title="You will vainly look for fruit on it in autumn.",
					Details= "Detailsss",
					//ImagePath="product-img-2.jpg"
				},new News
				{
					Id = 5,
					Title="You will vainly look for fruit on it in autumn.",
					Details= "Detailsss",
					//ImagePath="product-img-2.jpg"
				},new News
				{
					Id = 6,
					Title="You will vainly look for fruit on it in autumn.",
					Details= "Detailsss",
					//ImagePath="product-img-2.jpg"
				},


			};
		}
	}
}
