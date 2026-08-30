using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using TtcLesson03MVC.Models;

namespace TtcLesson03MVC.Controllers
{
	public class TtcAccountController : Controller
	{
		public IActionResult Index()
		{
			List<TtcAccount> accounts = new List<TtcAccount>
			{
				new TtcAccount()
				{
					Id = 1,Name="Hoàng Anh",
					Email="anh@gmail.com",
					Phone="0986456789",
					Address="Hà Nội",
					Avatar= Url.Content("~/Avatar/02.jfif"),
					Gender=1, Bio="My name is small",
					Birthday= new DateTime(1998,7,15)
				},
				new TtcAccount()
				{
					Id = 1,Name="Trường Giang",
					Email="giang@gmail.com",
					Phone="0986456789",
					Address="Hà Nội",
					Avatar= Url.Content("~/Avatar/03.jfif"),
					Gender=1, Bio="My name is small",
					Birthday= new DateTime(1998,7,15)
				},
				new TtcAccount()
				{
					Id = 1,Name="Hoàng Thúy",
					Email="thuy@gmail.com",
					Phone="0986456789",
					Address="Hà Nội",
					Avatar= Url.Content("~/Avatar/04.jfif"),
					Gender=1, Bio="My name is small",
					Birthday= new DateTime(1998,7,15)
				}
			};

			ViewBag.Accounts = accounts;

			return View();
		}
	}
}
