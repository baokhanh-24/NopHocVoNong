using VoLong_API.DTOs.Subject;
using VoLong_API.Entities;
using VoLong_API.Repositories;

namespace VoLong_API.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public List<Subject> AddSubject(CreateOrUpdateSubjectDTO subjectDTO)
        {
            Subject subjectDB = new Subject();


            subjectDB.Name = subjectDTO.Name;
            subjectDB.Code = subjectDTO.Code;
            subjectDB.CreationDate = subjectDTO.CreationDate;


            var result = _subjectRepository.CreateSubject(subjectDB);
            return result;
        }

        public bool DeleteSubject(int id)
        {
            var lstAllSubject = _subjectRepository.GetListAllSubject();

            var subjectToDelete = lstAllSubject.FirstOrDefault(x => x.Id == id);

            if (subjectToDelete is null)
            {
                return false;
            }

            var result = _subjectRepository.DeleteSubject(subjectToDelete);
            return result;
        }

        public List<Subject> GetAllSubject()
        {
            return _subjectRepository.GetListAllSubject();
        }

        public List<SubjectDTO> GetListSubject()
        {
            throw new NotImplementedException();
        }

        public Subject UpdateSubject(CreateOrUpdateSubjectDTO subjectDTO)
        {
            Subject subjectDB = new Subject();

            subjectDTO.Id = subjectDTO.Id;
            subjectDB.Name = subjectDTO.Name;
            subjectDB.Code = subjectDTO.Code;
            subjectDB.CreationDate = subjectDTO.CreationDate;

            var result = _subjectRepository.UpdateSubject(subjectDB);
            return result;
        }
    }
}
