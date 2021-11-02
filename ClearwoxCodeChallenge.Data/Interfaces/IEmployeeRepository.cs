using ClearwoxCodeChallenge.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.Data.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
        IList<Employee> GetEmployeeByDepartment(int departmentId);
    }
}
