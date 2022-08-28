using Contexts;
using Repositories.Core;
using Repositories.Core.Repositories;
using Repositories.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmpPortalContext context;
        public IEmployeeRepository Employees { get; private set; }

        public IEmpoyeeTypeRepository EmployeesTypes { get; private set; }


        public UnitOfWork(EmpPortalContext dbContext)
        {
            context = dbContext;
            Employees = new EmployeeRepository(context);
            EmployeesTypes = new EmployeeTypeRepository(context);
        }

        
        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
