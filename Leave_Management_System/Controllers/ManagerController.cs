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
    public class ManagerController : ControllerBase
    {
        private readonly IManagerRepo managerRepo;

        public ManagerController(IManagerRepo managerRepo)
        {
            this.managerRepo = managerRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmp()
        {
            var employees = await managerRepo.GetAllManager();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> SearchById(int id)
        {
            var employees = await managerRepo.GetManagerById(id);
            return Ok(employees);
        }

    }
}
