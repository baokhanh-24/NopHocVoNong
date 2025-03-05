using VoLong_API.Context;
using VoLong_API.DTOs.SinhVienSubject;
using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public class SinhVienSubjectRepository : ISinhVienSubjectRepository
    {
        private readonly LopHocContext _context;

        public SinhVienSubjectRepository(LopHocContext context)
        {
            _context = context;
        }

        public List<SinhVienSubject> GetListAllSinhVienSubject()
        {
            var result = _context.SinhVienSubjects.ToList();
            return result;
        }
    }
}
