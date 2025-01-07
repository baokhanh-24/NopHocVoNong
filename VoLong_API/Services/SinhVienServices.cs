using VoLong_API.Entities;
using VoLong_API.Repositories;

namespace VoLong_API.Services
{
    public class SinhVienServices : ISinhVienService
    {
        // DI   
        private readonly ISinhVienRepository _sinhVienRepository;

        public SinhVienServices(ISinhVienRepository sinhVienRepository)
        {
            _sinhVienRepository = sinhVienRepository;
        }

        public List<SinhVien> AddSinhVien(SinhVien sinhVien)
        {
            // Dùng để tìm kiếm sinh viên ở trong lstAllSV
            var lstAllSV = _sinhVienRepository.GetAll();
            // lọc dữ liệu trong lstAllSV
            foreach (var item in lstAllSV)
            {
                // nếu tìm được email hoặc sđt của sinh viên trong lstAllSV giống với email hoặc sđt của sinh cần tìm kiếm (sinh viên muốn thêm(SinhVien sinhVien))
                if (item.Email.ToLower() == sinhVien.Email.ToLower() || item.Sdt.ToLower() == sinhVien.Sdt.ToLower())
                {
                    // nếu đã tồn tại email giống với email cần tìm kiếm thì trả về list ban đầu
                    return lstAllSV;
                }
            }
            // nếu email muốn thêm không bị trùng thì sẽ thêm sinh viên đó trả về list sinh viên(result) đã được thêm
            var result = _sinhVienRepository.CreateSinhVien(sinhVien);
            return result;
        }



        // haha1111111111ddd
        public bool DeleteSinhVien(int id)
        {
            // lstAllSinhVien: lấy tất cả sinh viên trong db ra
            var lstAllSinhVien = _sinhVienRepository.GetAll();

            // Tìm sinh viên theo id
            var sinhVienToDelete = lstAllSinhVien.FirstOrDefault(x => x.Id == id);

            if(sinhVienToDelete is null)
            {
                return false;
            }

            var result = _sinhVienRepository.DeleteSinhVien(sinhVienToDelete);
            return result;
        }

        public List<SinhVien> FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public List<SinhVien> FindByName(string name)
        {

            var getSinhVienByName = _sinhVienRepository.GetListSinhVienByName(name);

            return getSinhVienByName;
        }

        public List<SinhVien> GetAllSinhVien()
        {
            return _sinhVienRepository.GetAll();
        }

        public SinhVien UpdateSinhVien(int id, SinhVien sinhVien)
        {
            var sinhVienCheck = _sinhVienRepository.GetAll().FirstOrDefault(x => x.Id == id);
            if(sinhVienCheck == null)
            {
                return null;
            }

                sinhVienCheck.Name = sinhVien.Name;
                sinhVienCheck.LopId = sinhVien.LopId;
                sinhVienCheck.Sdt = sinhVien.Sdt;
                sinhVienCheck.Email = sinhVien.Email;
                sinhVienCheck.DiaChi = sinhVien.DiaChi;

            var result = _sinhVienRepository.UpdateSinhVien(sinhVien);
            return result;
        }








































        //private List<SinhVien> _lstSinhVien = new List<SinhVien>();

        //public SinhVienServices()
        //{
        //    for(int i =0; i<3; i++)
        //    {
        //        SinhVien sinhVien = new SinhVien();
        //        sinhVien.Id = 1 + i;
        //        sinhVien.Name = "ehehe" + i;
        //        sinhVien.Sdt = "123456789" + sinhVien.Id.ToString() + i;
        //        sinhVien.DiaChi = "lmaoo" + i;
        //        sinhVien.Lop = "haha" + i;
        //        sinhVien.Email = "Lmeoo" + i;
        //        _lstSinhVien.Add(sinhVien);
        //    }
        //}

        //public List<SinhVien> AddSinhVien(SinhVien sinhVien)
        //{

        //    _lstSinhVien.Add(sinhVien);

        //    return _lstSinhVien;

        //}

        //public SinhVien UpdateSinhVien(int id,SinhVien sinhVien)
        //{
        //    foreach (var x in _lstSinhVien.Where(c => c.Id == id))
        //    {
        //        x.Name = sinhVien.Name;
        //        x.Email = sinhVien.Email;
        //        x.Sdt = sinhVien.Sdt;
        //        x.Lop = sinhVien.Lop;
        //        x.DiaChi = sinhVien.DiaChi;

        //        return x;
        //    }

        //    return null;
        //}

        //public string DeleteSinhVien(int id)
        //{
        //    foreach (var sv in _lstSinhVien.Where(c => c.Id == id))
        //    {
        //        _lstSinhVien.Remove(sv);
        //        return "Xóa thành công";
        //    }
        //    return "Không tìm thấy sv";
        //}

        //public List<SinhVien> GetAllSinhVien()
        //{
        //    return _lstSinhVien;
        //}

        //public List<SinhVien> FindByName(string name)
        //{
        //    // Tìm kiếm gần đúng với chữ cái đầu tiên là tham số truyền vào
        //    //var result = _lstSinhVien.Where(c => c.Name.ToLower().StartsWith(name.ToLower())).ToList();

        //    // Tìm kiếm gần đúng với chữ cái cuối cùng là tham số truyền vào
        //    //var result = _lstSinhVien.Where(c => c.Name.ToLower().EndsWith(name.ToLower())).ToList();

        //    // Tìm kiếm gần đúng với các chữ cái là tham số truyền vào
        //    var result = _lstSinhVien.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToList();


        //    return result;
        //}

        //public List<SinhVien> FindByEmail(string email)
        //{

        //    var result = _lstSinhVien.Where(c => c.Email.ToLower().StartsWith(email.ToLower())).ToList();

        //    return result;
        //}
    }
}
