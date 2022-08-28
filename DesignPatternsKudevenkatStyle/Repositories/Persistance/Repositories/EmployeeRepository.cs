using Contexts;
using Entities;
using Repositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repositories.Persistance.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmpPortalContext context) : base(context)
        {

        }

        public IEnumerable<Employee> EmployeesWithTypes()
        {
            var groups = table.Include(x => x.EmployeeType).ToList();
            return groups;
        }
    }
}
