using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookApi.Models;

using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Tên đăng nhập là bắt buộc")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên đăng nhập phải từ 3 đến 50 ký tự")]
    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6 đến 100 ký tự")]
    public string PasswordHash { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email là bắt buộc")]
    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    [StringLength(255, ErrorMessage = "Email không được vượt quá 255 ký tự")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vai trò là bắt buộc")]
    [RegularExpression("^(Admin|HRManager|Dean|Employee)$", ErrorMessage = "Vai trò không hợp lệ")]
    [StringLength(50, ErrorMessage = "Vai trò không được vượt quá 50 ký tự")]
    public string Role { get; set; } = "Employee"; // Admin, HRManager (Phòng TCCB), Dean (Trưởng khoa), Employee (GV/NV)

    [Required(ErrorMessage = "Trạng thái là bắt buộc")]
    public bool IsActive { get; set; } = true;

    [Required(ErrorMessage = "Ngày tạo là bắt buộc")]

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // 1-1 Relationship with Employee
    [Range(1, int.MaxValue, ErrorMessage = "Mã nhân viên không hợp lệ")]
    public int? EmployeeId { get; set; }

    public Employee? Employee { get; set; }
}
