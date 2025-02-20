namespace VoLong_API.DTOs.TruongHoc
{
    public class CreateOrUpdateTruongHocDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Establish { get; set; }
        public string Code { get; set; }
        public string Hotline { get; set; }
    }
}
