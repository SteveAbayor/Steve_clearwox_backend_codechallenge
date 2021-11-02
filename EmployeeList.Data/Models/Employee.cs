using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.Data.Models
{
    public class Employee : Department
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string JobTitle { get; set; }
        public string AddressOfResidence { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
