namespace Leave.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FIRSTNAME { get; set; } = string.Empty; // قيمة افتراضية
        public string LASTNAME { get; set; } = string.Empty; // قيمة افتراضية
        public string POSITION { get; set; } = string.Empty; // قيمة افتراضية
        public string EmployeeName { get; set; } = string.Empty; // قيمة افتراضية
        public string Email { get; set; } = string.Empty; // قيمة افتراضية
        public string ManagerName { get; set; } = string.Empty; // قيمة افتراضية
    }
}
