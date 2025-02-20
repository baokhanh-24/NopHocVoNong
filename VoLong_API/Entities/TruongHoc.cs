using System.Text.Json.Serialization;

namespace VoLong_API.Entities
{
    public class TruongHoc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Establish {  get; set; }
        public string Code { get; set; }
        public string Hotline { get; set; }
        
        public ICollection<Lop>? Lops { get; set; }
    }
}
