using BookApi.DTOs.Employee;

namespace BookApi.Interfaces;

public interface IEmployeeService
{
    IReadOnlyList<EmployeeDto> GetAll();
    EmployeeDto? GetById(int id);
    EmployeeDto Create(CreateEmployeeDto request);
    bool Update(int id, UpdateEmployeeDto request, out EmployeeDto? employee);
    bool Delete(int id);
    bool EmployeeCodeExists(string employeeCode);
    bool EmailExists(string email);
}
