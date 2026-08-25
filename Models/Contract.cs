using BookApi.Models.Enums;

namespace BookApi.Models;

public class Contract
{
    public int Id { get; set; }
    public string ContractNumber { get; set; } = string.Empty; // Số HĐ: HĐLD-UDA/2026/001
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    public ContractType Type { get; set; } = ContractType.DefiniteTerm;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public decimal BaseSalary { get; set; }         // Mức lương cơ bản
    public decimal SalaryCoefficient { get; set; } = 1.0m; // Hệ số lương (theo bậc giảng viên/chuyên viên)
    public string? Terms { get; set; }              // Điều khoản bổ sung
    public bool IsActive { get; set; } = true;
}
