namespace BookApi.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = "Employee"; // Admin, HRManager (Phòng TCCB), Dean (Trưởng khoa), Employee (GV/NV)
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // 1-1 Relationship with Employee
    public int? EmployeeId { get; set; }
    public Employee? Employee { get; set; }
}
