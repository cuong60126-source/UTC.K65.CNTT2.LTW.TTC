using Microsoft.AspNetCore.Mvc;

namespace TtcLesson09_Lab.Areas.Admins.Controllers
{
	[Area("Admins")]
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
