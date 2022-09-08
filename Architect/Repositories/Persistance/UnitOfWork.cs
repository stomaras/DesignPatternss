using DAL;
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
        private readonly MainDBContext context;
        
        public UnitOfWork(MainDBContext dbContext)
        {
            context = dbContext;
            Cars = new CarRepository(context);
            Motors = new MotorRepository(context);
        }



        public ICarRepository Cars { get; private set; }

        public IMotorRepository Motors { get; private set; }

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
