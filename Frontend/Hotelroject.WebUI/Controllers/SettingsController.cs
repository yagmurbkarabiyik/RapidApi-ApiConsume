using HotelProjectEntityLayer.Concrete;
using Hotelroject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditVİewModel userEditVİewModel = new UserEditVİewModel();
            userEditVİewModel.Name= user.Name;  
            userEditVİewModel.Surname= user.Surname;    
            userEditVİewModel.UserName= user.UserName;  
            userEditVİewModel.Email= user.Email;    
            return View(userEditVİewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditVİewModel userEditVİewModel)
        {
            if (userEditVİewModel.Password == userEditVİewModel.Password)
            {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = userEditVİewModel.Name;
            user.Surname = userEditVİewModel.Surname;
            user.Email = userEditVİewModel.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditVİewModel.Password);
            await _userManager.UpdateAsync(user);

            return RedirectToAction("Index");
            }
            return View();
        }
    }
}
