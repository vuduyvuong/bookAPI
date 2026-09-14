namespace BookApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Position
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Code { get; set; } = string.Empty; // Ví dụ: TK (Trưởng khoa), GV (Giảng viên), CV (Chuyên viên)

    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty; // Chức vụ: Trưởng khoa, Phó Trưởng khoa, Giảng viên chính...

    [Column(TypeName = "decimal(5,2)")]
    [Range(typeof(decimal), "0", "999.99")]
    public decimal AllowanceRate { get; set; } = 0;   // Phụ cấp chức vụ (hệ số hoặc số tiền)

    [MaxLength(200)]
    public string? Description { get; set; }

    // Navigation properties
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
