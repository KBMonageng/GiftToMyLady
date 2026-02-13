using Microsoft.AspNetCore.Mvc;

namespace gifttomylady.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
