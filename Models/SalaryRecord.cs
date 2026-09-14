using System.ComponentModel.DataAnnotations;

namespace BookApi.Models;

public class SalaryRecord
{
    public int Id { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Mã nhân viên không hợp lệ")]
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    [Range(1, 12, ErrorMessage = "Tháng phải từ 1 đến 12")]
    public int Month { get; set; }

    [Range(2000, 2100, ErrorMessage = "Năm phải hợp lệ")]
    public int Year { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Lương cơ sở không hợp lệ")]
    public decimal BaseSalary { get; set; } // Lương cơ sở / Lương HĐ

    [Range(0.0, 100.0, ErrorMessage = "Hệ số lương phải nằm trong khoảng 0 đến 100")]
    public decimal Coefficient { get; set; } = 1.0m; // Hệ số lương

    // Các khoản phụ cấp
    [Range(0, double.MaxValue, ErrorMessage = "Phụ cấp chức vụ không hợp lệ")]
    public decimal PositionAllowance { get; set; } = 0; // Phụ cấp chức vụ

    [Range(0, double.MaxValue, ErrorMessage = "Phụ cấp giảng dạy không hợp lệ")]
    public decimal TeachingAllowance { get; set; } = 0; // Phụ cấp đứng lớp / giảng dạy

    [Range(0, double.MaxValue, ErrorMessage = "Phụ cấp thâm niên không hợp lệ")]
    public decimal SeniorityAllowance { get; set; } = 0; // Phụ cấp thâm niên

    [Range(0, double.MaxValue, ErrorMessage = "Tiền giờ tăng ca không hợp lệ")]
    public decimal OvertimeAllowance { get; set; } = 0; // Tiền giờ dạy vượt định mức / nghiên cứu khoa học

    [Range(0, double.MaxValue, ErrorMessage = "Thưởng không hợp lệ")]
    public decimal Bonus { get; set; } = 0; // Thưởng

    // Các khoản giảm trừ
    [Range(0, double.MaxValue, ErrorMessage = "Bảo hiểm không hợp lệ")]
    public decimal InsuranceDeduction { get; set; } = 0; // Bảo hiểm (BHXH, BHYT, BHTN: ~10.5%)

    [Range(0, double.MaxValue, ErrorMessage = "Thuế không hợp lệ")]
    public decimal TaxDeduction { get; set; } = 0; // Thuế TNCN

    [Range(0, double.MaxValue, ErrorMessage = "Khấu trừ khác không hợp lệ")]
    public decimal OtherDeductions { get; set; } = 0; // Khấu trừ khác

    // Thực lĩnh
    [Range(0, double.MaxValue, ErrorMessage = "Lương thực lĩnh không hợp lệ")]
    public decimal NetSalary { get; set; } // Lương thực lĩnh

    public bool IsPaid { get; set; } = false; // Trạng thái chi trả
    public DateTime? PaymentDate { get; set; }

    [StringLength(500, ErrorMessage = "Ghi chú không được vượt quá 500 ký tự")]
    public string? Note { get; set; }
}
