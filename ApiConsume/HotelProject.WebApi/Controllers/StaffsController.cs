using HotelProject.BusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Hotelroject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffsController : ControllerBase
	{
		private readonly IStaffService _staffService;

		public StaffsController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			var values = _staffService.TGetList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult AddStaff(Staff staff)
		{
			_staffService.TInsert(staff);	
			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteStaff(int id)
		{
			var values = _staffService.TGetById(id);
			_staffService.TDelete(values);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.TUpdate(staff);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetStaff(int id)
		{
			var values = _staffService.TGetById(id);
			return Ok(values);
		}

        [HttpGet("LastFourStaff")]
        public IActionResult LastFourStaff()
        {
            var values = _staffService.TLastFourStaff();
			return Ok(values);	
        }


    }
}
