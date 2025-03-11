using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VoLong_API.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }


        //quan hệ 1-n vì 1 môn có thể dành cho nhiều sv
        public virtual ICollection<SinhVienSubject> SinhVienSubjects { get; set; }

    }
}
