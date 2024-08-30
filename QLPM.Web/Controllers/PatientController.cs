using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLPM.BLL.Services;
using QLPM.Common.Req;
using QLPM.DAL.Models;

namespace QLPM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientService _service;

        public PatientController(PatientService service)
        {
            _service = service;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllPatients()
        {
            var res = _service.GetAllPatients();
            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetPatientById(int id)
        {
            var res = _service.GetPatientById(id);
            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult CreatePatient([FromBody] Patient patient)
        {
            var res = _service.CreatePatient(patient);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult UpdatePatient([FromBody] Patient patient)
        {
            var res = _service.UpdatePatient(patient);
            return Ok(res);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeletePatient(int id)
        {
            var res = _service.DeletePatient(id);
            return Ok(res);
        }

        [HttpPost("register-appointment")]
        public IActionResult RegisterAppointment([FromBody] AppointmentReq req)
        {
            var res = _service.RegisterAppointment(req);
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
