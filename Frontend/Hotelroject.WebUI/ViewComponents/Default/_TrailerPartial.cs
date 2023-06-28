using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.ViewComponents.Default
{
    public class _TrailerPartial : ViewComponent
    {
         public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
