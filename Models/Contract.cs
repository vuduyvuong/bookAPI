using BookApi.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApi.Models;

public class Contract
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string ContractNumber { get; set; } = string.Empty; // Số HĐ: HĐLD-UDA/2026/001

    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    public ContractType Type { get; set; } = ContractType.DefiniteTerm;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal BaseSalary { get; set; }         // Mức lương cơ bản

    [Column(TypeName = "decimal(5,2)")]
    [Range(typeof(decimal), "0", "999.99")]
    public decimal SalaryCoefficient { get; set; } = 1.0m; // Hệ số lương (theo bậc giảng viên/chuyên viên)

    [MaxLength(1000)]
    public string? Terms { get; set; }              // Điều khoản bổ sung
    public bool IsActive { get; set; } = true;
}
