using Microsoft.AspNetCore.Mvc;
using Day04_lab.Models;

namespace Day04_lab.ViewComponents
{
	public class BookViewComponent : ViewComponent
	{
		protected Book book = new Book();
		public IViewComponentResult Invoke()
		{
			var books = book.GetBookList();
			return View(books);
		}
	}
}