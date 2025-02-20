using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public interface ITruongHocRepository
    {
        List<TruongHoc> GetListTruongHocById(int truongHocId);
        List<TruongHoc> CreateTruongHoc(TruongHoc truongHoc);
        TruongHoc GetTruongHoc(int id);
        TruongHoc UpdateTruongHoc(TruongHoc truongHoc);
        bool DeleteTruongHoc(TruongHoc truongHoc);
        List<TruongHoc> GetAll();
    }
}
