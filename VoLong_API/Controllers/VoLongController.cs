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
    }
}
