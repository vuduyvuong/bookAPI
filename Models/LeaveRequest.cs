using BookApi.Models.Enums;

namespace BookApi.Models;

public class LeaveRequest
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    public string LeaveType { get; set; } = string.Empty; // Nghỉ phép năm, Thai sản, Nghỉ ốm, Đi công tác/Hội thảo
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; } = string.Empty;

    public LeaveStatus Status { get; set; } = LeaveStatus.Pending;
    public int? ApproverId { get; set; }                   // Trưởng khoa hoặc Trưởng phòng TCCB duyệt
    public Employee? Approver { get; set; }
    public DateTime? ApprovedAt { get; set; }
    public string? ApproverComment { get; set; }
}
