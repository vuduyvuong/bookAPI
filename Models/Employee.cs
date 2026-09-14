using BookApi.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookApi.Models;

public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string EmployeeCode { get; set; } = string.Empty; // Mã cán bộ/GV: UDA-0102
    [Required]
    [MaxLength(100)]
    public string FullName { get; set; } = string.Empty;
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public Gender Gender { get; set; }
    [Required]
    [MaxLength(20)]
    public string IdentityCardNumber { get; set; } = string.Empty; // CCCD
    [Required]
    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;              // Email trường: abc@donga.edu.vn
    [MaxLength(20)]
    [Phone]
    public string PhoneNumber { get; set; } = string.Empty;
    [MaxLength(200)]
    public string? Address { get; set; }
    [Required]
    public DateTime HireDate { get; set; }                          // Ngày bắt đầu làm việc tại ĐH Đông Á

    // Thông tin học hàm - học vị chuyên môn

    public AcademicDegree Degree { get; set; } = AcademicDegree.Bachelor;

    [MaxLength(200)]
    public string? AcademicSpecialization { get; set; }             // Chuyên ngành: Công nghệ phần mềm, Trí tuệ nhân tạo...

    // Trạng thái nhân sự
    public EmployeeStatus Status { get; set; } = EmployeeStatus.Active;

    // Khoa / Phòng ban
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }

    // Chức vụ
    public int PositionId { get; set; }
    public Position? Position { get; set; }

    // Quan hệ khác
    public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
    public ICollection<SalaryRecord> SalaryRecords { get; set; } = new List<SalaryRecord>();
    public ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();
    public int? UserId { get; set; }
    public User? User { get; set; }
}
