namespace VoLong_API.Entities
{
    public class SinhVienSubject
    {
        //public int Id { get; set; }
        // 2 khóa ngoại tới 2 bảng sinh viên và subject trong quan hệ nhiều nhiều được xem như là khóa chính
        public int SinhVienId { get; set; }
        public int SubjectId { get; set; }
        public double ScoreOnePeriod { get; set; }
        public double FifteenMinutesPoint { get; set; }
        public double OralTestScores { get; set; }
        public double SemesterExamScore { get; set; }


        public virtual Subject Subject { get; set; }
        public virtual SinhVien SinhVien { get; set; }

    }
}
