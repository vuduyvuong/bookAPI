namespace BookApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SalaryRecord
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    [Range(1, 12)]
    public int Month { get; set; }

    [Range(2000, 2100)]
    public int Year { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal BaseSalary { get; set; }              // Lương cơ sở / Lương HĐ

    [Column(TypeName = "decimal(5,2)")]
    [Range(typeof(decimal), "0", "999.99")]
    public decimal Coefficient { get; set; } = 1.0m;     // Hệ số lương

    // Các khoản phụ cấp
    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal PositionAllowance { get; set; } = 0;   // Phụ cấp chức vụ

    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal TeachingAllowance { get; set; } = 0;   // Phụ cấp đứng lớp / giảng dạy

    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal SeniorityAllowance { get; set; } = 0;  // Phụ cấp thâm niên

    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal OvertimeAllowance { get; set; } = 0;   // Tiền giờ dạy vượt định mức / nghiên cứu khoa học

    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal Bonus { get; set; } = 0;               // Thưởng

    // Các khoản giảm trừ
    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal InsuranceDeduction { get; set; } = 0;  // Bảo hiểm (BHXH, BHYT, BHTN: ~10.5%)

    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal TaxDeduction { get; set; } = 0;        // Thuế TNCN

    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal OtherDeductions { get; set; } = 0;     // Khấu trừ khác

    // Thực lĩnh
    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal NetSalary { get; set; }                // Lương thực lĩnh
    public bool IsPaid { get; set; } = false;             // Trạng thái chi trả
    public DateTime? PaymentDate { get; set; }
    [MaxLength(500)]
    public string? Note { get; set; }
}
