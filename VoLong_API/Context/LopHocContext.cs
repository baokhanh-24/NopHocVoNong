using Microsoft.EntityFrameworkCore;
using VoLong_API.Entities;

namespace VoLong_API.Context
{
    // file context này giúp mình sẽ chứa các dbset, các bảng, cấu hình các bảng, kiểu dữ liệu, quan hệ giữa các bảng 
    // và phải kế thừa dbcontext để xác định đây là dbcontext
    public class LopHocContext : DbContext
    {
        // Lớp này sẽ sử dụng tất cả các cấu hình có trong class cha (DbContext) kế thừa base

        public LopHocContext(DbContextOptions options) : base(options)
        {
        }


        //DbSet giúp trỏ đến các bảng để tương tác với các dữ liệu (trong db)
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }

        // phương thức này được bảo vệ và được kế thừa và ghi đè từ lớp cha (DbContext) 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // cấu hình được tên bảng (khóa chính, ngoại, kiểu dữ liệu,...)
            modelBuilder.Entity<SinhVien>(entity =>
            {
                // ToTable: định danh tên bảng trong sql
                entity.ToTable("Sinh vien truong mua");

                // HasKey: xác định khóa chính là trường nào
                entity.HasKey(c => c.Id);

                // đây là thể hiện quan hệ 1-n của bảng lớp với bảng sinh viên và thể hiện khóa ngoại (LopId) thuộc bảng SinhVien 
            });


            modelBuilder.Entity<Lop>(entity =>
            {
                // ToTable: định danh tên bảng trong sql
                entity.ToTable("Lop mua");

                // HasKey: xác định khóa chính là trường nào
                entity.HasKey(c => c.Id);

                
            });
        }
    }
}
