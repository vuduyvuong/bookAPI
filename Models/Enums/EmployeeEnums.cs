namespace BookApi.Models.Enums;

public enum Gender
{
    Male = 1,
    Female = 2,
    Other = 3
}

public enum EmployeeStatus
{
    Active = 1,     // Đang làm việc
    OnLeave = 2,    // Đang tạm nghỉ (thai sản, ốm đau...)
    Resigned = 3,   // Đã thôi việc
    Retired = 4     // Đã nghỉ hưu
}

public enum AcademicDegree
{
    Bachelor = 1,           // Cử nhân / Kỹ sư
    Master = 2,             // Thạc sĩ
    Doctorate = 3,          // Tiến sĩ
    AssociateProfessor = 4, // Phó Giáo sư
    Professor = 5           // Giáo sư
}

public enum ContractType
{
    Probation = 1,          // Thử việc
    DefiniteTerm = 2,       // Hợp đồng xác định thời hạn (1 - 3 năm)
    IndefiniteTerm = 3,     // Hợp đồng không xác định thời hạn
    VisitingLecturer = 4    // Giảng viên thỉnh giảng
}

public enum LeaveStatus
{
    Pending = 1,    // Đang chờ duyệt
    Approved = 2,   // Đã duyệt
    Rejected = 3    // Từ chối
}
