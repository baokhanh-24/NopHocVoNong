using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public interface ISubjectRepository
    {
        List<Subject> GetListAllSubject();
        Subject GetSubjectById(int id);
        List<Subject> CreateSubject(Subject subject);
        Subject UpdateSubject(Subject subject);
        bool DeleteSubject(Subject subject);
    }
}
