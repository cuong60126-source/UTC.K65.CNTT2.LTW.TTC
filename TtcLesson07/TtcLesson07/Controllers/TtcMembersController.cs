using Microsoft.AspNetCore.Mvc;
using TtcLesson07.Models;

namespace TtcLesson07.Controllers
{
	public class TtcMembersController : Controller
	{
		private static List<TtcMember> TtcMembers = new List<TtcMember>();
		public IActionResult Index()
		{
			return View(TtcMembers);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create (TtcMember ttcMember)
		{
			try
			{
				if(ModelState.IsValid)
				{
					TtcMembers.Add(ttcMember);
					return RedirectToAction(nameof(Index));
					
				}

				return View(ttcMember);
			}
			catch
			{
				return View(ttcMember);
			}
		}
	}
}
