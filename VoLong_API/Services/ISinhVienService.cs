using VoLong_API.DTOs.SinhVien;
using VoLong_API.Entities;

namespace VoLong_API.Services
{
    public interface ISinhVienService
    {
        List<SinhVien> AddSinhVien(CreateOrUpdateSinhVienDTO sinhVien);
        SinhVien UpdateSinhVien( CreateOrUpdateSinhVienDTO sinhVien);
        bool DeleteSinhVien(int id);
        List<SinhVien> GetAllSinhVien();
        List<SinhVienDTO> GetListSinhVien();
        List<SinhVien> FindByName(string name);
        List<SinhVien> FindByEmail(string email);

    }
}
