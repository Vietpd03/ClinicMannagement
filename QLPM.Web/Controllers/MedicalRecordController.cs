using Microsoft.AspNetCore.Mvc;
using QLPM.BLL.Services;
using QLPM.DAL.Models;

namespace QLPM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRecordController : ControllerBase
    {
        private readonly MedicalRecordService _service;

        public MedicalRecordController(MedicalRecordService service)
        {
            _service = service;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllMedicalRecords()
        {
            var res = _service.GetAllMedicalRecords();
            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetMedicalRecordById(int id)
        {
            var res = _service.GetMedicalRecordById(id);
            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult CreateMedicalRecord([FromBody] MedicalRecord medicalRecord)
        {
            var res = _service.CreateMedicalRecord(medicalRecord);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult UpdateMedicalRecord([FromBody] MedicalRecord medicalRecord)
        {
            var res = _service.UpdateMedicalRecord(medicalRecord);
            return Ok(res);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteMedicalRecord(int id)
        {
            var res = _service.DeleteMedicalRecord(id);
            return Ok(res);
        }
    }
}
