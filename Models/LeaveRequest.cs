using System.ComponentModel.DataAnnotations;
using BookApi.Models.Enums;

namespace BookApi.Models;

public class LeaveRequest
{
    public int Id { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Mã nhân viên không hợp lệ")]
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    [Required(ErrorMessage = "Loại nghỉ phép là bắt buộc")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Loại nghỉ phép phải từ 2 đến 50 ký tự")]
    public string LeaveType { get; set; } = string.Empty; // Nghỉ phép năm, Thai sản, Nghỉ ốm, Đi công tác/Hội thảo

    [Required(ErrorMessage = "Ngày bắt đầu nghỉ là bắt buộc")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Ngày kết thúc nghỉ là bắt buộc")]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Lý do nghỉ là bắt buộc")]
    [StringLength(1000, MinimumLength = 5, ErrorMessage = "Lý do nghỉ phải từ 5 đến 1000 ký tự")]
    public string Reason { get; set; } = string.Empty;

    [EnumDataType(typeof(LeaveStatus), ErrorMessage = "Trạng thái nghỉ không hợp lệ")]
    public LeaveStatus Status { get; set; } = LeaveStatus.Pending;

    [Range(1, int.MaxValue, ErrorMessage = "Người duyệt không hợp lệ")]
    public int? ApproverId { get; set; } // Trưởng khoa hoặc Trưởng phòng TCCB duyệt
    public Employee? Approver { get; set; }
    public DateTime? ApprovedAt { get; set; }

    [StringLength(500, ErrorMessage = "Nhận xét không được vượt quá 500 ký tự")]
    public string? ApproverComment { get; set; }
}
