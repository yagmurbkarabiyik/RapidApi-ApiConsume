using System.ComponentModel.DataAnnotations;

namespace Hotelroject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        [Required(ErrorMessage = "Service ID is required!")]
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Please enter a icon link!")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please enter a service title")]
        [StringLength(100, ErrorMessage = "Service title must be max 100 character!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a service description!")]
        [StringLength(500, ErrorMessage = "Service description must be max 500 character!")]
        public string Description { get; set; }
    }
}
