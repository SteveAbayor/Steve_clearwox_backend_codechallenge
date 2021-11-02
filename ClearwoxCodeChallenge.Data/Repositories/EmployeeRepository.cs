using ClearwoxCodeChallenge.Data.Interfaces;
using ClearwoxCodeChallenge.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees;
        List<Department> _departments;
        public EmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee { EmployeeId = 1, FirstName = "James", LastName = "John", JobTitle = "Developer", AddressOfResidence = "Lagos", DepartmentId = 1},
                new Employee { EmployeeId = 2, FirstName = "Grace", LastName = "Iretioluwa", JobTitle = "Accounting", AddressOfResidence = "Lagos", DepartmentId = 1},
                new Employee { EmployeeId = 3, FirstName = "James", LastName = "Richards", JobTitle = "Developer", AddressOfResidence = "Ogun", DepartmentId = 1},
                new Employee { EmployeeId = 4, FirstName = "Charlse", LastName = "Olorunfemi", JobTitle = "Developer", AddressOfResidence = "Lagos", DepartmentId = 2}
            };

            _departments = new List<Department>(){
                new Department()
                {
                    DepartmentId = 1,
                    Name = "Finance",
                    UniqueAddress = "Anywhere"
                },
                new Department()
                {
                    DepartmentId = 2,
                    Name = "Sales",
                    UniqueAddress = "Anywhere"
                }
             };
        }


        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public IList<Employee> ListAll()
        {
            return _employees;
        }

        public IList<Employee> GetEmployeeByDepartment(int departmentId)
        {
            return _employees.Where(x => x.DepartmentId == departmentId).ToList();
        }
    }
}
