using VoLong_API.Repositories;
using VoLong_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// controller nhận dữ liệu truyền xuống service xử lý logic qua repo làm nốt crud...

// singleton chạy cho đến khi chương trình bị tắt bỏ

// Đăng kí service để chương trình chạy được
//builder.Services.AddSingleton < SinhVienServices >();

// Đăng kí service để chương trình chạy được
builder.Services.AddScoped <ISinhVienService ,SinhVienServices >();

// Đăng kí repo để chương trình chạy được
builder.Services.AddSingleton <ISinhVienRepository, SinhVienRepository>();


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
