using Microsoft.AspNetCore.Mvc;

namespace TtcLesson03MVC.Controllers
{
	public class TtcController : Controller
	{
		public IActionResult Index()
		{
			return View("TtcAbout");
		}
	}
}
