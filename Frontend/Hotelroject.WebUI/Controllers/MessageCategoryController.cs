using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
