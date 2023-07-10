using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProjectEntityLayer.Concrete;
using Hotelroject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;
        public GuestController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.TInsert(guest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var values = _guestService.TGetById(id);
            _guestService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            var values = _mapper.Map<Guest>(guest);
            _guestService.TUpdate(guest);
            return Ok("Successfully updated!");
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _guestService.TGetById(id);
            return Ok(values);
        }
    }
}
