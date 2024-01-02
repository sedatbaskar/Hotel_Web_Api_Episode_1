using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelWebProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]

        public IActionResult StaffList()
        {
            var values=_staffService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff()
        {
            //var values = _staffService.TInsert();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff()
        {
            return Ok();
        }



    }
}
