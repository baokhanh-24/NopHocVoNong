using VoLong_API.DTOs.SinhVien;
using VoLong_API.DTOs.TruongHoc;
using VoLong_API.Entities;

namespace VoLong_API.Services
{
    public interface ITruongHocService
    {
        List<TruongHoc> AddTruongHoc(CreateOrUpdateTruongHocDTO truongHoc);
        TruongHoc UpdateTruongHoc(CreateOrUpdateTruongHocDTO truongHoc);
        bool DeleteTruongHoc(int id);
        List<TruongHocDTO> GetAllTruongHoc();
        List<TruongHocDTO> GetListTruongHoc();
    }
}
