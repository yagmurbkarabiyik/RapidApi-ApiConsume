
using System.ComponentModel.DataAnnotations;

namespace Hotelroject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage="Please enter user name!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password!")]
        public string Password { get; set; }
    }
}
