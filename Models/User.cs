using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookApi.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Id tự tăng (1, 2, 3...)
    public int Id { get; set; }

    [Required]
    [MaxLength(50)] // Giới hạn độ dài chuỗi để tránh cột nvarchar(MAX)
    public string Username { get; set; } = string.Empty;

    [Required]  
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vui lòng chọn vai trò")]
    [MaxLength(20)]
    public string Role { get; set; } = "Employee"; // Admin, HRManager (Phòng TCCB), Dean (Trưởng khoa), Employee (GV/NV)

    public bool IsActive { get; set; } = true;
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // 1-1 Relationship with Employee
    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
}
