using Microsoft.AspNetCore.Mvc;
using QLPM.BLL;
using QLPM.BLL.Services;
using QLPM.Common.Req;
using QLPM.Common.Rsp;
using QLPM.DAL.Models;
using System;


namespace QLPM.Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly MedicineService _service;

        public MedicineController(MedicineService service)
        {
            _service = service;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllMedicines()
        {
            var res = _service.GetAllMedicines();
            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetMedicineById(int id)
        {
            var res = _service.GetMedicineById(id);
            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult CreateMedicine([FromBody] Medicine medicine)
        {
            var res = _service.CreateMedicine(medicine);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult UpdateMedicine([FromBody] Medicine medicine)
        {
            var res = _service.UpdateMedicine(medicine);
            return Ok(res);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteMedicine(int id)
        {
            var res = _service.DeleteMedicine(id);
            return Ok(res);
        }
    }
}
