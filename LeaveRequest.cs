namespace Leave.Models
{
    public class LeaveRequest
    {
        public int LeaveRequestID { get; set; }
        public int EmployeeID { get; set; }
        public string LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public bool ManagerApproval { get; set; }
    }
}
