using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Day04_lab.Models
{
	public class Book
	{
		public int id { get; set; }
		public string title { get; set; }
		public int authorId { get; set; }
		public int genreId { get; set; }
		public string image { get; set; }
		public float price { get; set; }
		public int totalPage { get; set; }
		public string sumary { get; set; }
		public List<Book> GetBookList()
		{
			List<Book> books = new List<Book>()
			{
					new Book()
				{
					id = 1,
					title = "Chí Phèo",
					authorId = 1,
					genreId = 1,
					image = "/images/products/b1.jpg",
					price = 500000,
					sumary = "",
					totalPage = 250
				},
				new Book()
				{
					id = 2,
					title = "ronaldo",
					authorId = 2,
					genreId = 2,
					image = "/images/products/b2.jpg",
					price = 2000000,
					sumary = "",
					totalPage = 500
				}
			};

			return books;
		}
		public void AddBook(Book book)
		{
			GetBookList().Add(book);
		}
		public Book GetBookById(int id)
		{
			Book book = this.GetBookList().FirstOrDefault(b => b.id == id);
			return book;
		}
		public List<SelectListItem> Authors { get; } = new List<SelectListItem>
		{
			new SelectListItem {Value = "1", Text = "Nam Cao"},
			new SelectListItem {Value = "2", Text = "Ngô tất tố"}
		};
		public List<SelectListItem> Genres { get; } = new List<SelectListItem>
		{
			new SelectListItem{Value = "1", Text = "Truyện tranh"},
			new SelectListItem{Value = "2", Text = "Văn học đương đại"}
		};

	}
}
