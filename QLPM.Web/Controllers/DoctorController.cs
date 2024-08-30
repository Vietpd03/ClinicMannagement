using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLPM.BLL.Services;
using QLPM.DAL.Models;

namespace QLPM.Web.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorService _service;

        public DoctorController(DoctorService service)
        {
            _service = service;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllDoctors()
        {
            var res = _service.GetAllDoctors();
            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetDoctorById(int id)
        {
            var res = _service.GetDoctorById(id);
            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult CreateDoctor([FromBody] Doctor doctor)
        {
            var res = _service.CreateDoctor(doctor);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult UpdateDoctor([FromBody] Doctor doctor)
        {
            var res = _service.UpdateDoctor(doctor);
            return Ok(res);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var res = _service.DeleteDoctor(id);
            return Ok(res);
        }

        [HttpGet("get-available-schedule/{doctorId}/{date}")]
        public IActionResult GetAvailableSchedule(int doctorId, DateTime date)
        {
            var res = _service.GetAvailableSchedule(doctorId, date);
            return Ok(res);
        }
    }
}
