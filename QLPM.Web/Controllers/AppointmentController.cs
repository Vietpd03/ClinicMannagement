using Microsoft.AspNetCore.Mvc;
using QLPM.BLL.Services;
using QLPM.DAL.Models;

namespace QLPM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly AppointmentService _service;

        public AppointmentController(AppointmentService service)
        {
            _service = service;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllAppointments()
        {
            var res = _service.GetAllAppointments();
            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetAppointmentById(int id)
        {
            var res = _service.GetAppointmentById(id);
            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult CreateAppointment([FromBody] Appointment appointment)
        {
            var res = _service.CreateAppointment(appointment);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult UpdateAppointment([FromBody] Appointment appointment)
        {
            var res = _service.UpdateAppointment(appointment);
            return Ok(res);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteAppointment(int id)
        {
            var res = _service.DeleteAppointment(id);
            return Ok(res);
        }
    }
}
