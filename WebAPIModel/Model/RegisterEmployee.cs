using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIModel.Model
{
    public class RegisterEmployee
    {
       
        public string? EmpName { get; set; }
        public string? EmpCode { get; set; }
        public int DeptID { get; set; }
    }
}
