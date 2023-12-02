using fruits.Data;
using fruits.ViewModels;
using Microsoft.AspNetCore.Mvc;
using fruits.Models;

namespace fruits.Controllers
{
	public class NewsController : Controller
	{

		List<News> _news;

		public NewsController()
		{
			_news = NewsRepository.GetNews();
		}

		public IActionResult Index()
		{
			NewsIndexVM model = new()
			{
				News = _news
			};

			return View(model);
		}

		public IActionResult SingleNews()
		{

			NewsIndexVM model = new()
			{
				News = _news
			};
			return View();
		}
	}
}

