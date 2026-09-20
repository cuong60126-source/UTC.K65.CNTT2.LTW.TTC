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
			ViewBag.genres = book.Genres;
			var books = book.GetBookList();

			return View(books);
		}
		public IActionResult Create()
		{
			ViewBag.authors = book.Authors;
			ViewBag.genres = book.Genres;
			Book model = new Book();
			return View(model);
		}
		[HttpPost]
		public IActionResult Create(Book model)
		{
			book.AddBook(model);
			return RedirectToAction("Index");
		}
		public IActionResult Edit(int id)
		{
			ViewBag.authors = book.Authors;
			ViewBag.genres = book.Genres;
			Book model = book.GetBookById(id);
			return View(model);
		}
		public PartialViewResult PopularBook()
		{
			var books = book.GetBookList();
			return PartialView(books);
		}
	}
}
