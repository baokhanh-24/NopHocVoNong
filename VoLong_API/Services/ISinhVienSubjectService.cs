using VoLong_API.DTOs.SinhVienSubject;
using VoLong_API.DTOs.Subject;
using VoLong_API.Entities;

namespace VoLong_API.Services
{
    public interface ISinhVienSubjectService
    {
        List<SinhVienSubjectDTO> GetListAllSinhVienSubject();
        List<SinhVienSubject> AddSinhVienSubject(CreateOrUpdateSinhVienSubjectDTO sinhVienSubjectDTO);
        SinhVienSubject UpdateSinhVienSubject(CreateOrUpdateSinhVienSubjectDTO sinhVienSubjectDTO);
        bool DeleteSinhVienSubject(int id);
        List<SinhVienSubjectDTO> GetListSubjectBySinhVienId(int SinhVienId);
        List<SinhVienSubjectDTO> GetListSinhVienBySubjectId(int SubjectId);
    }
}
