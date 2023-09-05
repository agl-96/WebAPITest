using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPITestService.Contract;
using WebAPITestService.Entity;

namespace WebAPITestService.Repository
{
    public class EmployeeRepositoy : IEmployee
    {
        private readonly RepositoryContext _repositoryContext;
        public EmployeeRepositoy(RepositoryContext repositoryContext)
        {
                _repositoryContext = repositoryContext;
        }
        public async Task <List<Employee>> ListEmployee()
        {
            return await _repositoryContext.Employee.ToListAsync();
           // throw new NotImplementedException();
        }

        public async Task<bool> RegisterEmployee(Employee employee)
        {
            var res = await _repositoryContext.Employee.AddAsync(employee);
            await _repositoryContext.SaveChangesAsync();
            if (employee.EmpID > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public async Task<Employee> FindEmployeeByID(int id) 
        {
            var emp = await _repositoryContext.Employee.Where(x=>x.EmpID==id).SingleOrDefaultAsync();
            return emp;
          
        }
        public async Task<bool> UpdateEmployee(Employee employee)
        {
            var result =  _repositoryContext.Employee.Update(employee);
            var res= await _repositoryContext.SaveChangesAsync();
            if (res > 0)
            {
                return true;
            }
            return false;

        }
    }
}
