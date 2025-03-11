using Microsoft.EntityFrameworkCore;
using VoLong_API.Context;
using VoLong_API.Repositories;
using VoLong_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();


// Giúp đăng kí LopHocContext  là 1 DbContext của ứng dụng và
// builder.Configuration.GetConnectionString("DefaultConnection"): Giúp đọc cấu hình của trường ConnectionStrings của file appsetting
// với key là DefaultConnection
builder.Services.AddDbContext<LopHocContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// controller nhận dữ liệu truyền xuống service xử lý logic qua repo làm nốt crud...

// singleton chạy cho đến khi chương trình bị tắt bỏ

// Đăng kí service để chương trình chạy được
//builder.Services.AddSingleton < SinhVienServices >();

// có 3 loại: scope, singleton (nặng nhất), transient(nhẹ nhất)


// Đăng kí service để chương trình chạy được
builder.Services.AddScoped <ISinhVienService ,SinhVienServices >();
// Đăng kí repo để chương trình chạy được
builder.Services.AddScoped <ISinhVienRepository, SinhVienRepository>();


builder.Services.AddScoped <ILopRepository,LopRepository>();
builder.Services.AddScoped<ILopService, LopService>();


builder.Services.AddScoped<ITruongHocRepository, TruongHocRepository>();
builder.Services.AddScoped<ITruongHocService, TruongHocService>();

builder.Services.AddScoped<ISinhVienSubjectRepository, SinhVienSubjectRepository>();
builder.Services.AddScoped<ISinhVienSubjectService, SinhVienSubjectService>();


builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<ISubjectService, SubjectService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
