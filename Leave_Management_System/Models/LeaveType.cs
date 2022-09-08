using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models
{
    public class LeaveType
    {
        
        [Key]
        [Required]
        public string TypeOfLeave { get; set; }

        [Required]
        public int Days { get; set; }
    }
}
