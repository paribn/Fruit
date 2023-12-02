using fruits.Models;

namespace fruits.Data
{
	public class TestimonialRepository
	{
		public static List<Testimonial> GetTestimonials()
		{
			return new()
			{
				new Testimonial
				{
					Id = 1,
					Name="Saira Hakim",
					Position="Local shop owner",
					Details= "\" Sed ut perspiciatis unde omnis iste natus error veritatis et  quasi architecto beatae vitae dict eaque ipsa quae ab illo" +
					" inventore Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium \"",
					ImagePath="avatar1.png"
				},
				new Testimonial
				{
					Id = 2,
					Name="David Niph ",
					Position="Local shop owner",
					Details= "\" Sed ut perspiciatis unde omnis iste natus error veritatis et  quasi architecto beatae vitae dict eaque ipsa quae ab illo" +
					" inventore Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium \"",
					ImagePath="avatar2.png"

				},new Testimonial
				{
					Id = 3,
					Name="David Niph",
					Position="Local shop owner",
					Details= "\" Sed ut perspiciatis unde omnis iste natus error veritatis et  quasi architecto beatae vitae dict eaque ipsa quae ab illo" +
					" inventore Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium \"",
					ImagePath="avatar3.png"

				}

			};
		}
	}
}
