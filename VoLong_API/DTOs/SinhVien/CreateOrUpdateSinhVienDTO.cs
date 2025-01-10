namespace VoLong_API.DTOs.SinhVien
{
    public class CreateOrUpdateSinhVienDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public int LopId { get; set; }

    }
}
