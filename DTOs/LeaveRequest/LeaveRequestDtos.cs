using System.ComponentModel.DataAnnotations;
using BookApi.Models.Enums;

namespace BookApi.DTOs.LeaveRequest;

public class LeaveRequestDto
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public string EmployeeCode { get; set; } = string.Empty;
    public string EmployeeName { get; set; } = string.Empty;
    public string DepartmentName { get; set; } = string.Empty;

    public string LeaveType { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int TotalDays => (EndDate.Date - StartDate.Date).Days + 1;
    public string Reason { get; set; } = string.Empty;

    public LeaveStatus Status { get; set; }
    public string StatusName => Status switch
    {
        LeaveStatus.Pending => "Chờ duyệt",
        LeaveStatus.Approved => "Đã duyệt",
        LeaveStatus.Rejected => "Từ chối",
        _ => "Không xác định"
    };

    public int? ApproverId { get; set; }
    public string? ApproverName { get; set; }
    public DateTime? ApprovedAt { get; set; }
    public string? ApproverComment { get; set; }
}

public class CreateLeaveRequestDto
{
    [Required(ErrorMessage = "Mã nhân viên là bắt buộc")]
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Loại nghỉ phép là bắt buộc")]
    public string LeaveType { get; set; } = string.Empty; // Nghỉ phép năm, Công tác/Hội thảo, Thai sản...

    [Required(ErrorMessage = "Ngày bắt đầu là bắt buộc")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Ngày kết thúc là bắt buộc")]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Lý do là bắt buộc")]
    public string Reason { get; set; } = string.Empty;
}

public class ApproveLeaveRequestDto
{
    [Required]
    public int ApproverId { get; set; }

    public bool IsApproved { get; set; } // true: Duyệt, false: Từ chối
    public string? Comment { get; set; }
}
