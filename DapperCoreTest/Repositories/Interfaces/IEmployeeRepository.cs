using DapperCoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCoreTest.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByID(int id);
        Task<List<Employee>> GetByDateOfBirth(DateTime dateOfBirth);
    }
}
