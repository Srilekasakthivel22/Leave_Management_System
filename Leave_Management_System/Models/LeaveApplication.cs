using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_System.Models
{
    public class LeaveApplication
    {
        [Required]
        [Key]
        public int LeaveId { get; set; }

        [Required]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId ")]
        public virtual Employee Employee { get; set; }
        
        [Required]
        public int NoOfDays { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        [Required]
        public string TypeOfLeave { get; set; }
        [ForeignKey("TypeOfLeave")]
        public virtual LeaveType LeaveType { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Reason { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime AppliedOn { get; set; }

        public string Manager_Comment { get; set; }
        [Required]
        public int Leave_Balance { get; set; }
    }
}
