using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public class SinhVienRepository : ISinhVienRepository
    {
        private List<SinhVien> _lstSinhVien = new List<SinhVien>();

        public SinhVienRepository()
        {
            for (int i = 0; i < 3; i++)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.Id = 1 + i;
                sinhVien.Name = "ehehe" + i;
                sinhVien.Sdt = "123456789" + sinhVien.Id.ToString() + i;
                sinhVien.DiaChi = "lmaoo" + i;
                sinhVien.Lop = "haha" + i;
                sinhVien.Email = "Lmeoo" + i;
                _lstSinhVien.Add(sinhVien);
            }
        }

        public List<SinhVien> CreateSinhVien(SinhVien sv)
        {
            _lstSinhVien.Add(sv);

            return _lstSinhVien;
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
            return _lstSinhVien;
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
