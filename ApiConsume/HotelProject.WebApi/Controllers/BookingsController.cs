using HotelProject.BusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Hotelroject.WebUI.Dtos.GuestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }

        [HttpGet("LastFiveBooking")]
        public IActionResult LastFiveBooking()
        {
            var values = _bookingService.TGetLastFiveBookings();
            return Ok(values);
        }

        [HttpGet("BookingApproved")]
        public IActionResult BookingApproved(int id)
        {
            _bookingService.TBookingStatusChangeApproved3(id);
            return Ok();
        }

        [HttpGet("BookingCancelled")]
        public IActionResult BookingCancelled(int id)
        {
            _bookingService.TBookingStatusChangeCancelled(id);
            return Ok();
        }

        [HttpGet("BookingWait")]
        public IActionResult BookingWait(int id)
        {
            _bookingService.TBookingStatusChangeCancelled(id);
            return Ok();
        }
    }
}

