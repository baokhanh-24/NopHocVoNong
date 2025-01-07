using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoLong_API.Entities;
using VoLong_API.Services;

namespace VoLong_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoLongController : ControllerBase
    {
        private readonly ISinhVienService _sinhVienService;

        public VoLongController(ISinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] SinhVien sinhVien)
        {
            var result = _sinhVienService.AddSinhVien(sinhVien);
            return Ok(result);
        }

        // abc
        [HttpGet("get-all-sinh-vien")]
        public IActionResult GetAllSinhVien()
        {
            var result = _sinhVienService.GetAllSinhVien();
            return Ok(result);
        }

        [HttpPut("update-sv/{id}")]
        public IActionResult Update(int id,[FromBody] SinhVien sinhVien)
        {
            var result = _sinhVienService.UpdateSinhVien(id, sinhVien);
            return Ok(result);
        }

        [HttpDelete("delete-sv/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _sinhVienService.DeleteSinhVien(id);
            return Ok(result);
        }

        [HttpGet("get-sinh-vien-by-name/{name}")]
        public IActionResult GetSinhVienByName(string name)
        {
            var result = _sinhVienService.FindByName(name);
            return Ok(result);
        }
    }
}
