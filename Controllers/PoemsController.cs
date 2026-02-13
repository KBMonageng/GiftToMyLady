using Microsoft.AspNetCore.Mvc;

namespace gifttomylady.Controllers
{
	public class PoemsController : Controller
	{
		public IActionResult Cheesy()
		{
			return View();
		}

		public IActionResult Romantic()
		{
			return View();
		}

		public IActionResult Devilish()
		{
			return View();
		}
	}
}
