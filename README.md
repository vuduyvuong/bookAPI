# BookApi

API quản lý nhân sự cho trường học. Phiên bản hiện tại đã có CRUD nhân viên để demo và chuẩn bị model/DTO cho các nghiệp vụ nhân sự khác.

## Công nghệ

- .NET 10
- ASP.NET Core Web API
- Swagger (Swashbuckle)
- Dependency Injection

## Chạy dự án

Yêu cầu: đã cài .NET SDK 10.

```powershell
dotnet restore
dotnet run --launch-profile http
```

Ứng dụng mặc định chạy tại `http://localhost:5294`.

Sau khi chạy, có thể mở Swagger tại:

```text
http://localhost:5294/swagger
```

## API hiện có

### Nhân viên

```http
GET    /api/employees
GET    /api/employees/{id}
POST   /api/employees
PUT    /api/employees/{id}
DELETE /api/employees/{id}
```

Ví dụ gọi bằng PowerShell:

```powershell
Invoke-RestMethod -Uri http://localhost:5294/api/employees
```

Phản hồi mẫu:

```json
{
  "id": 1,
  "employeeCode": "UDA-001",
  "fullName": "Nguyễn Văn An"
}
```

## Cấu trúc chính

```text
Controllers/       API controllers
Interfaces/        Khai báo service interfaces
Services/          Service implementations
Models/            Các entity nghiệp vụ
DTOs/              Data Transfer Objects
Data/              Dành cho lớp truy cập dữ liệu (chưa triển khai)
Reponsitorises/    Dành cho repository (chưa triển khai)
Middleware/        Dành cho middleware tùy chỉnh (chưa triển khai)
```

## Phần đã chuẩn bị cho hệ thống nhân sự

Các model và DTO đã có sẵn cho:

- Nhân viên, phòng ban và chức vụ
- Hợp đồng lao động
- Bảng lương
- Đơn nghỉ phép và phê duyệt
- Tài khoản, đăng nhập và đăng ký

## Chuẩn API cho các nghiệp vụ tiếp theo

Các route dưới đây là quy ước sẽ áp dụng khi triển khai controller/service tương ứng:

```text
/api/departments                 Quản lý phòng ban/khoa
/api/positions                   Quản lý chức vụ
/api/contracts                   Quản lý hợp đồng
/api/leave-requests              Tạo, tra cứu, duyệt đơn nghỉ
/api/salary-records              Tính lương, tra cứu và xác nhận chi trả
/api/auth/register, /api/auth/login  Đăng ký và đăng nhập
```

## Giới hạn hiện tại

Các phần phòng ban, chức vụ, hợp đồng, lương, nghỉ phép và xác thực mới dừng ở model/DTO. Dự án chưa triển khai database, Entity Framework Core, JWT, phân quyền, repository và middleware xử lý lỗi. CRUD nhân viên hiện dùng dữ liệu trong bộ nhớ để demo, nên dữ liệu sẽ mất khi khởi động lại ứng dụng.

> Lưu ý: có thể dùng file `BookApi.http` để gọi nhanh các API nhân viên mẫu.
