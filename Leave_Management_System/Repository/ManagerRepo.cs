using Leave_Management_System.DataBase;
using Leave_Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Repository
{
    public class ManagerRepo
    {
        private readonly LMSConnect lMSConnect;

        public ManagerRepo(LMSConnect lMSConnect)
        {
            this.lMSConnect = lMSConnect;
        }

        public async Task<List<Manager>> GetAllManager()
        {
            var ar = await lMSConnect.Managers.ToListAsync();
            return ar;
        }
        public async Task<Manager> GetManagerById(int id)
        {
            var ar = await lMSConnect.Managers.Where(x => x.ManagerId == id).FirstOrDefaultAsync();
            return ar;
        }
    }
}
