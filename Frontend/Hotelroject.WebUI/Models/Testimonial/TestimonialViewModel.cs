using Microsoft.AspNetCore.Mvc;

namespace Hotelroject.WebUI.Models.Testimonial
{
    public class TestimonialViewModel : Controller
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
