using VoLong_API.DTOs.SinhVienSubject;
using VoLong_API.DTOs.Subject;
using VoLong_API.DTOs.TruongHoc;
using VoLong_API.Entities;
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

        public List<SinhVienSubject> AddSinhVienSubject(CreateOrUpdateSinhVienSubjectDTO sinhVienSubjectDTO)
        {
            SinhVienSubject sinhVienSubjectDB = new SinhVienSubject();

            sinhVienSubjectDB.SinhVienId = sinhVienSubjectDTO.SinhVienId;
            sinhVienSubjectDB.SubjectId = sinhVienSubjectDTO.SubjectId;
            sinhVienSubjectDB.ScoreOnePeriod = sinhVienSubjectDTO.ScoreOnePeriod;
            sinhVienSubjectDB.FifteenMinutesPoint = sinhVienSubjectDTO.FifteenMinutesPoint;
            sinhVienSubjectDB.OralTestScores = sinhVienSubjectDTO.OralTestScores;
            sinhVienSubjectDB.SemesterExamScore = sinhVienSubjectDTO.SemesterExamScore;

            var result = _repository.CreateSinhVienSubject(sinhVienSubjectDB);
            return result;
        }

        public bool DeleteSinhVienSubject(int id)
        {
            var lstAllSinhVienSubject = _repository.GetListAllSinhVienSubject();

            var sinhVienSubjectToDelete = lstAllSinhVienSubject.FirstOrDefault(x => x.SinhVienId == id);

            if (sinhVienSubjectToDelete is null)
            {
                return false;
            }

            var result = _repository.DeleteSinhVienSubject(sinhVienSubjectToDelete);
            return result;
        }

        public SinhVienSubject UpdateSinhVienSubject(CreateOrUpdateSinhVienSubjectDTO sinhVienSubjectDTO)
        {
            SinhVienSubject sinhVienSubjectDB = new SinhVienSubject();

            sinhVienSubjectDB.SinhVienId = sinhVienSubjectDTO.SinhVienId;
            sinhVienSubjectDB.SubjectId = sinhVienSubjectDTO.SubjectId;
            sinhVienSubjectDB.ScoreOnePeriod = sinhVienSubjectDTO.ScoreOnePeriod;
            sinhVienSubjectDB.FifteenMinutesPoint = sinhVienSubjectDTO.FifteenMinutesPoint;
            sinhVienSubjectDB.OralTestScores = sinhVienSubjectDTO.OralTestScores;
            sinhVienSubjectDB.SemesterExamScore = sinhVienSubjectDTO.SemesterExamScore;

            var result = _repository.UpdateSinhVienSubject(sinhVienSubjectDB);
            return result;
        }

        public List<SinhVienSubjectDTO> GetListSinhVienBySubjectId(int SubjectId)
        {
            List<SinhVienSubjectDTO> lstSinhVienSubjectDTOs = new List<SinhVienSubjectDTO>();

            // Lấy dữ liệu thô từ db
            var listAllSinhVienSubject = _repository.GetListAllSinhVienSubject();

            foreach (var item in listAllSinhVienSubject.Where(c=>c.SubjectId == SubjectId))
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

                lstSinhVienSubjectDTOs.Add(sinhVienSubjectDTO);
            }

            return lstSinhVienSubjectDTOs;
        }

        public List<SinhVienSubjectDTO> GetListSubjectBySinhVienId(int SinhVienId)
        {
            List<SinhVienSubjectDTO> lstSinhVienSubjectDTOs = new List<SinhVienSubjectDTO>();

            // Lấy dữ liệu thô từ db
            var listAllSinhVienSubject = _repository.GetListAllSinhVienSubject();

            foreach (var item in listAllSinhVienSubject.Where(c => c.SinhVienId == SinhVienId))
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

                lstSinhVienSubjectDTOs.Add(sinhVienSubjectDTO);
            }

            return lstSinhVienSubjectDTOs;
        }

    }
}
