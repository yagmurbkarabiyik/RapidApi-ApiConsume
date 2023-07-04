using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.ViewComponents.Contact
{
    public class _ContactCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
