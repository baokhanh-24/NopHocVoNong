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

        public List<SinhVienSubject> CreateSinhVienSubject(SinhVienSubject sinhVienSubject)
        {
            var sinhVienSubjectAdded = _context.SinhVienSubjects.Add(sinhVienSubject); // chỉ lưu vào bộ nhớ tạm thời

            //để lưu lại dữ liệu vào db
            _context.SaveChanges();

            return _context.SinhVienSubjects.ToList();
        }

        public bool DeleteSinhVienSubject(SinhVienSubject sinhVienSubject)
        {
            try
            {
                var sinhVienSubjectDeleted = _context.SinhVienSubjects.Remove(sinhVienSubject);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

        public List<SinhVienSubject> GetListAllSinhVienSubject()
        {
            var result = _context.SinhVienSubjects.ToList();
            return result;
        }


        public SinhVienSubject UpdateSinhVienSubject(SinhVienSubject sinhVienSubject)
        {
            var sinhVienSubjectUpdated = _context.SinhVienSubjects.Update(sinhVienSubject);

            _context.SaveChanges();

            return sinhVienSubject;
        }


        public List<SinhVienSubject> GetSinhVienHocBySubjectId(int subjectId)
        {
            return _context.SinhVienSubjects.Where(c => c.SubjectId == subjectId).ToList();
        }
    }
}
