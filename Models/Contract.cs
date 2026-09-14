using System.ComponentModel.DataAnnotations;
using BookApi.Models.Enums;

namespace BookApi.Models;

public class Contract
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Số hợp đồng là bắt buộc")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Số hợp đồng phải từ 3 đến 50 ký tự")]
    public string ContractNumber { get; set; } = string.Empty; // Số HĐ: HĐLD-UDA/2026/001

    [Range(1, int.MaxValue, ErrorMessage = "Mã nhân viên không hợp lệ")]
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    [EnumDataType(typeof(ContractType), ErrorMessage = "Loại hợp đồng không hợp lệ")]
    public ContractType Type { get; set; } = ContractType.DefiniteTerm;

    [Required(ErrorMessage = "Ngày bắt đầu hợp đồng là bắt buộc")]
    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Mức lương cơ bản không hợp lệ")]
    public decimal BaseSalary { get; set; } // Mức lương cơ bản

    [Range(0.0, 100.0, ErrorMessage = "Hệ số lương phải nằm trong khoảng 0 đến 100")]
    public decimal SalaryCoefficient { get; set; } = 1.0m; // Hệ số lương (theo bậc giảng viên/chuyên viên)

    [StringLength(1000, ErrorMessage = "Điều khoản bổ sung không được vượt quá 1000 ký tự")]
    public string? Terms { get; set; } // Điều khoản bổ sung

    public bool IsActive { get; set; } = true;
}
