using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
