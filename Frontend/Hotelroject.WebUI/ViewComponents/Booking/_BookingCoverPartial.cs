using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.ViewComponents.Booking
{
    public class _BookingCoverPartial : ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
