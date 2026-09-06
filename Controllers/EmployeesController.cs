using BookApi.DTOs.Employee;
using BookApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers;

[ApiController]
[Route("api/employees")]
public class EmployeesController(IEmployeeService employeeService) : ControllerBase
{
    [HttpGet]
    public ActionResult<IReadOnlyList<EmployeeDto>> GetAll() => Ok(employeeService.GetAll());

    [HttpGet("{id:int}")]
    public ActionResult<EmployeeDto> GetById(int id)
    {
        var employee = employeeService.GetById(id);
        return employee is null ? NotFound(new { message = "Không tìm thấy nhân viên." }) : Ok(employee);
    }

    [HttpPost]
    public ActionResult<EmployeeDto> Create(CreateEmployeeDto request)
    {
        if (employeeService.EmployeeCodeExists(request.EmployeeCode)) return Conflict(new { message = "Mã nhân viên đã tồn tại." });
        if (employeeService.EmailExists(request.Email)) return Conflict(new { message = "Email đã tồn tại." });
        var employee = employeeService.Create(request);
        return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
    }

    [HttpPut("{id:int}")]
    public ActionResult<EmployeeDto> Update(int id, UpdateEmployeeDto request)
    {
        if (!employeeService.Update(id, request, out var employee)) return NotFound(new { message = "Không tìm thấy nhân viên." });
        return Ok(employee);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id) => employeeService.Delete(id)
        ? NoContent()
        : NotFound(new { message = "Không tìm thấy nhân viên." });
}
