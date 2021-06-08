using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperCoreTest.Models;
using DapperCoreTest.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperCoreTest.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetByID(int id)
        {
            return await _employeeRepo.GetByID(id);
        }

        [HttpGet("dob/{dateOfBirth}")]
        public async Task<ActionResult<List<Employee>>> GetByID(DateTime dateOfBirth)
        {
            return await _employeeRepo.GetByDateOfBirth(dateOfBirth);
        }
    }
}