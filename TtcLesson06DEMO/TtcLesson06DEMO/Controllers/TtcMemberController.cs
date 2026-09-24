using Microsoft.AspNetCore.Mvc;
using TtcLesson06DEMO.Models;

namespace TtcLesson06DEMO.Controllers
{
	public class TtcMemberController : Controller
	{
		//mock data
		private static readonly List<TtcMember> _TtcMembers = new List<TtcMember>
		{
			new TtcMember()
				{
					TtcMemberId = Guid.NewGuid().ToString(),
					TtcMemberUserName = "Cuong123",
					TtcMemberPassword = "123456",
					TtcMemberEmail = "cuong@gmail.com",
					TtcMemberFullName = "Trương Tuấn Cường"
				},

				new TtcMember()
				{
					TtcMemberId = Guid.NewGuid().ToString(),
					TtcMemberUserName = "Ronaldo",
					TtcMemberPassword = "ronaldo7",
					TtcMemberEmail = "ronaldo@gmail.com",
					TtcMemberFullName = "Cristiano Ronaldo"
				},

				new TtcMember()
				{
					TtcMemberId = Guid.NewGuid().ToString(),
					TtcMemberUserName = "Messi10",
					TtcMemberPassword = "messi10",
					TtcMemberEmail = "messi@gmail.com",
					TtcMemberFullName = "Lionel Messi"
				},

				new TtcMember()
				{
					TtcMemberId = Guid.NewGuid().ToString(),
					TtcMemberUserName = "NeymarJR",
					TtcMemberPassword = "neymar10",
					TtcMemberEmail = "neymar@gmail.com",
					TtcMemberFullName = "Neymar Junior"
				},

				new TtcMember()
				{
					TtcMemberId = Guid.NewGuid().ToString(),
					TtcMemberUserName = "Mbappe",
					TtcMemberPassword = "mbappe9",
					TtcMemberEmail = "mbappe@gmail.com",
					TtcMemberFullName = "Kylian Mbappe"
				}
		};
		public IActionResult TtcIndex()
		{

			return View(_TtcMembers);
		}
		public IActionResult TtcCreate()
		{
			return View();
		}

		[HttpPost]
		public IActionResult TtcCreate(TtcMember TtcMember)
		{
			TtcMember.TtcMemberId = Guid.NewGuid().ToString();
			_TtcMembers.Add(TtcMember);
			return RedirectToAction("TtcIndex");
		}

		public IActionResult TtcEdit(string id)
		{
			var ttcMember = _TtcMembers.FirstOrDefault(x => x.TtcMemberId.Equals(id));
			return View(ttcMember);
		}

		[HttpPost]
		public IActionResult TtcEdit(string id, TtcMember TtcMember)
		{
			for(int i = 0; i < _TtcMembers.Count(); i++)
			{
				if (_TtcMembers[i].TtcMemberId == id)
				{
					_TtcMembers[i].TtcMemberId = TtcMember.TtcMemberId;
					_TtcMembers[i].TtcMemberUserName = TtcMember.TtcMemberUserName;
					_TtcMembers[i].TtcMemberPassword = TtcMember.TtcMemberPassword;
					_TtcMembers[i].TtcMemberFullName = TtcMember.TtcMemberFullName;
					_TtcMembers[i].TtcMemberEmail = TtcMember.TtcMemberEmail;

					break;
				}
			}
			return RedirectToAction("TtcIndex");
		}
		public IActionResult TtcGetDetails()
		{
			var TtcMember = new TtcMember()
			{
				TtcMemberId = Guid.NewGuid().ToString(),
				TtcMemberUserName = "CuongTruong",
				TtcMemberPassword = "ronaldo",
				TtcMemberFullName = "Trương Tuấn Cường",
				TtcMemberEmail = "cuong60126@gmail.com"

			};
			return View(TtcMember);
		}
	}
}
