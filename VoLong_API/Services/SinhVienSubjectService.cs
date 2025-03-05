using VoLong_API.DTOs.SinhVienSubject;
using VoLong_API.Repositories;

namespace VoLong_API.Services
{
    public class SinhVienSubjectService : ISinhVienSubjectService
    {
        private readonly ISinhVienSubjectRepository _repository;

        private readonly ISinhVienRepository _sinhVienRepository;

        private readonly ISubjectRepository _subjectRepository;

        public SinhVienSubjectService(ISinhVienSubjectRepository repository, ISinhVienRepository sinhVienRepository, ISubjectRepository subjectRepository)
        {
            _repository = repository;
            _sinhVienRepository = sinhVienRepository;
            _subjectRepository = subjectRepository;
        }

        public List<SinhVienSubjectDTO> GetListAllSinhVienSubject()
        {
            // khởi tạo list sinh viên subject DTO
            List<SinhVienSubjectDTO> lstSinhVienSubjectDTOs = new List<SinhVienSubjectDTO>();

            // Lấy dữ liệu thô từ db
            var listAllSinhVienSubject = _repository.GetListAllSinhVienSubject();

            foreach (var item in listAllSinhVienSubject)
            {
                var sinhVienSubjectDTO = new SinhVienSubjectDTO();

                sinhVienSubjectDTO.SinhVienId = item.SinhVienId;
                sinhVienSubjectDTO.SubjectId = item.SubjectId;
                sinhVienSubjectDTO.ScoreOnePeriod = item.ScoreOnePeriod;
                sinhVienSubjectDTO.FifteenMinutesPoint = item.FifteenMinutesPoint;
                sinhVienSubjectDTO.OralTestScores = item.OralTestScores;
                sinhVienSubjectDTO.SemesterExamScore = item.OralTestScores;

                var sinhVien = _sinhVienRepository.GetSinhVien(sinhVienSubjectDTO.SinhVienId);
                sinhVienSubjectDTO.SinhVienName = sinhVien.Name;

                var subject = _subjectRepository.GetSubjectById(sinhVienSubjectDTO.SubjectId);
                sinhVienSubjectDTO.SubjectName = subject.Name;

                // phải thêm sinhVienSubjectDTO vào listAllSinhVienSubject
                lstSinhVienSubjectDTOs.Add(sinhVienSubjectDTO);
            }

            return lstSinhVienSubjectDTOs;
        }

        public List<SinhVienSubjectDTO> GetListSinhVienBySubjectId(int SubjectId)
        {
            throw new NotImplementedException();
        }

        public List<SinhVienSubjectDTO> GetListSubjectBySinhVienId(int SinhVienId)
        {
            throw new NotImplementedException();
        }
    }
}
