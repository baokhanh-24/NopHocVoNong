namespace VoLong_API.DTOs.TruongHoc
{
    public class TruongHocDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Establish { get; set; }
        public string Code { get; set; }
        public string Hotline { get; set; }

        public List<Entities.Lop> lstLops { get; set; }

        public int TotalClass { get; set; }
        public int TotalStudent { get; set; }
    }
}
