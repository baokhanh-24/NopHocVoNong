using Microsoft.EntityFrameworkCore;
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

        public bool DeleteSinhVien(SinhVien sinhVien)
        {
            try
            {
                var sinhVienDeleted = _context.SinhViens.Remove(sinhVien);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

        public List<SinhVien> GetAll()
        {
            var lstSinhVienDB = _context.SinhViens.ToList();

            return lstSinhVienDB;
        }

        public List<SinhVien> GetListSinhVienByName(string name)
        {
            // where: tìm list
            // FirstOrDefault: tìm 1 sinh viên
            var result = _context.SinhViens.Where(x => x.Name.ToLower().StartsWith(name.ToLower())).ToList();
            return result;
        }   
        public List<SinhVien> GetListSinhVienByLopId(int lopId)
        {
            // where: tìm list
            // FirstOrDefault: tìm 1 sinh viên
            var result = _context.SinhViens.Where(c => c.LopId==lopId).ToList();
            return result;
        }

        public SinhVien GetSinhVien(int id)
        {
            var x = _lstSinhVien.Where(c =>c.Id == id).FirstOrDefault();
            return x;
        }

        public SinhVien UpdateSinhVien(SinhVien sv)
        {
            //foreach (var x in _lstSinhVien.Where(c => c.Id == id))
            //{
            //    x.Name = sv.Name;
            //    x.Email = sv.Email;
            //    x.Sdt = sv.Sdt;
            //    x.Lop = sv.Lop;
            //    x.DiaChi = sv.DiaChi;

            //}

            //return _lstSinhVien;


            var sinhVienUpdated = _context.SinhViens.Update(sv); 

            _context.SaveChanges();

            return sv;
        }

        public List<SinhVien> GetAllSinhVienByLopId(int lopId)
        {
            return _context.SinhViens.Where(c => c.LopId == lopId).ToList();
        }
    }
}
