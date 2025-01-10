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
            throw new NotImplementedException();
        }

        public bool Delete(Lop lop)
        {
            throw new NotImplementedException();
        }

        public Lop GetLopById(int id)
        {
            var x = _context.Lops.Where(c =>c.Id == id).FirstOrDefault();
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
            throw new NotImplementedException();
        }
    }
}
