using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIModel.Model
{
    public class EmployeeDTO
    {
        public int EmpID { get; set; }
        public string? EmpName { get; set; }
        public string? EmpCode { get; set; }
        public int DeptID { get; set; }
    }
}
