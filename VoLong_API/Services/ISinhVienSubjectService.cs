using VoLong_API.DTOs.SinhVienSubject;

namespace VoLong_API.Services
{
    public interface ISinhVienSubjectService
    {
        List<SinhVienSubjectDTO> GetListAllSinhVienSubject();
        List<SinhVienSubjectDTO> GetListSubjectBySinhVienId(int SinhVienId);
        List<SinhVienSubjectDTO> GetListSinhVienBySubjectId(int SubjectId);
    }
}
