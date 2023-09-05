using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITestService.Entity
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpID { get; set; }
        public string? EmpName { get; set; }
        public string? EmpCode { get; set; }

        [ForeignKey("DeptID")]
        public Department Department { get; set; } = new();
        public int DeptID { get; set; }

    }
}
