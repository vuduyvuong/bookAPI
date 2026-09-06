using BookApi.DTOs.Employee;
using BookApi.Interfaces;
using BookApi.Models.Enums;

namespace BookApi.Services;

// Kho dữ liệu tạm phục vụ demo. Có thể thay bằng repository/EF Core sau này.
public class EmployeeService : IEmployeeService
{
    private readonly List<EmployeeDto> _employees =
    [
        new EmployeeDto
        {
            Id = 1, EmployeeCode = "UDA-001", FullName = "Nguyễn Văn An",
            DateOfBirth = new DateTime(1990, 5, 12), Gender = Gender.Male,
            IdentityCardNumber = "001090000001", Email = "an.nguyen@donga.edu.vn",
            PhoneNumber = "0900000001", HireDate = new DateTime(2020, 9, 1),
            Degree = AcademicDegree.Master, Status = EmployeeStatus.Active,
            DepartmentId = 1, DepartmentName = "Khoa Công nghệ thông tin",
            PositionId = 1, PositionTitle = "Giảng viên"
        }
    ];

    public IReadOnlyList<EmployeeDto> GetAll() => _employees.AsReadOnly();
    public EmployeeDto? GetById(int id) => _employees.FirstOrDefault(x => x.Id == id);

    public EmployeeDto Create(CreateEmployeeDto request)
    {
        var employee = new EmployeeDto
        {
            Id = _employees.Count == 0 ? 1 : _employees.Max(x => x.Id) + 1,
            EmployeeCode = request.EmployeeCode.Trim(), FullName = request.FullName.Trim(),
            DateOfBirth = request.DateOfBirth, Gender = request.Gender,
            IdentityCardNumber = request.IdentityCardNumber.Trim(), Email = request.Email.Trim(),
            PhoneNumber = request.PhoneNumber.Trim(), Address = request.Address?.Trim(),
            HireDate = request.HireDate, Degree = request.Degree,
            AcademicSpecialization = request.AcademicSpecialization?.Trim(),
            Status = EmployeeStatus.Active, DepartmentId = request.DepartmentId, PositionId = request.PositionId
        };
        _employees.Add(employee);
        return employee;
    }

    public bool Update(int id, UpdateEmployeeDto request, out EmployeeDto? employee)
    {
        employee = GetById(id);
        if (employee is null) return false;
        employee.FullName = request.FullName.Trim();
        employee.DateOfBirth = request.DateOfBirth; employee.Gender = request.Gender;
        employee.IdentityCardNumber = request.IdentityCardNumber.Trim(); employee.Email = request.Email.Trim();
        employee.PhoneNumber = request.PhoneNumber.Trim(); employee.Address = request.Address?.Trim();
        employee.Degree = request.Degree; employee.AcademicSpecialization = request.AcademicSpecialization?.Trim();
        employee.Status = request.Status; employee.DepartmentId = request.DepartmentId; employee.PositionId = request.PositionId;
        return true;
    }

    public bool Delete(int id)
    {
        var employee = GetById(id);
        return employee is not null && _employees.Remove(employee);
    }

    public bool EmployeeCodeExists(string employeeCode) => _employees.Any(x =>
        string.Equals(x.EmployeeCode, employeeCode.Trim(), StringComparison.OrdinalIgnoreCase));
    public bool EmailExists(string email) => _employees.Any(x =>
        string.Equals(x.Email, email.Trim(), StringComparison.OrdinalIgnoreCase));
}
