using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
