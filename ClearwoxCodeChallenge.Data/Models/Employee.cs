using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.Data.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string JobTitle { get; set; }
        public string AddressOfResidence { get; set; }
        public int DepartmentId { get; set; }


        [ForeignKey("DepartmentId")]
        public ICollection<Department> Departments { get; set; }
    }
}
