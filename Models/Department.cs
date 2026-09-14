namespace BookApi.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Department
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(10)]
    public string Code { get; set; } = string.Empty; // Ví dụ: FIT, P.DT, P.TCCB

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty; // Ví dụ: Khoa Công nghệ thông tin

    [MaxLength(200)]
    public string? Description { get; set; }
    [MaxLength(20)]
    [Phone]
    public string? PhoneNumber { get; set; }
    [EmailAddress]
    [MaxLength(100)]
    public string? Email { get; set; }
    [MaxLength(200)]
    public string? OfficeLocation { get; set; } // Ví dụ: Phòng 302 - Khu A, ĐH Đông Á

    // Navigation properties
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
