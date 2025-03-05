using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public interface ISinhVienRepository
    {
        // Task<List<SinhVien>> tức là hàm sẽ trả về 1 list sv, CreateSinhVien là tên phương thức, (SinhVien sv) là tham số truyền vào.
        //Task<List<SinhVien>> CreateSinhVienAsync(SinhVien sv);
        //Task<SinhVien> GetSinhVienAsync(int id , SinhVien sv);
        //Task<List<SinhVien>> GetListSinhVienByNameAsync( string name);
        //Task<List<SinhVien>> UpdateSinhVienAsync(int id,SinhVien sv);

        List<SinhVien> GetListSinhVienByLopId(int lopId);
        List<SinhVien> CreateSinhVien(SinhVien sv);
        SinhVien GetSinhVien(int id);
        List<SinhVien> GetListSinhVienByName( string name);
        SinhVien UpdateSinhVien(SinhVien sv);
        bool DeleteSinhVien(SinhVien sinhVien);
        List<SinhVien> GetAll();
        List<SinhVien> GetAllSinhVienByLopId(int lopId);

    }
}
