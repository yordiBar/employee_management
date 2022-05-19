namespace employee_management.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public DateTime StartDate { get; set; }
        public string? PhotoFileName { get; set; }
    }
}
