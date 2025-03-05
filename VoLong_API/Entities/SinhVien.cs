using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VoLong_API.Entities
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }

        // đặt tên của bảng cùng với thuộc tính(khóa ngoại)
        [ForeignKey("LopId")]
        public int LopId { get; set; }


        //virtual: là 1 lớp ảo
        // ?: cho phép null
        // jsonIgnore: là 1 attribute giúp cho không hiển thị trên swagger
        [JsonIgnore]
        public virtual Lop? LopHoc { get; set; }

        //quan hệ 1-n vì 1 sv có thể học nhiều môn
        public virtual ICollection<SinhVienSubject> SinhVienSubjects { get; set; }
    }
}
