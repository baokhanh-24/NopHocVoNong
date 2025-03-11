using VoLong_API.DTOs.SinhVienSubject;
using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public interface ISinhVienSubjectRepository
    {
        List<SinhVienSubject> GetListAllSinhVienSubject();

        List<SinhVienSubject> CreateSinhVienSubject(SinhVienSubject sinhVienSubject);
        SinhVienSubject UpdateSinhVienSubject(SinhVienSubject sinhVienSubject);
        bool DeleteSinhVienSubject(SinhVienSubject sinhVienSubject);

        List<SinhVienSubject> GetSinhVienHocBySubjectId(int subjectId);

    }
}
