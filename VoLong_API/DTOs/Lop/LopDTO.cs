using System.Text.Json.Serialization;

namespace VoLong_API.DTOs.Lop
{
    public class LopDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int TruongHocId { get; set; }

        public List<Entities.SinhVien> lstSinhViens { get; set; }

    }
}
