using Leave_Management_System.DataBase;
using Leave_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly LMSConnect lMSConnect;

        public EmployeeRepo(LMSConnect lMSConnect)
        {
            this.lMSConnect = lMSConnect;
        }
        public async Task<List<Employee>> GetAllEmployee()
        {
            var ar = await lMSConnect.Employees.ToListAsync();
            return ar;
        }
        public async Task<Employee> GetEmployeeById(int empid)
        {
            var ar = await lMSConnect.Employees.Where(x => x.EmployeeId == empid).FirstOrDefaultAsync();
            return ar;
        }
        public async Task<int> AddEmployee(Employee employee)
        {
            lMSConnect.Employees.Add(new Employee { EmployeePassword = employee.EmployeePassword, FullName = employee.FullName, EmployeeEmailId = employee.EmployeeEmailId, EmployeeMobileNo = employee.EmployeeMobileNo,EmployeeDoj=employee.EmployeeDoj,EmployeeDept=employee.EmployeeDept,ManagerId=employee.ManagerId });
            await lMSConnect.SaveChangesAsync();
            return employee.EmployeeId;
        }

        public async Task<int> DeleteEmployee(int empid)
        {
            var ar = await lMSConnect.Employees.Where(x => x.EmployeeId == empid).FirstOrDefaultAsync();
            if (ar != null)
            {
                lMSConnect.Employees.Remove(ar);
                await lMSConnect.SaveChangesAsync();
            }
            return empid;
        }






    }
}
