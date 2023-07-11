
using System.ComponentModel.DataAnnotations;

namespace Hotelroject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Required field!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required field!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Required field!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Required field!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Required field!")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Required field!")]
        [Compare("Password", ErrorMessage ="Passwords does not match!")]
        public string ConfirmPassword { get; set; }



	}
}
