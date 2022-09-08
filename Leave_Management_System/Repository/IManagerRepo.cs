using Leave_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Repository
{
    public interface IManagerRepo
    {
        Task<List<Manager>> GetAllManager();

        Task<Manager> GetManagerById(int id);
    }
}
