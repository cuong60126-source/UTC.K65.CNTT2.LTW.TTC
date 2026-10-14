using Microsoft.AspNetCore.Mvc;

namespace TtcLesson09_Lab.Areas.Admins.Controllers
{
	public class DashboardController : Controller
	{
		[Area("Admins")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
