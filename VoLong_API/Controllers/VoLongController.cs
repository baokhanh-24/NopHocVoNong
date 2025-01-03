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
        // Khởi tạo biến toàn cục
        private readonly SinhVienServices _SinhVienServices;

        public VoLongController(SinhVienServices services)
        {
            _SinhVienServices = services;
        }

        [HttpPost]
        public IActionResult Post([FromBody] SinhVien sinhVien)
        {
            var result = _SinhVienServices.AddSinhVien(sinhVien);
            return Ok(result);  
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id,[FromBody] SinhVien sinhVien)
        {
            var result = _SinhVienServices.UpdateSinhVien(id,sinhVien);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _SinhVienServices.DeleteSinhVien(id);
            return Ok(result);
        }


        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            var result = _SinhVienServices.GetAllSinhVien();
            return Ok(result);
        }

        [HttpGet("get-by-name/{name}")]
        public IActionResult FindByName(string name)
        {
            var result = _SinhVienServices.FindByName(name);
            return Ok(result);
        }

        [HttpGet("get-by-email/{email}")]
        public IActionResult FindByEmail(string email)
        {
            var result = _SinhVienServices.FindByEmail(email);
            return Ok(result);
        }
    }
}
