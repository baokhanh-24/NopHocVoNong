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
    }
}
