using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EmployeeType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }
           
    }
}
