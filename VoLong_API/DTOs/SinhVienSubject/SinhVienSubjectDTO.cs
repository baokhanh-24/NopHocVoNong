namespace VoLong_API.DTOs.SinhVienSubject
{
    public class SinhVienSubjectDTO
    {
        public int SinhVienId { get; set; }
        public int SubjectId { get; set; }


        // bổ sung 2 trường dto là SubjectName và SinhVienName để lấy tên môn học và sv
        public string SinhVienName { get; set; }
        public string SubjectName { get; set; }


        public double ScoreOnePeriod { get; set; }
        public double FifteenMinutesPoint { get; set; }
        public double OralTestScores { get; set; }
        public double SemesterExamScore { get; set; }
    }
}
