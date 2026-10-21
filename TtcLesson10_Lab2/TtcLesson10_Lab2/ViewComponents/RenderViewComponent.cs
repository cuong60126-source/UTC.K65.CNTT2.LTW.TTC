using Microsoft.AspNetCore.Mvc;
using TtcLesson10_Lab2.Models;

namespace TtcLesson10_Lab2.ViewComponents
{
	public class RenderViewComponent : ViewComponent
	{
		private readonly List<MenuItem> MenuItems = new List<MenuItem>()
		{
			new MenuItem { Id = 1, Name = "Trang chủ", Link = "/" },
			new MenuItem { Id = 2, Name = "Privacy", Link = "/Home/Privacy" },
			new MenuItem { Id = 3, Name = "Sinh viên", Link = "#" },
			new MenuItem { Id = 4, Name = "Môn học", Link = "#" }
		};

		public IViewComponentResult Invoke()
		{
			return View("RenderLeftMenu", MenuItems);
		}
	}
}
