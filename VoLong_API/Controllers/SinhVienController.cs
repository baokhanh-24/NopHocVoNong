using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoLong_API.Entities;
using VoLong_API.Services;

namespace VoLong_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        // DI
        private readonly ISinhVienService _sinhVienService;

        public SinhVienController(ISinhVienService sinhVienService)
        {
            _sinhVienService = sinhVienService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] SinhVien sinhVien)
        {
            var result = _sinhVienService.AddSinhVien(sinhVien);
            return Ok(result);
        }
    }
}
