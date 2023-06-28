using HotelProjectDataAccessLayer.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<PartialViewResult> AddBooking(string x)
        {
            return PartialView();
        }

    }
}
