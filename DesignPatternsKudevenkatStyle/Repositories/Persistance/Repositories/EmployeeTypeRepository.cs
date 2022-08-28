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
    public class EmployeeTypeRepository : GenericRepository<EmployeeType>, IEmpoyeeTypeRepository
    {
        public EmployeeTypeRepository(EmpPortalContext context) :base(context)
        {

        }
    }
}
