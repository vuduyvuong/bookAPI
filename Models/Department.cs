namespace BookApi.Models;

public class Department
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty; // Ví dụ: FIT, P.DT, P.TCCB
    public string Name { get; set; } = string.Empty; // Ví dụ: Khoa Công nghệ thông tin
    public string? Description { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? OfficeLocation { get; set; } // Ví dụ: Phòng 302 - Khu A, ĐH Đông Á

    // Navigation properties
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
