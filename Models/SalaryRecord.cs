namespace BookApi.Models;

public class SalaryRecord
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    public int Month { get; set; }
    public int Year { get; set; }

    public decimal BaseSalary { get; set; }              // Lương cơ sở / Lương HĐ
    public decimal Coefficient { get; set; } = 1.0m;     // Hệ số lương
    
    // Các khoản phụ cấp
    public decimal PositionAllowance { get; set; } = 0;   // Phụ cấp chức vụ
    public decimal TeachingAllowance { get; set; } = 0;   // Phụ cấp đứng lớp / giảng dạy
    public decimal SeniorityAllowance { get; set; } = 0;  // Phụ cấp thâm niên
    public decimal OvertimeAllowance { get; set; } = 0;   // Tiền giờ dạy vượt định mức / nghiên cứu khoa học
    public decimal Bonus { get; set; } = 0;               // Thưởng

    // Các khoản giảm trừ
    public decimal InsuranceDeduction { get; set; } = 0;  // Bảo hiểm (BHXH, BHYT, BHTN: ~10.5%)
    public decimal TaxDeduction { get; set; } = 0;        // Thuế TNCN
    public decimal OtherDeductions { get; set; } = 0;     // Khấu trừ khác

    // Thực lĩnh
    public decimal NetSalary { get; set; }                // Lương thực lĩnh
    public bool IsPaid { get; set; } = false;             // Trạng thái chi trả
    public DateTime? PaymentDate { get; set; }
    public string? Note { get; set; }
}
