using System.ComponentModel.DataAnnotations;
using BookApi.Models.Enums;

namespace BookApi.DTOs.Contract;

public class ContractDto
{
    public int Id { get; set; }
    public string ContractNumber { get; set; } = string.Empty;
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; } = string.Empty;

    public ContractType Type { get; set; }
    public string TypeName => Type switch
    {
        ContractType.Probation => "Thử việc",
        ContractType.DefiniteTerm => "Xác định thời hạn",
        ContractType.IndefiniteTerm => "Không xác định thời hạn",
        ContractType.VisitingLecturer => "Giảng viên thỉnh giảng",
        _ => "Khác"
    };

    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal BaseSalary { get; set; }
    public decimal SalaryCoefficient { get; set; }
    public string? Terms { get; set; }
    public bool IsActive { get; set; }
}

public class CreateContractDto
{
    [Required(ErrorMessage = "Số hợp đồng là bắt buộc")]
    public string ContractNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Mã nhân viên là bắt buộc")]
    public int EmployeeId { get; set; }

    public ContractType Type { get; set; } = ContractType.DefiniteTerm;

    [Required(ErrorMessage = "Ngày bắt đầu là bắt buộc")]
    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Lương cơ bản không hợp lệ")]
    public decimal BaseSalary { get; set; }

    [Range(1.0, 15.0, ErrorMessage = "Hệ số lương nằm trong khoảng từ 1.0 đến 15.0")]
    public decimal SalaryCoefficient { get; set; } = 1.0m;

    public string? Terms { get; set; }
}
