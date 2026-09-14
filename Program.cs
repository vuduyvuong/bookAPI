using BookApi.Interfaces;
using BookApi.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Đăng ký services (DI Container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Đăng ký Service vào DI Container
builder.Services.AddSingleton<IEmployeeService, EmployeeService>();

var app = builder.Build();

// 2. Cấu hình Middleware Pipeline
// Bật Swagger cho mục đích test (sẵn sàng ở tất cả môi trường)
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
