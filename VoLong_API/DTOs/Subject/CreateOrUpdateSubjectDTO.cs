namespace VoLong_API.DTOs.Subject
{
    public class CreateOrUpdateSubjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
