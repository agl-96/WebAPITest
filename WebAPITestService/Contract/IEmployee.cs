using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITestService.Entity;

namespace WebAPITestService.Contract
{
    public interface IEmployee
    {
        public Task<bool> RegisterEmployee(Employee employee);
        public Task<bool> UpdateEmployee(Employee employee);
        public Task<List<Employee>> ListEmployee();
        public Task<Employee> FindEmployeeByID(int id);
    }
}
