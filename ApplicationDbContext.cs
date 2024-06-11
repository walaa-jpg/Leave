using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Leave.Models;// استبدل YourNamespace بالنطاق الصحيح لمشروعك


    public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }
}


