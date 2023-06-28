using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult _AdminLayouts()
		{
			return View();
		}

		public PartialViewResult HeadPartial()
		{
			return PartialView();
		}

        public PartialViewResult PreLoaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavHeaderPartial()
        {
            return PartialView();
        }
       
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
