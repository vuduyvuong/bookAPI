using BookApi.Models.Enums;

namespace BookApi.Models;

public class Employee
{
    public int Id { get; set; }
    public string EmployeeCode { get; set; } = string.Empty; // Mã cán bộ/GV: UDA-0102
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string IdentityCardNumber { get; set; } = string.Empty; // CCCD
    public string Email { get; set; } = string.Empty;              // Email trường: abc@donga.edu.vn
    public string PhoneNumber { get; set; } = string.Empty;
    public string? Address { get; set; }
    public DateTime HireDate { get; set; }                          // Ngày bắt đầu làm việc tại ĐH Đông Á
    
    // Thông tin học hàm - học vị chuyên môn
    public AcademicDegree Degree { get; set; } = AcademicDegree.Bachelor;
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
