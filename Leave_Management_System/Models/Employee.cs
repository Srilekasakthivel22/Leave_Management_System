using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models
{
    public class Employee
    {
        [Required]
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string EmployeePassword { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmployeeEmailId { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string EmployeeMobileNo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EmployeeDoj { get; set; }

        [Required]
        public string EmployeeDept { get; set; }

        public int ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        public virtual Manager Manager { get; set; }
    }
}
