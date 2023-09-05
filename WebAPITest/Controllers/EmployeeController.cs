using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIModel.Model;
using WebAPITestDAL.Contract;

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
                _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            var restult=await _employeeService.ListEmployeeService();
            if (restult.StatusCode == 200)
            {
                return Ok(restult);
            }
            return BadRequest(restult);
        }
        [HttpPost]
        public async Task<IActionResult> RegisterEmployee([FromBody] RegisterEmployee registerEmployee)
        {
            var restult = await _employeeService.ListEmployeeService();

            if (restult.StatusCode == 200)
            {
                return Ok(restult);
            }
            return BadRequest(restult);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployee registerEmployee)
        {
            var restult = await _employeeService.UpdateEmployeeService(registerEmployee);

            if (restult.StatusCode == 200)
            {
                return Ok(restult);
            }
            return BadRequest(restult);
        }
    }
}
