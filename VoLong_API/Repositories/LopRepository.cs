using VoLong_API.Context;
using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public class LopRepository : ILopRepository
    {
        public readonly LopHocContext _context;

        public LopRepository(LopHocContext context)
        {
            _context = context;
        }

        public List<Lop> Create(Lop lop)
        {
            var lopAdded = _context.Lops.Add(lop);

            _context.SaveChanges();

            return _context.Lops.ToList();
        }

        public bool Delete(Lop lop)
        {
            try
            {
                var lopDelete = _context.Remove(lop);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

        public List<Lop> GetLopByTruongHocId(int truongHocid)
        {
            var result = _context.Lops.Where(c => c.TruongHocId == truongHocid).ToList();

            return result; 
        }

        public Lop GetLopById(int id)
        {
            var x = _context.Lops.Where(c => c.Id == id).FirstOrDefault();

            return x;
        }

        public List<Lop> GetAll()
        {
            return _context.Lops.ToList();
        }

        public List<Lop> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Lop Update(Lop lop)
        {
            var lopUpdate = _context.Lops.Update(lop);

            _context.SaveChanges();

            return lop;
        }
        public List<Lop> GetAllLopByTruongHocId(int truongHocId)
        {
            // lấy tất cả các lớp theo điều kiện id của trường
            return _context.Lops.Where(c => c.TruongHocId == truongHocId).ToList();
        }
    }
}
