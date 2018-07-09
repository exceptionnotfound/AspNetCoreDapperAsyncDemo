using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCoreTest.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
