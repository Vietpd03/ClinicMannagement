using Microsoft.AspNetCore.Mvc;
using QLPM.BLL.Services;
using QLPM.DAL.Models;

namespace QLPM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly PrescriptionService _service;

        public PrescriptionController(PrescriptionService service)
        {
            _service = service;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllPrescriptions()
        {
            var res = _service.GetAllPrescriptions();
            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetPrescriptionById(int id)
        {
            var res = _service.GetPrescriptionById(id);
            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult CreatePrescription([FromBody] Prescription prescription)
        {
            var res = _service.CreatePrescription(prescription);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult UpdatePrescription([FromBody] Prescription prescription)
        {
            var res = _service.UpdatePrescription(prescription);
            return Ok(res);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeletePrescription(int id)
        {
            var res = _service.DeletePrescription(id);
            return Ok(res);
        }
    }
}
