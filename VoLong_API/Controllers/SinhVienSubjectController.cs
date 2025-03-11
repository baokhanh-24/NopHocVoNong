using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoLong_API.DTOs.SinhVienSubject;
using VoLong_API.DTOs.Subject;
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

        [HttpPost]
        public IActionResult Post([FromBody] CreateOrUpdateSinhVienSubjectDTO sinhVienSubjectDTO)
        {
            var result = _service.AddSinhVienSubject(sinhVienSubjectDTO);
            return Ok(result);
        }

        [HttpDelete("delete-sinh-vien-subject/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.DeleteSinhVienSubject(id);
            return Ok(result);
        }

        [HttpPut("update-sinh-vien-subject")]
        public IActionResult Update([FromBody] CreateOrUpdateSinhVienSubjectDTO sinhVienSubjectDTO)
        {
            var result = _service.UpdateSinhVienSubject(sinhVienSubjectDTO);
            return Ok(result);
        }

        [HttpGet("get-list-sinh-vien-by-subjectid/{id}")]
        public IActionResult GetSinhVienBySubjectId(int id)
        {
            var result = _service.GetListSinhVienBySubjectId(id);
            return Ok(result);
        }

        [HttpGet("get-list-subject-by-sinhvienid/{id}")]
        public IActionResult GetSubjectBySinhVienId(int id)
        {
            var result = _service.GetListSubjectBySinhVienId(id);
            return Ok(result);
        }
    }
}
