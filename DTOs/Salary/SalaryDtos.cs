using System.ComponentModel.DataAnnotations;

namespace BookApi.DTOs.Salary;

public class SalaryRecordDto
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public string EmployeeCode { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public string DepartmentName { get; set; } = string.Empty;

    public int Month { get; set; }
    public int Year { get; set; }

    public decimal BaseSalary { get; set; }
    public decimal Coefficient { get; set; }
    
    public decimal PositionAllowance { get; set; }
    public decimal TeachingAllowance { get; set; }
    public decimal SeniorityAllowance { get; set; }
    public decimal OvertimeAllowance { get; set; }
    public decimal Bonus { get; set; }

    public decimal TotalIncome => (BaseSalary * Coefficient) + PositionAllowance + TeachingAllowance + SeniorityAllowance + OvertimeAllowance + Bonus;

    public decimal InsuranceDeduction { get; set; }
    public decimal TaxDeduction { get; set; }
    public decimal OtherDeductions { get; set; }
    public decimal TotalDeductions => InsuranceDeduction + TaxDeduction + OtherDeductions;

    public decimal NetSalary { get; set; }
    public bool IsPaid { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string? Note { get; set; }
}

public class CalculateSalaryDto
{
    [Required]
    public int EmployeeId { get; set; }

    [Range(1, 12, ErrorMessage = "Tháng từ 1 đến 12")]
    public int Month { get; set; }

    [Range(2000, 2100, ErrorMessage = "Năm không hợp lệ")]
    public int Year { get; set; }

    public decimal OvertimeAllowance { get; set; } = 0; // Giờ dạy vượt mức
    public decimal Bonus { get; set; } = 0;
    public decimal OtherDeductions { get; set; } = 0;
    public string? Note { get; set; }
}
