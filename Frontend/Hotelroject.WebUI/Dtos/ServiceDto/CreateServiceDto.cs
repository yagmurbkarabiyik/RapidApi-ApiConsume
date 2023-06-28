
using System.ComponentModel.DataAnnotations;

namespace Hotelroject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Please enter a icon link!")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please enter a service title")]
        [StringLength(100, ErrorMessage ="Service title must be max 100 character!")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
