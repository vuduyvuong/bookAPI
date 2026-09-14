using BookApi.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApi.Models;

public class LeaveRequest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int EmployeeId { get; set; }
    public Employee? Employee { get; set; }

    [Required]
    [MaxLength(50)]
    public string LeaveType { get; set; } = string.Empty; // Nghỉ phép năm, Thai sản, Nghỉ ốm, Đi công tác/Hội thảo
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    [Required]
    [MaxLength(500)]
    public string Reason { get; set; } = string.Empty;

    public LeaveStatus Status { get; set; } = LeaveStatus.Pending;
    public int? ApproverId { get; set; }                   // Trưởng khoa hoặc Trưởng phòng TCCB duyệt
    public Employee? Approver { get; set; }
    public DateTime? ApprovedAt { get; set; }

    [MaxLength(500)]
    public string? ApproverComment { get; set; }
}
