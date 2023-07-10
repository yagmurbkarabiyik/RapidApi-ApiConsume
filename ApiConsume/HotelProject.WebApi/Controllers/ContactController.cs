using HotelProject.BusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);
            return Ok();
        }

        [HttpGet]
        public IActionResult InboxListContactI()
        {
            var values = _contactService.GetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactService.GetList();
            return Ok(values);
        }
    }
}
