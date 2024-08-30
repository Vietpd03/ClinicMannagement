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
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet("get-all")]
        public IActionResult GetAllUsers()
        {
            var res = _service.GetAllUsers();
            return Ok(res);
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetUserById(int id)
        {
            var res = _service.GetUserById(id);
            return Ok(res);
        }

        [HttpPost("create")]
        public IActionResult CreateUser([FromBody] User user)
        {
            var res = _service.CreateUser(user);
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            var res = _service.UpdateUser(user);
            return Ok(res);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var res = _service.DeleteUser(id);
            return Ok(res);
        }
    }
}
