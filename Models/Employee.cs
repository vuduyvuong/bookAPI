using System.ComponentModel.DataAnnotations;
using BookApi.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookApi.Models;

public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Mã nhân viên là bắt buộc")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Mã nhân viên phải từ 3 đến 20 ký tự")]
    public string EmployeeCode { get; set; } = string.Empty; // Mã cán bộ/GV: UDA-0102

    [Required(ErrorMessage = "Họ tên là bắt buộc")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Họ tên phải từ 2 đến 100 ký tự")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
    public DateTime DateOfBirth { get; set; }

    [EnumDataType(typeof(Gender), ErrorMessage = "Giới tính không hợp lệ")]
    public Gender Gender { get; set; }

    [Required(ErrorMessage = "Số CMND/CCCD là bắt buộc")]
    [RegularExpression(@"^\d{9,12}$", ErrorMessage = "Số CMND/CCCD phải gồm 9 đến 12 chữ số")]
    public string IdentityCardNumber { get; set; } = string.Empty; // CCCD

    [Required(ErrorMessage = "Email là bắt buộc")]
    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    [StringLength(255, ErrorMessage = "Email không được vượt quá 255 ký tự")]
    public string Email { get; set; } = string.Empty; // Email trường: abc@donga.edu.vn

    [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
    [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
    [StringLength(20, ErrorMessage = "Số điện thoại không được vượt quá 20 ký tự")]
    public string PhoneNumber { get; set; } = string.Empty;

    [StringLength(255, ErrorMessage = "Địa chỉ không được vượt quá 255 ký tự")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Ngày tuyển dụng là bắt buộc")]
    public DateTime HireDate { get; set; } // Ngày bắt đầu làm việc tại ĐH Đông Á

    // Thông tin học hàm - học vị chuyên môn
    [EnumDataType(typeof(AcademicDegree), ErrorMessage = "Học vị không hợp lệ")]
    public AcademicDegree Degree { get; set; } = AcademicDegree.Bachelor;

    [StringLength(100, ErrorMessage = "Chuyên ngành không được vượt quá 100 ký tự")]
    public string? AcademicSpecialization { get; set; } // Chuyên ngành: Công nghệ phần mềm, Trí tuệ nhân tạo...


    // Trạng thái nhân sự
    [EnumDataType(typeof(EmployeeStatus), ErrorMessage = "Trạng thái nhân sự không hợp lệ")]
    public EmployeeStatus Status { get; set; } = EmployeeStatus.Active;

    // Khoa / Phòng ban
    [Range(1, int.MaxValue, ErrorMessage = "Khoa/Phòng ban không hợp lệ")]
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }

    // Chức vụ
    [Range(1, int.MaxValue, ErrorMessage = "Chức vụ không hợp lệ")]
    public int PositionId { get; set; }
    public Position? Position { get; set; }

    // Quan hệ khác
    public ICollection<Contract> Contracts { get; set; } = new List<Contract>();
    public ICollection<SalaryRecord> SalaryRecords { get; set; } = new List<SalaryRecord>();
    public ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    [Range(1, int.MaxValue, ErrorMessage = "UserId không hợp lệ")]
    public int? UserId { get; set; }
    public User? User { get; set; }
}
