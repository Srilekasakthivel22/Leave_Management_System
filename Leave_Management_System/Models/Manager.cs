using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models
{
    public class Manager
    {
        [Required]
        [Key]
        public int ManagerId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ManagerPassword { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string ManagerEmailId { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int ManagerMobileNo { get; set; }
    }
}
