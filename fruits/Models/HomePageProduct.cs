namespace fruits.Models
{
	public class HomePageProduct
	{
		public int Id { get; set; }
		public string ProductName { get; set; } = null!;
		public string ImagePath { get; set; } = null!;
		public decimal Price { get; set; }
	}
}
