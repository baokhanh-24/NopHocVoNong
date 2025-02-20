using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public interface ILopRepository
    {
        List<Lop> Create(Lop lop);
        List<Lop> GetLopByTruongHocId(int truongHocid);
        Lop GetLopById(int id);
        List<Lop> GetByName(string name);
        Lop Update(Lop lop);
        bool Delete(Lop lop);
        List<Lop> GetAll();
        List<Lop> GetAllLopByTruongHocId(int truongHocId);
    }
}
