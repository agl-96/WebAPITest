using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIModel.Model;
using WebAPITestDAL.Contract;
using WebAPITestService.Contract;
using WebAPITestService.Entity;

namespace WebAPITestDAL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployee _employee;
        private readonly Mapper _mapper;
        public EmployeeService(IEmployee employee,Mapper mapper)
        {
                _employee = employee;
            _mapper = mapper;
        }
        public async Task<Response> ListEmployeeService()
        {
            var emp =await _employee.ListEmployee();
            var result = new Response();
            if(emp != null)
            {
                result.ResponseMessage = "Employee data";
                result.StatusCode = 200;
                result.Result = emp;
            }
            return result;
           //  _mapper<List< EmployeeDTO>, List<Employee>>(emp);
        }

        public async Task<Response> RegisterEmployeeService(RegisterEmployee registerEmployee)
        {
            Employee employee = new Employee
            {
                EmpName=registerEmployee.EmpName,
                EmpCode=registerEmployee.EmpCode,
            };
            var result=await _employee.RegisterEmployee(employee);
            var response = new Response();
            if(result)
            {
                response.ResponseMessage = "Employee Registered";
                response.StatusCode = 200;
                response.Result = registerEmployee;
                return response;
            }
            else
            {
                response.ResponseMessage = "Employee not Registered";
                response.StatusCode = 400;
            }
            return response;
            //throw new NotImplementedException();
        }

        public async Task<Response> UpdateEmployeeService(UpdateEmployee updateEmployee)
        {
            var emp = await _employee.FindEmployeeByID(updateEmployee.EmpID);
            var result = new Response();
            var updatedEmployee = new Employee();
            emp.DeptID=updateEmployee.DeptID;
            emp.EmpName=updateEmployee.EmpName; 
            emp.EmpCode=updateEmployee.EmpCode;
            var result1=await _employee.UpdateEmployee(emp);
            if (result1)
            {
                 updatedEmployee = await _employee.FindEmployeeByID(updateEmployee.EmpID);
                 result.StatusCode=200;
                result.ResponseMessage = "Employee Updated";
                result.Result= updateEmployee;
                return result;
            }
            result.StatusCode = 400;
            result.ResponseMessage = "Employee not Updated";
            result.Result = updateEmployee;
            return result;
          //  throw new NotImplementedException();
        }
    }
}
