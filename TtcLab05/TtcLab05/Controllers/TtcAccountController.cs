using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using TtcLab05.Models;

namespace TtcLab05.Controllers
{
	public class TtcAccountController : Controller
	{
		[AcceptVerbs("GET", "POST")]
		public IActionResult TtcVerifyPhone(string phone)
		{
			Regex _isPhone = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
			if(! _isPhone.IsMatch(phone))
			{
				return Json($"Số điện thoại {phone} không đúng định dạng");
			}

			return Json(true);
		}

		// GET: TtcAccountController
		public ActionResult TtcIndex()
		{
			List<TtcAccount> accounts = new List<TtcAccount>();
			return View(accounts);
		}

		// GET: TtcAccountController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: TtcAccountController/Create
		public ActionResult TtcCreate()
		{
			TtcAccount model = new TtcAccount();
			return View(model);
		}

		// POST: TtcAccountController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult TtcCreate(TtcAccount account)
		{
			if(ModelState.IsValid)
			{
				return RedirectToAction(nameof(TtcIndex));
			}

			return View(account);

		}

		// GET: TtcAccountController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: TtcAccountController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(TtcIndex));
			}
			catch
			{
				return View();
			}
		}

		// GET: TtcAccountController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: TtcAccountController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(TtcIndex));
			}
			catch
			{
				return View();
			}
		}
	}
}
