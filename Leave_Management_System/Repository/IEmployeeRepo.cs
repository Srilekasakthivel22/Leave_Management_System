using Leave_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Repository
{
     public interface IEmployeeRepo
    {
        Task<List<Employee>> GetAllEmployee();

        Task<Employee> GetEmployeeById(int empid);

        Task<int> AddEmployee(Employee employee);

        Task<int> DeleteEmployee(int empid);
    }
}
