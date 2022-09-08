using Leave_Management_System.Models;
using Leave_Management_System.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo employeeRepo;

        public EmployeeController(IEmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmp()
        {
            var employees = await employeeRepo.GetAllEmployee();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchById(int id)
        {
            var employees = await employeeRepo.GetEmployeeById(id);
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmp(Employee employee)
        {
            var employees = await employeeRepo.AddEmployee(new Employee { EmployeePassword = employee.EmployeePassword, FullName = employee.FullName, EmployeeEmailId = employee.EmployeeEmailId, EmployeeMobileNo = employee.EmployeeMobileNo, EmployeeDoj = employee.EmployeeDoj, EmployeeDept = employee.EmployeeDept, ManagerId = employee.ManagerId });
            return Ok(employees);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmp(int id)
        {
            var employees = await employeeRepo.DeleteEmployee(id);
            return Ok(employees);
        }
    }

}



