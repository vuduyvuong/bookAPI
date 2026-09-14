using System.ComponentModel.DataAnnotations;

namespace BookApi.Models;

public class Department
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Mã khoa/phòng ban là bắt buộc")]
    [StringLength(20, MinimumLength = 2, ErrorMessage = "Mã khoa/phòng ban phải từ 2 đến 20 ký tự")]
    public string Code { get; set; } = string.Empty; // Ví dụ: FIT, P.DT, P.TCCB

    [Required(ErrorMessage = "Tên khoa/phòng ban là bắt buộc")]
    [StringLength(150, MinimumLength = 2, ErrorMessage = "Tên khoa/phòng ban phải từ 2 đến 150 ký tự")]
    public string Name { get; set; } = string.Empty; // Ví dụ: Khoa Công nghệ thông tin

    [StringLength(500, ErrorMessage = "Mô tả không được vượt quá 500 ký tự")]
    public string? Description { get; set; }

    [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
    [StringLength(20, ErrorMessage = "Số điện thoại không được vượt quá 20 ký tự")]
    public string? PhoneNumber { get; set; }

    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    [StringLength(255, ErrorMessage = "Email không được vượt quá 255 ký tự")]
    public string? Email { get; set; }

    [StringLength(200, ErrorMessage = "Vị trí làm việc không được vượt quá 200 ký tự")]
    public string? OfficeLocation { get; set; } // Ví dụ: Phòng 302 - Khu A, ĐH Đông Á

    // Navigation properties
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
