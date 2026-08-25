namespace BookApi.Models;

public class Position
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty; // Ví dụ: TK (Trưởng khoa), GV (Giảng viên), CV (Chuyên viên)
    public string Title { get; set; } = string.Empty; // Chức vụ: Trưởng khoa, Phó Trưởng khoa, Giảng viên chính...
    public decimal AllowanceRate { get; set; } = 0;   // Phụ cấp chức vụ (hệ số hoặc số tiền)
    public string? Description { get; set; }

    // Navigation properties
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
