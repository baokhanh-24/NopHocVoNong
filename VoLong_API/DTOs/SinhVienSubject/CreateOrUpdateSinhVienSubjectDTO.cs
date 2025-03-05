namespace VoLong_API.DTOs.SinhVienSubject
{
    public class CreateOrUpdateSinhVienSubjectDTO
    {
        public int SinhVienId { get; set; }
        public int SubjectId { get; set; }
        public double ScoreOnePeriod { get; set; }
        public double FifteenMinutesPoint { get; set; }
        public double OralTestScores { get; set; }
        public double SemesterExamScore { get; set; }
    }
}
