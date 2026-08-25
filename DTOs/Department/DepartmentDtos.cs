using System.ComponentModel.DataAnnotations;

namespace BookApi.DTOs.Department;

public class DepartmentDto
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? OfficeLocation { get; set; }
    public int TotalEmployees { get; set; }
}

public class CreateDepartmentDto
{
    [Required(ErrorMessage = "Mã phòng ban/khoa là bắt buộc")]
    public string Code { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tên phòng ban/khoa là bắt buộc")]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? OfficeLocation { get; set; }
}
