using BookApi.Interfaces;
using BookApi.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Đăng ký services (DI Container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Đăng ký Service vào DI Container
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

// 2. Cấu hình Middleware Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();