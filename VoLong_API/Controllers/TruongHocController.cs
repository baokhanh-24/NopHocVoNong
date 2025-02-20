using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoLong_API.DTOs.Lop;
using VoLong_API.DTOs.TruongHoc;
using VoLong_API.Services;

namespace VoLong_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruongHocController : ControllerBase
    {
        private readonly ITruongHocService _truongHocService;

        public TruongHocController(ITruongHocService truongHocService)
        {
            _truongHocService = truongHocService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateOrUpdateTruongHocDTO truongHoc)
        {
            var result = _truongHocService.AddTruongHoc(truongHoc);
            return Ok(result);
        }

        // abc
        [HttpGet("get-all-truong-hoc")]
        public IActionResult GetAllTruongHoc()
        {
            var result = _truongHocService.GetAllTruongHoc();
            return Ok(result);
        }

        [HttpPut("update-truong-hoc")]
        public IActionResult UpdateTruongHoc([FromBody] CreateOrUpdateTruongHocDTO truongHoc)
        {
            var result = _truongHocService.UpdateTruongHoc(truongHoc);
            return Ok(result);
        }

        [HttpDelete("delete-truong-hoc/{id}")]
        public IActionResult DeleteTruongHoc(int id)
        {
            var result = _truongHocService.DeleteTruongHoc(id);
            return Ok(result);
        }

        [HttpGet("get-list-truong-hoc")]
        public IActionResult GetListTruongHoc()
        {
            var result = _truongHocService.GetListTruongHoc();
            return Ok(result);
        }
    }
}
