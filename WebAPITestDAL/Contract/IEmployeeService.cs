using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIModel.Model;

namespace WebAPITestDAL.Contract
{
    public interface IEmployeeService
    {
        public Task<Response> RegisterEmployeeService(RegisterEmployee registerEmployee);
        public Task<Response> UpdateEmployeeService(UpdateEmployee updateEmployee);
        public Task<Response> ListEmployeeService();
    }
}
