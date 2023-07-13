using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;
        private readonly IMapper _mapper;
        public WorkLocationController(IWorkLocationService workLocationService, IMapper mapper)
        {
            _workLocationService = workLocationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _workLocationService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddWorkLocation(WorkLocation WorkLocation)
        {
            _workLocationService.TInsert(WorkLocation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWorkLocation(int id)
        {
            var values = _workLocationService.TGetById(id);
            _workLocationService.TDelete(values);
            return Ok();

        }

        [HttpPut]
        public IActionResult UpdateWorkLocation(WorkLocation workLocation)
        {
            var values = _mapper.Map<WorkLocation>(workLocation);
            _workLocationService.TUpdate(workLocation);
            return Ok("Successfully updated!");
        }

        [HttpGet("{id}")]
        public IActionResult GetWorkLocation(int id)
        {
            var values = _workLocationService.TGetById(id);
            return Ok(values);
        }
    }
}
