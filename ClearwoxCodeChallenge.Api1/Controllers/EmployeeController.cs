using ClearwoxCodeChallenge.Data.Interfaces;
using ClearwoxCodeChallenge.Data.Models;
using ClearwoxCodeChallenge.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employeesRepository;

        public EmployeeController(IEmployeeRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }
        private IEmployeeRepository employees = new EmployeeRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            return Ok(_employeesRepository.GetAll());
        }

        [Route("api/employee/department/{departmentId}")]
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployee(int departmentId)
        {
            var employee = _employeesRepository.GetEmployeeByDepartment(departmentId);

            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

    }
}
