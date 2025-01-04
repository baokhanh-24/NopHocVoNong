using System.Text.Json.Serialization;

namespace VoLong_API.Entities
{
    public class Lop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        // icollection là 1 lớp có nhiều sinh viên
        [JsonIgnore]
        public virtual ICollection<SinhVien>? sinhViens { get; set; }
    }
}
