using VoLong_API.Commons;
using VoLong_API.DTOs.Lop;
using VoLong_API.Entities;
using VoLong_API.Repositories;

namespace VoLong_API.Services
{
    public class LopService : ILopService
    {
        private readonly ILopRepository _lopRepository;

        private readonly ISinhVienRepository _sinhVienRepository;

        public LopService(ILopRepository lopRepository, ISinhVienRepository sinhVienRepository)
        {
            _lopRepository = lopRepository;
            _sinhVienRepository = sinhVienRepository;
        }

        public List<Lop> AddLop(CreateOrUpdateLopDTO lop)
        {
            var lstAllLop = _lopRepository.GetAll();

            foreach (var item in lstAllLop)
            {
                if (item.Name.ToLower() == lop.Name.ToLower())
                {
                    return lstAllLop;
                }
            }

            Lop lopDB = new Lop();

            lopDB.Name = lop.Name;
            lopDB.Code = lop.Code;
            lopDB.Description = lop.Description;
            lopDB.Status = lop.Status;

            var result = _lopRepository.Create(lopDB);
            return result;
        }

        public bool DeleteLop(int id)
        {
            var lstAllLop = _lopRepository.GetAll();

            var lopToDelete = lstAllLop.FirstOrDefault(c => c.Id == id);

            if (lopToDelete is null)
            {
                return false;
            }

            var result = _lopRepository.Delete(lopToDelete);

            return result;
        }

        public List<Lop> GetAllLop()
        {
            return _lopRepository.GetAll();
        }

        

        public List<LopDTO> GetListLop()
        {
            var lstLopDTO = new List<LopDTO>();

            var lstLop = _lopRepository.GetAll();

            foreach ( var item in lstLop)
            {
                LopDTO lopDTO = new LopDTO();
                lopDTO.Id = item.Id;
                lopDTO.Name = item.Name;
                lopDTO.Code = item.Code;
                lopDTO.Description = item.Description;
                lopDTO.Status = item.Status;
               
                lopDTO.lstSinhViens = _sinhVienRepository.GetListSinhVienByLopId(item.Id);

                lstLopDTO.Add(lopDTO);
            }

            return lstLopDTO;
        }

        public Lop UpdateLop(CreateOrUpdateLopDTO lop)
        {
            Lop lopDB = new Lop();
           
            lopDB.Name = lop.Name;
            lopDB.Code = lop.Code;
            lopDB.Description = lop.Description;
            lopDB.Status = lop.Status;
            //lopDB.Id = lop.Id;

            var result = _lopRepository.Update(lopDB);
            return result;
        }
    }
}
