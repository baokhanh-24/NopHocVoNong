using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoLong_API.DTOs.Lop;
using VoLong_API.DTOs.SinhVien;
using VoLong_API.Services;

namespace VoLong_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopController : ControllerBase
    {
        private readonly ILopService _lopService;

        public LopController(ILopService lopService)
        {
            _lopService = lopService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateOrUpdateLopDTO lop)
        {
            var result = _lopService.AddLop(lop);
            return Ok(result);
        }

        // abc
        [HttpGet("get-all-lop")]
        public IActionResult GetAllLop()
        {
            var result = _lopService.GetAllLop();
            return Ok(result);
        }

        [HttpPut("update-lop")]
        public IActionResult Update([FromBody] CreateOrUpdateLopDTO lop)
        {
            var result = _lopService.UpdateLop(lop);
            return Ok(result);
        }

        [HttpDelete("delete-lop/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _lopService.DeleteLop(id);
            return Ok(result);
        }

        [HttpGet("get-list-lop")]
        public IActionResult GetListSinhVien()
        {
            var result = _lopService.GetListLop();
            return Ok(result);
        }
    }
}
