using VoLong_API.Context;
using VoLong_API.Entities;

namespace VoLong_API.Repositories
{
    public class TruongHocRepository : ITruongHocRepository
    {
        private readonly List<TruongHoc> _lstTruongHocs = new List<TruongHoc>();

        private readonly LopHocContext _context;

        public TruongHocRepository(LopHocContext context)
        {
            _context = context;
        }

        public List<TruongHoc> CreateTruongHoc(TruongHoc truongHoc)
        {
            var truongHocAdded = _context.TruongHocs.Add(truongHoc); 

            _context.SaveChanges();

            return _context.TruongHocs.ToList();
        }

        public bool DeleteTruongHoc(TruongHoc truongHoc)
        {
            try
            {
                var truongHocDeleted = _context.TruongHocs.Remove(truongHoc);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

        public List<TruongHoc> GetAll()
        {
            return _context.TruongHocs.ToList();
        }

        public List<TruongHoc> GetListTruongHocById(int truongHocId)
        {
            var result = _context.TruongHocs.Where(c => c.Id == truongHocId).ToList();
            return result;
        }

        public TruongHoc GetTruongHoc(int id)
        {
            var x = _lstTruongHocs.Where(c => c.Id == id).FirstOrDefault();
            return x;
        }

        public TruongHoc UpdateTruongHoc(TruongHoc truongHoc)
        {
            var truongHocUpdated = _context.TruongHocs.Update(truongHoc);

            _context.SaveChanges();

            return truongHoc;
        }

       
    }
}
