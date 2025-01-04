using VoLong_API.Context;
using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public class SinhVienRepository : ISinhVienRepository
    {
        private readonly List<SinhVien> _lstSinhVien = new List<SinhVien>();

        private readonly LopHocContext _context;

        public SinhVienRepository(LopHocContext context)
        {
            _context = context;
        }

        public List<SinhVien> CreateSinhVien(SinhVien sv)
        {
            //_lstSinhVien.Add(sv);

            //return _lstSinhVien;
            
            var sinhVienAdded = _context.SinhViens.Add(sv); // chỉ lưu vào bộ nhớ tạm thời

            //để lưu lại dữ liệu vào db
            _context.SaveChanges();

            return _context.SinhViens.ToList();
        }

        public List<SinhVien> DeleteSinhVien(int id)
        {
            foreach (var sv in _lstSinhVien.Where(c => c.Id == id))
            {
                _lstSinhVien.Remove(sv);

            }
            return _lstSinhVien;
        }

        public List<SinhVien> GetAll()
        {
            var lstSinhVienDB = _context.SinhViens.ToList();

            return lstSinhVienDB;
        }

        public List<SinhVien> GetListSinhVienByName(string name)
        {
            var result = _lstSinhVien.Where(c => c.Name.ToLower().StartsWith(name.ToLower())).ToList();
            return result;
        }

        public SinhVien GetSinhVien(int id)
        {
            var x = _lstSinhVien.Where(c =>c.Id == id).FirstOrDefault();
            return x;
        }

        public List<SinhVien> UpdateSinhVien(int id, SinhVien sv)
        {
            foreach (var x in _lstSinhVien.Where(c => c.Id == id))
            {
                x.Name = sv.Name;
                x.Email = sv.Email;
                x.Sdt = sv.Sdt;
                x.Lop = sv.Lop;
                x.DiaChi = sv.DiaChi;

            }

            return _lstSinhVien;
        }
    }
}
