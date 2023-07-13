using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
