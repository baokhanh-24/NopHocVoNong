using VoLong_API.Context;
using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {

        private readonly LopHocContext _context;

        public SubjectRepository(LopHocContext context)
        {
            _context = context;
        }

        public List<Subject> GetListAllSubject()
        {
            var result = _context.subjects.ToList();
            return result;
        }

        public Subject GetSubjectById(int id)
        {
            var result = _context.subjects.FirstOrDefault(x => x.Id == id);
            return result;
        }


        public List<Subject> CreateSubject(Subject subject)
        {
            var subjectAdded = _context.subjects.Add(subject); // chỉ lưu vào bộ nhớ tạm thời

            //để lưu lại dữ liệu vào db
            _context.SaveChanges();

            return _context.subjects.ToList();
        }

        public bool DeleteSubject(Subject subject)
        {
            try
            {
                var subjectDeleted = _context.subjects.Remove(subject);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

        public Subject UpdateSubject(Subject subject)
        {
            var subjectUpdated = _context.subjects.Update(subject);

            _context.SaveChanges();

            return subject;
        }
    }
}
