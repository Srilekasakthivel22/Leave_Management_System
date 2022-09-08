using Leave_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.DataBase
{
    public class LMSConnect:DbContext
    {
        public LMSConnect(DbContextOptions<LMSConnect> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<EmployeeLeave> EmployeeLeaves { get; set; }

        public DbSet<LeaveApplication> LeaveApplications { get; set; }

        public DbSet<LeaveType> LeaveTypes { get; set; }

       
    }
}
