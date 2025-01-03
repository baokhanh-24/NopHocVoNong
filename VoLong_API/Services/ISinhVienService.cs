using VoLong_API.Entities;

namespace VoLong_API.Services
{
    public interface ISinhVienService
    {
        List<SinhVien> AddSinhVien(SinhVien sinhVien);
        SinhVien UpdateSinhVien(int id, SinhVien sinhVien);
        string DeleteSinhVien(int id);
        List<SinhVien> GetAllSinhVien();
        List<SinhVien> FindByName(string name);
        List<SinhVien> FindByEmail(string email);

    }
}
