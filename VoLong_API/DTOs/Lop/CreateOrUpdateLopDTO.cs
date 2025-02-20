namespace VoLong_API.DTOs.Lop
{
    public class CreateOrUpdateLopDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }


        public string TenSinhVien { get; set; }
    }
}
