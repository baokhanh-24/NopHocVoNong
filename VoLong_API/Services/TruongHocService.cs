using System.Collections.Generic;
using VoLong_API.Commons;
using VoLong_API.DTOs.Lop;
using VoLong_API.DTOs.SinhVien;
using VoLong_API.DTOs.TruongHoc;
using VoLong_API.Entities;
using VoLong_API.Repositories;

namespace VoLong_API.Services
{
    public class TruongHocService : ITruongHocService
    {

        private readonly ITruongHocRepository _truongHocRepository;

        private readonly ILopRepository _lopRepository;

        private readonly ISinhVienRepository _sinhVienRepository;

        public TruongHocService(ITruongHocRepository truongHocRepository, ILopRepository lopRepository, ISinhVienRepository sinhVienRepository)
        {
            _truongHocRepository = truongHocRepository;
            _lopRepository = lopRepository;
            _sinhVienRepository = sinhVienRepository;
        }

        public List<TruongHoc> AddTruongHoc(CreateOrUpdateTruongHocDTO truongHoc)
        {
            TruongHoc truongHocDB = new TruongHoc();

            truongHocDB.Name = truongHoc.Name;
            truongHocDB.Establish = truongHoc.Establish;
            truongHocDB.Code = truongHoc.Code;
            truongHocDB.Hotline = truongHoc.Hotline;


            var result = _truongHocRepository.CreateTruongHoc(truongHocDB);
            return result;
        }

        public bool DeleteTruongHoc(int id)
        {
            var lstAllTruongHoc = _truongHocRepository.GetAll();


            var truongHocToDelete = lstAllTruongHoc.FirstOrDefault(x => x.Id == id);

            if (truongHocToDelete is null)
            {
                return false;
            }

            var result = _truongHocRepository.DeleteTruongHoc(truongHocToDelete);
            return result;
        }

        public List<TruongHocDTO> GetAllTruongHoc()
        {
            var lstTruongHoc = _truongHocRepository.GetAll(); // phải lấy tất cả các trường ra

            List<TruongHocDTO> lstTruongHocDTO = new List<TruongHocDTO>(); // khởi tạo mới dto
            // Duyệt các trường để lấy ra các lớp và tổng số lớp
            foreach (var item in lstTruongHoc)
            {
                TruongHocDTO truongHocDTO = new TruongHocDTO();
                truongHocDTO.Id = item.Id;
                truongHocDTO.Name = item.Name;
                truongHocDTO.Establish = item.Establish;
                truongHocDTO.Code = item.Code;
                truongHocDTO.Hotline = item.Hotline;
                var listLopByTruongHocId = _lopRepository.GetAllLopByTruongHocId(item.Id);
               
                var resultCountClass = SinhVienHelper.GetTotalCountOfList(listLopByTruongHocId);
                
                truongHocDTO.TotalClass = resultCountClass;


                int tmpStudents = 0;
                foreach (var lop in listLopByTruongHocId)
                {
                    tmpStudents += SinhVienHelper.GetTotalCountOfList(_sinhVienRepository.GetListSinhVienByLopId(lop.Id));
                }
                truongHocDTO.TotalStudent = tmpStudents;

                lstTruongHocDTO.Add(truongHocDTO);

            }

            return lstTruongHocDTO;
        }

        // abcacacacacacacaca

        public List<TruongHocDTO> GetListTruongHoc()
        {
            var lstTruongHocDTO = new List<TruongHocDTO>();

            var lstTruongHoc = _truongHocRepository.GetAll();

            foreach (var item in lstTruongHoc)
            {
                TruongHocDTO truongHocDTO = new TruongHocDTO();
                
                truongHocDTO.Id = item.Id;
                truongHocDTO.Name = item.Name;
                truongHocDTO.Establish = item.Establish;
                truongHocDTO.Code = item.Code;

                truongHocDTO.lstLops = _lopRepository.GetLopByTruongHocId(item.Id);

                lstTruongHocDTO.Add(truongHocDTO);
            }

            return lstTruongHocDTO;
        }

        public TruongHoc UpdateTruongHoc(CreateOrUpdateTruongHocDTO truongHoc)
        {
            TruongHoc truongHocDB = new TruongHoc();

            truongHocDB.Id = truongHoc.Id;
            truongHocDB.Name = truongHoc.Name;
            truongHocDB.Establish = truongHoc.Establish;
            truongHocDB.Code = truongHoc.Code;

            var result = _truongHocRepository.UpdateTruongHoc(truongHocDB);
            return result;
        }
    }
}
