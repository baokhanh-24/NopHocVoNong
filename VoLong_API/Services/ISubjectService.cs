using VoLong_API.DTOs.SinhVien;
using VoLong_API.DTOs.Subject;
using VoLong_API.Entities;

namespace VoLong_API.Services
{
    public interface ISubjectService
    {
        List<Subject> AddSubject(CreateOrUpdateSubjectDTO subjectDTO);
        Subject UpdateSubject(CreateOrUpdateSubjectDTO subjectDTO);
        bool DeleteSubject(int id);
        List<Subject> GetAllSubject();
        List<SubjectDTO> GetListSubject();
    }
}
