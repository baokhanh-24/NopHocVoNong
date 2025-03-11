using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VoLong_API.DTOs.SinhVien;
using VoLong_API.DTOs.Subject;
using VoLong_API.Services;

namespace VoLong_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }


        // abc
        [HttpGet("get-all-subject")]
        public IActionResult GetAllSubject()
        {
            var result = _subjectService.GetAllSubject();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateOrUpdateSubjectDTO subjectDTO)
        {
            var result = _subjectService.AddSubject(subjectDTO);
            return Ok(result);
        }

        [HttpDelete("delete-subject/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _subjectService.DeleteSubject(id);
            return Ok(result);
        }

        [HttpPut("update-subject")]
        public IActionResult Update([FromBody] CreateOrUpdateSubjectDTO subjectDTO)
        {
            var result = _subjectService.UpdateSubject(subjectDTO);
            return Ok(result);
        }


    }
}
