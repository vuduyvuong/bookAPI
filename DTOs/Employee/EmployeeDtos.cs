using System.ComponentModel.DataAnnotations;
using BookApi.Models.Enums;

namespace BookApi.DTOs.Employee;

public class EmployeeDto
{
    public int Id { get; set; }
    public string EmployeeCode { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string GenderName => Gender switch
    {
        Gender.Male => "Nam",
        Gender.Female => "Nữ",
        _ => "Khác"
    };
    public string IdentityCardNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string? Address { get; set; }
    public DateTime HireDate { get; set; }
    
    public AcademicDegree Degree { get; set; }
    public string? AcademicSpecialization { get; set; }
    public EmployeeStatus Status { get; set; }

    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; } = string.Empty;

    public int PositionId { get; set; }
    public string PositionTitle { get; set; } = string.Empty;
}

public class CreateEmployeeDto
{
    [Required(ErrorMessage = "Mã cán bộ/giảng viên là bắt buộc")]
    public string EmployeeCode { get; set; } = string.Empty;

    [Required(ErrorMessage = "Họ và tên là bắt buộc")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
    public DateTime DateOfBirth { get; set; }

    public Gender Gender { get; set; } = Gender.Male;

    [Required(ErrorMessage = "Số CCCD là bắt buộc")]
    public string IdentityCardNumber { get; set; } = string.Empty;

    [Required, EmailAddress(ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; } = string.Empty;

    [Required, Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
    public string PhoneNumber { get; set; } = string.Empty;

    public string? Address { get; set; }
    public DateTime HireDate { get; set; } = DateTime.UtcNow;

    public AcademicDegree Degree { get; set; } = AcademicDegree.Bachelor;
    public string? AcademicSpecialization { get; set; }

    [Required(ErrorMessage = "Khoa/Phòng ban là bắt buộc")]
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "Chức vụ là bắt buộc")]
    public int PositionId { get; set; }
}

public class UpdateEmployeeDto
{
    [Required(ErrorMessage = "Họ và tên là bắt buộc")]
    public string FullName { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string IdentityCardNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string? Address { get; set; }

    public AcademicDegree Degree { get; set; }
    public string? AcademicSpecialization { get; set; }
    public EmployeeStatus Status { get; set; }

    public int DepartmentId { get; set; }
    public int PositionId { get; set; }
}
