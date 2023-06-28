using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
