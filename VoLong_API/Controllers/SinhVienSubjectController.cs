using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoLong_API.Services;

namespace VoLong_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienSubjectController : ControllerBase
    {
        private readonly ISinhVienSubjectService _service;

        public SinhVienSubjectController(ISinhVienSubjectService service)
        {
            _service = service;
        }

        [HttpGet("get-list-all-sinh-vien-subject")]
        public IActionResult GetAllSinhVienSubject()
        {
            var result = _service.GetListAllSinhVienSubject();
            return Ok(result);
        }
    }
}
