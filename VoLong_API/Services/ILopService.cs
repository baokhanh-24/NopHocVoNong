using VoLong_API.DTOs.Lop;
using VoLong_API.DTOs.SinhVien;
using VoLong_API.Entities;

namespace VoLong_API.Services
{
    public interface ILopService
    {
        List<Lop> AddLop(CreateOrUpdateLopDTO lop);
        Lop UpdateLop(CreateOrUpdateLopDTO lop);
        bool DeleteLop(int id);
        List<Lop> GetAllLop();
        List<LopDTO> GetListLop();

       
    }
}
