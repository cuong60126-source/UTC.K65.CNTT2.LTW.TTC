using Microsoft.AspNetCore.Mvc;
using Day04_lab.Models;

namespace Day04_lab.Controllers
{
	public class BookController : Controller
	{
		protected Book book = new Book();
		public IActionResult Index()
		{
			ViewBag.authors = book.Authors;
			ViewBag.Genres = book.Genres;
			var books = book.GetBookList();

			return View(books);
		}
	}
}
